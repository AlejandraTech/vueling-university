// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

bool exit = false;
bool isNumber;

List<string> accountNumbers = new List<string> { "123456789", "987654321", "111111111" };
List<string> pins = new List<string> { "1234", "4321", "1111" };
List<decimal> balances = new List<decimal> { 1000, 500, 300 };
List<List<string>> allMovements = new List<List<string>> { new List<string>(), new List<string>(), new List<string>() };
List<List<string>> allIncomes = new List<List<string>> { new List<string>(), new List<string>(), new List<string>() };
List<List<string>> allOutcomes = new List<List<string>> { new List<string>(), new List<string>(), new List<string>() };

int authenticatedUserIndex = -1;

bool authenticated = false;

while (!exit)
{
    while (!authenticated)
    {
        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine("Please enter your account number:");
        string accountNumber = Console.ReadLine();

        Console.WriteLine("Please enter your PIN:");
        string pin = Console.ReadLine();

        for (int i = 0; i < accountNumbers.Count; i++)
        {
            if (accountNumber == accountNumbers[i] && pin == pins[i])
            {
                Console.WriteLine("Authentication successful. Welcome, user with account " + accountNumber + "!");
                authenticatedUserIndex = i;
                authenticated = true;
                break;
            }
        }

        if (!authenticated)
        {
            Console.WriteLine("Invalid account number or PIN. Please try again.");
        }
    }

    Console.WriteLine("-----------------------------------");
    Console.WriteLine("1. Money income");
    Console.WriteLine("2. Money outcome");
    Console.WriteLine("3. List all movements");
    Console.WriteLine("4. List incomes");
    Console.WriteLine("5. List outcomes");
    Console.WriteLine("6. Show current money");
    Console.WriteLine("7. Exit");
    Console.WriteLine("-----------------------------------");

    Console.WriteLine("What action do you want to perform?");

    int option = Convert.ToInt32(Console.ReadLine());

    switch (option)
    {
        case 1:
            decimal numberIncome;
            do
            {
                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine("Money deposit - Please enter an amount:");
                String income = Console.ReadLine();
                isNumber = decimal.TryParse(income, out numberIncome);

                if (isNumber)
                {
                    if (numberIncome <= 0)
                    {
                        Console.WriteLine("Error! The value must be a positive number and cannot be 0.");
                    }
                    else
                    {
                        Console.WriteLine("You have successfully entered: " + numberIncome);
                        balances[authenticatedUserIndex] += numberIncome;
                        allMovements[authenticatedUserIndex].Add($"Income: {numberIncome} €");
                        allIncomes[authenticatedUserIndex].Add($"Income: {numberIncome} €");
                        Console.WriteLine("The current balance is: " + balances[authenticatedUserIndex] + " €");
                    }
                }
                else
                {
                    Console.WriteLine("Error! Please enter a valid numerical value.");
                }
            } while (!isNumber || numberIncome <= 0);
            break;

        case 2:
            decimal numberOutcome;
            do
            {
                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine("Money withdrawal - Please enter an amount to withdraw:");
                String outcome = Console.ReadLine();
                isNumber = decimal.TryParse(outcome, out numberOutcome);

                if (isNumber)
                {
                    if (numberOutcome <= 0)
                    {
                        Console.WriteLine("Error! The value to withdraw must be a positive number and cannot be 0.");
                    }
                    else
                    {
                        if (numberOutcome <= balances[authenticatedUserIndex])
                        {
                            Console.WriteLine("You have requested to withdraw the amount of: " + numberOutcome);
                            balances[authenticatedUserIndex] -= numberOutcome;
                            allMovements[authenticatedUserIndex].Add($"Outcome: {numberOutcome} €");
                            allOutcomes[authenticatedUserIndex].Add($"Outcome: {numberOutcome} €");
                            Console.WriteLine("The withdrawal has been completed successfully. The current balance is: " + balances[authenticatedUserIndex] + " €");
                        }
                        else
                        {
                            Console.WriteLine("Error! You cannot withdraw an amount greater than your current balance of: " + balances[authenticatedUserIndex] + " €.");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Error! Please enter a valid numerical value for the withdrawal.");
                }
            } while (!isNumber || numberOutcome <= 0);
            break;

        case 3:
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("List of all movements for user with account " + accountNumbers[authenticatedUserIndex] + ":");
            if (allMovements[authenticatedUserIndex].Count > 0)
            {
                foreach (var movement in allMovements[authenticatedUserIndex])
                {
                    Console.WriteLine(movement);
                }
            }
            else
            {
                Console.WriteLine("No movements have been recorded yet.");
            }
            break;

        case 4:
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("List of incomes for user with account " + accountNumbers[authenticatedUserIndex] + ":");
            if (allIncomes[authenticatedUserIndex].Count > 0)
            {
                foreach (var incomeMovement in allIncomes[authenticatedUserIndex])
                {
                    Console.WriteLine(incomeMovement);
                }
            }
            else
            {
                Console.WriteLine("No incomes have been recorded yet.");
            }
            break;

        case 5:
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("List of outcomes for user with account " + accountNumbers[authenticatedUserIndex] + ":");
            if (allOutcomes[authenticatedUserIndex].Count > 0)
            {
                foreach (var outcomeMovement in allOutcomes[authenticatedUserIndex])
                {
                    Console.WriteLine(outcomeMovement);
                }
            }
            else
            {
                Console.WriteLine("No outcomes have been recorded yet.");
            }
            break;

        case 6:
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("The current balance for user with account " + accountNumbers[authenticatedUserIndex] + " is: " + balances[authenticatedUserIndex] + " €");
            break;

        case 7:
            string changeAccount;
            do
            {
                Console.WriteLine("Do you want to change your account? (Y/N)");
                changeAccount = Console.ReadLine();

                if (changeAccount.Equals("Y", StringComparison.OrdinalIgnoreCase) ||
                    changeAccount.Equals("Yes", StringComparison.OrdinalIgnoreCase))
                {
                    authenticated = false;
                }
                else if (changeAccount.Equals("N", StringComparison.OrdinalIgnoreCase) ||
                         changeAccount.Equals("No", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("The current balance is: " + balances[authenticatedUserIndex] + " €");
                    Console.WriteLine("Exiting the program...");
                    exit = true;
                }
                else
                {
                    Console.WriteLine("Please indicate Y/N");
                }
            } while (!changeAccount.Equals("Y", StringComparison.OrdinalIgnoreCase) &&
                     !changeAccount.Equals("N", StringComparison.OrdinalIgnoreCase));
            break;

        default:
            Console.WriteLine("Choose an option between 1 and 7");
            break;
    }

    if (option == 1 || option == 2)
    {
        string anotherOperation;
        do
        {
            Console.WriteLine("Would you like to perform another operation? (Y/N)");
            anotherOperation = Console.ReadLine();

            if (anotherOperation.Equals("Y", StringComparison.OrdinalIgnoreCase) ||
                anotherOperation.Equals("Yes", StringComparison.OrdinalIgnoreCase))
            {
                exit = false;
            }
            else if (anotherOperation.Equals("N", StringComparison.OrdinalIgnoreCase) ||
                     anotherOperation.Equals("No", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("The current balance is: " + balances[authenticatedUserIndex] + " €");
                exit = true;
            }
            else
            {
                Console.WriteLine("Please indicate Y/N");
            }
        } while (!anotherOperation.Equals("Y", StringComparison.OrdinalIgnoreCase) &&
                 !anotherOperation.Equals("N", StringComparison.OrdinalIgnoreCase));
    }
}
