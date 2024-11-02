namespace GestionCuentaBancaria.Infrastructure.Contracts.Entities
{
    public class BankEntity
    {
        public List<AccountEntity> Accounts { get; private set; }

        public BankEntity()
        {
            Accounts = new List<AccountEntity>
            {
                new AccountEntity("123456789", "1234", 1000),
                new AccountEntity("987654321", "4321", 500),
                new AccountEntity("111111111", "1111", 300)
            };
        }

        public AccountEntity GetAccountByNumber(string accountNumber)
        {
            return Accounts.FirstOrDefault(a => a.AccountNumber == accountNumber);
        }
    }
}
