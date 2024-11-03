using GestionCuentaBancaria.Business.Contracts;
using GestionCuentaBancaria.Business.Contracts.DTOs;
using GestionCuentaBancaria.Infrastructure.Contracts;
using GestionCuentaBancaria.Infrastructure.Impl;

namespace GestionCuentaBancaria.Business.Impl
{
    public class AccountService : IAccountService
    {
        private readonly IBankRepository _bankRepository;

        public AccountService()
        {
            _bankRepository = new BankRepository();
        }

        public AccountDto Authenticate(string accountNumber, string pin)
        {
            var account = _bankRepository.GetAccountByNumber(accountNumber);
            if (account != null && account.Authenticate(pin))
            {
                return new AccountDto { AccountNumber = account.AccountNumber, Balance = account.Balance };
            }
            return null;
        }

        public void Deposit(AccountDto account, decimal amount)
        {
            var acc = _bankRepository.GetAccountByNumber(account.AccountNumber);
            acc.Deposit(amount);
            account.Balance = acc.Balance;
            _bankRepository.UpdateAccountBalance(acc);
        }

        public void Withdraw(AccountDto account, decimal amount)
        {
            var acc = _bankRepository.GetAccountByNumber(account.AccountNumber);
            acc.Withdraw(amount);
            account.Balance = acc.Balance;
            _bankRepository.UpdateAccountBalance(acc);
        }

        public List<string> GetMovements(AccountDto account)
        {
            var acc = _bankRepository.GetAccountByNumber(account.AccountNumber);
            return acc.GetMovements();
        }

        public List<string> GetIncomes(AccountDto account)
        {
            var acc = _bankRepository.GetAccountByNumber(account.AccountNumber);
            return acc.GetIncomes();
        }

        public List<string> GetOutcomes(AccountDto account)
        {
            var acc = _bankRepository.GetAccountByNumber(account.AccountNumber);
            return acc.GetOutcomes();
        }
    }
}
