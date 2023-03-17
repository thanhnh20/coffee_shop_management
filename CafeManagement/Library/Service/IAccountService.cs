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
<<<<<<< HEAD
=======
        public List<Account> GetStaffAccounts();
        public List<Account> GetAccountsByName(string name);
>>>>>>> 796617b80527656193a787505ec464c5228c8b8b
        public Account GetAccountByName(string name);
        public Account GetAccountByStaff(int staffid);
        public Account CreateAccount(Account account);
        public Account UpdateAccount(Account account);
<<<<<<< HEAD
        public bool DeleteAccount(Account account);
=======
        public bool DeleteAccount(string username);
>>>>>>> 796617b80527656193a787505ec464c5228c8b8b
    }
}
