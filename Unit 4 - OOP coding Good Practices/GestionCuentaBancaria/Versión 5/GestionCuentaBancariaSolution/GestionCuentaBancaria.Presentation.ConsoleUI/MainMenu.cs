using GestionCuentaBancaria.Business.Contracts;
using GestionCuentaBancaria.Business.Contracts.DTOs;
using GestionCuentaBancaria.Business.Impl;

namespace GestionCuentaBancaria.Presentation.ConsoleUI
{
    public class MainMenu
    {
        private readonly IAccountService _accountService;

        public MainMenu()
        {
            _accountService = new AccountService();
        }

        public void Run()
        {
            AccountDto authenticatedAccount = null;

            while (true)
            {
                authenticatedAccount = AuthenticateUser();

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

        private AccountDto AuthenticateUser()
        {
            while (true)
            {
                Console.Write("Please enter your account number: ");
                string accountNumber = Console.ReadLine();
                Console.Write("Please enter your PIN: ");
                string pin = Console.ReadLine();

                var account = _accountService.Authenticate(accountNumber, pin);
                if (account != null)
                {
                    Console.WriteLine("Authentication successful. Welcome!");
                    return account;
                }
                else
                {
                    Console.WriteLine("Invalid account number or PIN. Please try again.");
                }
            }
        }

        private void DisplayMenu()
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("1. Money income");
            Console.WriteLine("2. Money outcome");
            Console.WriteLine("3. List All Movements");
            Console.WriteLine("4. List Incomes");
            Console.WriteLine("5. List Outcomes");
            Console.WriteLine("6. Show Balance");
            Console.WriteLine("7. Exit");
            Console.WriteLine("-----------------------------------");
        }

        private int GetMenuOption()
        {
            Console.Write("Choose an option: ");
            if (int.TryParse(Console.ReadLine(), out int option) && option >= 1 && option <= 7)
            {
                return option;
            }
            Console.WriteLine("Please choose a valid option between 1 and 7.");
            return -1;
        }

        private void HandleMenuOption(int option, AccountDto account)
        {
            switch (option)
            {
                case 1:
                    PerformDeposit(account);
                    break;
                case 2:
                    PerformWithdrawal(account);
                    break;
                case 3:
                    ListAllMovements(account);
                    break;
                case 4:
                    ListIncomes(account);
                    break;
                case 5:
                    ListOutcomes(account);
                    break;
                case 6:
                    ShowBalance(account);
                    break;
                case 7:
                    ShowBalance(account);
                    Console.WriteLine("Exiting...");
                    Environment.Exit(0);
                    break;
            }
        }

        private void PerformDeposit(AccountDto account)
        {
            Console.Write("Money deposit - Please enter an amount: ");
            decimal amount = decimal.Parse(Console.ReadLine());
            _accountService.Deposit(account, amount);
            Console.WriteLine("The current balance is: " + account.Balance);
        }

        private void PerformWithdrawal(AccountDto account)
        {
            Console.Write("Money withdrawal - Please enter an amount to withdraw: ");
            decimal amount = decimal.Parse(Console.ReadLine());
            _accountService.Withdraw(account, amount);
            Console.WriteLine("The withdrawal has been completed successfully. The current balance is: " + account.Balance);
        }

        private void ListAllMovements(AccountDto account)
        {
            var movements = _accountService.GetMovements(account);
            Console.WriteLine("Movements: ");
            movements.ForEach(m => Console.WriteLine(m));
        }

        private void ListIncomes(AccountDto account)
        {
            var incomes = _accountService.GetIncomes(account);
            Console.WriteLine("Incomes: ");
            incomes.ForEach(i => Console.WriteLine(i));
        }

        private void ListOutcomes(AccountDto account)
        {
            var outcomes = _accountService.GetOutcomes(account);
            Console.WriteLine("Outcomes: ");
            outcomes.ForEach(o => Console.WriteLine(o));
        }

        private void ShowBalance(AccountDto account)
        {
            Console.WriteLine("Current balance: " + account.Balance);
        }

        private bool AskForAnotherOperation()
        {
            Console.Write("Would you like another operation? (Y/N): ");
            return Console.ReadLine().Trim().ToUpper() == "Y";
        }
    }
}