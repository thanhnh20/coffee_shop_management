using Library.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Service
{
    public interface IAccountService
    {
        public Account checkLogin(string username, string password);
        public List<Account> GetAccounts();
        public List<Account> GetStaffAccounts();
        public List<Account> GetAccountsByName(string name);
        public Account GetAccountByName(string name);
        public Account GetAccountByStaff(int staffid);
        public Account CreateAccount(Account account);
        public Account UpdateAccount(Account account);
        public bool DeleteAccount(string username);
    }
}
