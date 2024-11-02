namespace GestionCuentaBancaria.Domain.Models
{
    public class AccountModel
    {
        public string AccountNumber { get; private set; }
        public string Pin { get; private set; }
        public decimal Balance { get; private set; }
        private List<string> movements;
        private List<string> incomes;
        private List<string> outcomes;

        public AccountModel(string accountNumber, string pin, decimal initialBalance)
        {
            AccountNumber = accountNumber;
            Pin = pin;
            Balance = initialBalance;
            movements = new List<string>();
            incomes = new List<string>();
            outcomes = new List<string>();
        }

        public bool Authenticate(string pin) => Pin == pin;

        public void Deposit(decimal amount)
        {
            if (amount <= 0) throw new ArgumentException("Amount must be positive.");
            Balance += amount;
            movements.Add($"Income: {amount}");
            incomes.Add($"Income: {amount}");
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= 0) throw new ArgumentException("Amount must be positive.");
            if (amount > Balance) throw new ArgumentException("Insufficient funds.");
            Balance -= amount;
            movements.Add($"Outcome: {amount}");
            outcomes.Add($"Outcome: {amount}");
        }

        public List<string> GetMovements() => movements;
        public List<string> GetIncomes() => incomes;
        public List<string> GetOutcomes() => outcomes;
    }
}
