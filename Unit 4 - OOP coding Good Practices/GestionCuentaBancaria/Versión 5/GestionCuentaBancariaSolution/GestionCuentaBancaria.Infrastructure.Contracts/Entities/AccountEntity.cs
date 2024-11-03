namespace GestionCuentaBancaria.Infrastructure.Contracts.Entities
{
    public class AccountEntity
    {
        public string AccountNumber { get; set; }
        public string Pin { get; set; }
        public decimal Balance { get; set; }
        public List<string> Movements { get; set; }
        public List<string> Incomes { get; set; }
        public List<string> Outcomes { get; set; }

        public AccountEntity(string accountNumber, string pin, decimal initialBalance)
        {
            AccountNumber = accountNumber;
            Pin = pin;
            Balance = initialBalance;
            Movements = new List<string>();
            Incomes = new List<string>();
            Outcomes = new List<string>();
        }

        public void Deposit(decimal amount)
        {
            if (amount <= 0) throw new ArgumentException("Amount must be positive.");
            Balance += amount;
            Movements.Add($"Income: {amount}");
            Incomes.Add($"Income: {amount}");
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= 0) throw new ArgumentException("Amount must be positive.");
            if (amount > Balance) throw new ArgumentException("Insufficient funds.");
            Balance -= amount;
            Movements.Add($"Outcome: {amount}");
            Outcomes.Add($"Outcome: {amount}");
        }

        public bool Authenticate(string pin)
        {
            return Pin == pin;
        }
    }
}