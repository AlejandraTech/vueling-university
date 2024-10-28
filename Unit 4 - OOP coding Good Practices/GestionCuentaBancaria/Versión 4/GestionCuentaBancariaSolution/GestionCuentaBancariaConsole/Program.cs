using GestionCuentaBancariaConsole.Class;

namespace GestionCuentaBancariaConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var bank = new Bank();
            Account authenticatedAccount = null;

            while (true)
            {
                authenticatedAccount = AuthenticateUser(bank);

                if (authenticatedAccount == null) continue;

                while (true)
                {
                    DisplayMenu();
                    int option = GetMenuOption();

                    if (option == -1) continue;

                    try
                    {
                        HandleMenuOption(option, authenticatedAccount);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }

                    if (option == 7 || !AskForAnotherOperation()) break;
                }
            }
        }

        static Account AuthenticateUser(Bank bank)
        {
            while (true)
            {
                Console.WriteLine("----------------------------------------------------");
                Console.Write("Please enter your account number: ");
                string accountNumber = Console.ReadLine();
                Console.Write("Please enter your PIN: ");
                string pin = Console.ReadLine();

                Account account = bank.Authenticate(accountNumber, pin);
                if (account != null)
                {
                    Console.WriteLine("Authentication successful. Welcome, user with account " + accountNumber + "!");
                    return account;
                }
                else
                {
                    Console.WriteLine("Invalid account number or PIN. Please try again.");
                }
            }
        }

        static void DisplayMenu()
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
        }

        static int GetMenuOption()
        {
            Console.Write("What action do you want to perform? ");
            if (int.TryParse(Console.ReadLine(), out int option) && option >= 1 && option <= 7)
            {
                return option;
            }
            Console.WriteLine("Choose an option between 1 and 7");
            return -1;
        }

        static void HandleMenuOption(int option, Account authenticatedAccount)
        {
            switch (option)
            {
                case 1:
                    PerformDeposit(authenticatedAccount);
                    break;

                case 2:
                    PerformWithdrawal(authenticatedAccount);
                    break;

                case 3:
                    ListAllMovements(authenticatedAccount);
                    break;

                case 4:
                    ListIncomes(authenticatedAccount);
                    break;

                case 5:
                    ListOutcomes(authenticatedAccount);
                    break;

                case 6:
                    ShowCurrentBalance(authenticatedAccount);
                    break;

                case 7:
                    ExitOrChangeAccount(ref authenticatedAccount);
                    break;
            }
        }

        static void PerformDeposit(Account account)
        {
            Console.Write("Money deposit - Please enter an amount: ");
            decimal depositAmount = decimal.Parse(Console.ReadLine());
            account.Deposit(depositAmount);
            Console.WriteLine("The current balance is: " + account.Balance);
        }

        static void PerformWithdrawal(Account account)
        {
            Console.Write("Money withdrawal - Please enter an amount to withdraw: ");
            decimal withdrawAmount = decimal.Parse(Console.ReadLine());
            account.Withdraw(withdrawAmount);
            Console.WriteLine("The withdrawal has been completed successfully. The current balance is: " + account.Balance);
        }

        static void ListAllMovements(Account account)
        {
            Console.WriteLine("List of all movements for user with account " + account.AccountNumber + ":");
            ListMovements(account.GetMovements());
        }

        static void ListIncomes(Account account)
        {
            Console.WriteLine("List of incomes for user with account " + account.AccountNumber + ":");
            ListMovements(account.GetIncomes());
        }

        static void ListOutcomes(Account account)
        {
            Console.WriteLine("List of outcomes for user with account " + account.AccountNumber + ":");
            ListMovements(account.GetOutcomes());
        }

        static void ListMovements(List<string> movements)
        {
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
        }

        static void ShowCurrentBalance(Account account)
        {
            Console.WriteLine("The current balance for user with account " + account.AccountNumber + " is: " + account.Balance);
        }

        static void ExitOrChangeAccount(ref Account authenticatedAccount)
        {
            Console.WriteLine("Do you want to change your account? (Y/N)");
            string changeAccount = Console.ReadLine();

            if (changeAccount.Equals("Y", StringComparison.OrdinalIgnoreCase) || changeAccount.Equals("Yes", StringComparison.OrdinalIgnoreCase))
            {
                authenticatedAccount = null;
            }
            else
            {
                Console.WriteLine("The current balance is: " + authenticatedAccount.Balance);
                Console.WriteLine("Exiting the program...");
                Environment.Exit(0);
            }
        }

        static bool AskForAnotherOperation()
        {
            Console.WriteLine("Would you like to perform another operation? (Y/N)");
            string anotherOperation = Console.ReadLine();

            return anotherOperation.Equals("Y", StringComparison.OrdinalIgnoreCase) || anotherOperation.Equals("Yes", StringComparison.OrdinalIgnoreCase);
        }
    }
}
