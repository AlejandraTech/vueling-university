using GestionCuentaBancariaConsole.Class;

namespace GestionCuentaBancariaConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            Bank bank = new Bank();
            Account authenticatedAccount = null;

            while (!exit)
            {
                while (authenticatedAccount == null)
                {
                    Console.WriteLine("----------------------------------------------------");
                    Console.Write("Please enter your account number: ");
                    string accountNumber = Console.ReadLine();
                    Console.Write("Please enter your PIN: ");
                    string pin = Console.ReadLine();

                    authenticatedAccount = bank.Authenticate(accountNumber, pin);
                    if (authenticatedAccount != null)
                    {
                        Console.WriteLine("Authentication successful. Welcome, user with account " + accountNumber + "!");
                    }
                    else
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

                Console.Write("What action do you want to perform? ");
                int option;
                if (!int.TryParse(Console.ReadLine(), out option) || option < 1 || option > 7)
                {
                    Console.WriteLine("Choose an option between 1 and 7");
                    continue;
                }

                try
                {
                    switch (option)
                    {
                        case 1:
                            Console.Write("Money deposit - Please enter an amount: ");
                            decimal depositAmount = decimal.Parse(Console.ReadLine());
                            authenticatedAccount.Deposit(depositAmount);
                            Console.WriteLine("The current balance is: " + authenticatedAccount.Balance);
                            break;

                        case 2:
                            Console.Write("Money withdrawal - Please enter an amount to withdraw: ");
                            decimal withdrawAmount = decimal.Parse(Console.ReadLine());
                            authenticatedAccount.Withdraw(withdrawAmount);
                            Console.WriteLine("The withdrawal has been completed successfully. The current balance is: " + authenticatedAccount.Balance);
                            break;

                        case 3:
                            Console.WriteLine("List of all movements for user with account " + authenticatedAccount.AccountNumber + ":");
                            var movements = authenticatedAccount.GetMovements();
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
                            Console.WriteLine("List of incomes for user with account " + authenticatedAccount.AccountNumber + ":");
                            var incomes = authenticatedAccount.GetIncomes();
                            if (incomes.Count > 0)
                            {
                                foreach (var income in incomes)
                                {
                                    Console.WriteLine(income);
                                }
                            }
                            else
                            {
                                Console.WriteLine("No incomes have been recorded yet.");
                            }
                            break;

                        case 5:
                            Console.WriteLine("List of outcomes for user with account " + authenticatedAccount.AccountNumber + ":");
                            var outcomes = authenticatedAccount.GetOutcomes();
                            if (outcomes.Count > 0)
                            {
                                foreach (var outcome in outcomes)
                                {
                                    Console.WriteLine(outcome);
                                }
                            }
                            else
                            {
                                Console.WriteLine("No outcomes have been recorded yet.");
                            }
                            break;

                        case 6:
                            Console.WriteLine("The current balance for user with account " + authenticatedAccount.AccountNumber + " is: " + authenticatedAccount.Balance);
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
                                    authenticatedAccount = null;
                                }
                                else if (changeAccount.Equals("N", StringComparison.OrdinalIgnoreCase) ||
                                         changeAccount.Equals("No", StringComparison.OrdinalIgnoreCase))
                                {
                                    Console.WriteLine("The current balance is: " + authenticatedAccount.Balance);
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
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
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
                            Console.WriteLine("The current balance is: " + authenticatedAccount.Balance);
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
        }
    }
}
