using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCuentaBancariaConsole.Class
{
    internal class Bank
    {
        private List<Account> accounts;

        public Bank()
        {
            accounts = new List<Account>
            {
                new Account("123456789", "1234", 1000),
                new Account("987654321", "4321", 500),
                new Account("111111111", "1111", 300)
            };
        }

        public Account Authenticate(string accountNumber, string pin)
        {
            foreach (var account in accounts)
            {
                if (account.AccountNumber == accountNumber && account.Authenticate(pin))
                {
                    return account;
                }
            }
            return null;
        }
    }
}
