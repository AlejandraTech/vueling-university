using GestionCuentaBancaria.Business.Contracts.DTOs;

namespace GestionCuentaBancaria.Business.Contracts
{
    public interface IAccountService
    {
        AccountDto Authenticate(string accountNumber, string pin);
        void Deposit(AccountDto account, decimal amount);
        void Withdraw(AccountDto account, decimal amount);
        List<string> GetMovements(AccountDto account);
        List<string> GetIncomes(AccountDto account);
        List<string> GetOutcomes(AccountDto account);
    }
}
