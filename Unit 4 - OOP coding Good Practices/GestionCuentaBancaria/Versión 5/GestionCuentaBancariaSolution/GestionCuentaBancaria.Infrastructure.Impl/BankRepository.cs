using GestionCuentaBancaria.Domain.Models;
using GestionCuentaBancaria.Infrastructure.Contracts;
using GestionCuentaBancaria.Infrastructure.Contracts.Entities;

namespace GestionCuentaBancaria.Infrastructure.Impl
{
    public class BankRepository : IBankRepository
    {
        private readonly BankEntity _bankEntity;

        public BankRepository()
        {
            _bankEntity = new BankEntity();
        }

        public AccountModel GetAccountByNumber(string accountNumber)
        {
            var accountEntity = _bankEntity.GetAccountByNumber(accountNumber);
            if (accountEntity == null) return null;

            return new AccountModel(
                accountEntity.AccountNumber,
                accountEntity.Pin,
                accountEntity.Balance
            );
        }

        public void UpdateAccountBalance(AccountModel account)
        {
            var accountEntity = _bankEntity.GetAccountByNumber(account.AccountNumber);
            if (accountEntity != null)
            {
                accountEntity.Balance = account.Balance;
                accountEntity.Movements = account.GetMovements();
                accountEntity.Incomes = account.GetIncomes();
                accountEntity.Outcomes = account.GetOutcomes();
            }
        }
    }
}

