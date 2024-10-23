// See https://aka.ms/new-console-template for more information
bool exit = false;
decimal balance = 10;
bool isNumber;

List<string> movements = new List<string>();

while (!exit)
{
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
                        balance += numberIncome;
                        movements.Add($"Income: {numberIncome} €");
                        Console.WriteLine("The current balance is: " + balance + " €");
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
                        if (numberOutcome <= balance)
                        {
                            Console.WriteLine("You have requested to withdraw the amount of: " + numberOutcome);
                            balance -= numberOutcome;
                            movements.Add($"Outcome: {numberOutcome} €");
                            Console.WriteLine("The withdrawal has been completed successfully. The current balance is: " + balance + " €");
                        }
                        else
                        {
                            Console.WriteLine("Error! You cannot withdraw an amount greater than your current balance from: " + balance + ".");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("¡Error! Por favor, introduce un valor numérico válido para el retiro.");
                }
            } while (!isNumber || numberOutcome <= 0);
            break;

        case 3:
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("List of all movements:");
            if (movements.Count > 0)
            {
                foreach (var movement in movements)
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
            Console.WriteLine("You have chosen option 4");
            break;
        case 5:
            Console.WriteLine("You have chosen option 5");
            break;
        case 6:
            Console.WriteLine("You have chosen option 6");
            break;
        case 7:
            Console.WriteLine("Exiting the program...");
            exit = true;
            break;
        default:
            Console.WriteLine("Choose an option between 1 and 7");
            break;
    }

    if (option == 1 || option == 2)
    {
        string anotherOperation;

        while (true)
        {
            Console.WriteLine("Would you like to perform another operation? (Y/N)");
            anotherOperation = Console.ReadLine();

            if (anotherOperation.Equals("Y", StringComparison.OrdinalIgnoreCase) ||
                anotherOperation.Equals("Yes", StringComparison.OrdinalIgnoreCase))
            {
                break;
            }
            else if (anotherOperation.Equals("N", StringComparison.OrdinalIgnoreCase) ||
                     anotherOperation.Equals("No", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("The current balance is: " + balance + " €");
                exit = true;
                break;
            }
            else
            {
                Console.WriteLine("Please write Y or N");
            }
        }
    }
}
