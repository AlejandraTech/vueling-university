using GestionCuentaBancaria.Domain.Models;

namespace GestionCuentaBancaria.Infrastructure.Contracts
{
    public interface IBankRepository
    {
        AccountModel GetAccountByNumber(string accountNumber);
        void UpdateAccountBalance(AccountModel acc);
    }
}
