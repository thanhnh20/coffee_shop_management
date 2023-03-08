using CafeManagement.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagement.Infrastructure.Repositories
{
    public interface IAccountRepository
    {
        public IEnumerable<Account> GetAccounts();
        public Account GetAccountByName(string name);
        public Account GetAccountByNameAndPass(string name, string pwd);
        public Account GetAccountByStaff(int staffid);
        public Account CreateAccount(Account account);
        public Account UpdateAccount(Account account);
        public bool DeleteAccount(Account account);
    }
}
