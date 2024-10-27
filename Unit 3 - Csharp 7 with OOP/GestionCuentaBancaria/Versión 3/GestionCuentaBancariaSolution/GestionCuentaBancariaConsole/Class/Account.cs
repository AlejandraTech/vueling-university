using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCuentaBancariaConsole.Class
{
    internal class Account
    {
        public string AccountNumber { get; private set; }
        public string Pin { get; private set; }
        public decimal Balance { get; private set; }
        private List<string> movements;
        private List<string> incomes;
        private List<string> outcomes;

        public Account(string accountNumber, string pin, decimal initialBalance)
        {
            AccountNumber = accountNumber;
            Pin = pin;
            Balance = initialBalance;
            movements = new List<string>();
            incomes = new List<string>();
            outcomes = new List<string>();
        }

        public bool Authenticate(string pin)
        {
            return Pin == pin;
        }

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("The amount must be a positive number.");
            }
            Balance += amount;
            movements.Add($"Income: {amount}");
            incomes.Add($"Income: {amount}");
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("The amount must be a positive number.");
            }
            if (amount > Balance)
            {
                throw new ArgumentException("Insuficient funds.");
            }
            Balance -= amount;
            movements.Add($"Outcome: {amount}");
            outcomes.Add($"Outcome: {amount}");
        }

        public List<string> GetMovements() => movements;
        public List<string> GetIncomes() => incomes;
        public List<string> GetOutcomes() => outcomes;
    }
}
