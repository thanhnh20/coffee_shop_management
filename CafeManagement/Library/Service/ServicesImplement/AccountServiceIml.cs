using Library.DataAccess;
using Library.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Service.ServiceImplement
{
    public class AccountServiceIml : IAccountService
    {
        public Account checkLogin(string username, string password) => AccountDAO.Instance.checkLogin(username, password);

        public Account CreateAccount(Account account) => AccountDAO.Instance.createAccount(account);

        public bool DeleteAccount(string username) => AccountDAO.Instance.deleteAccount(username);

        public Account GetAccountByName(string name) => AccountDAO.Instance.getAccbyName(name);

        public Account GetAccountByStaff(int staffid) => AccountDAO.Instance.getAccbyStaff(staffid);

        public List<Account> GetAccounts() => AccountDAO.Instance.getAllAccounts();

        public List<Account> GetAccountsByName(string name) => AccountDAO.Instance.getAllAccountsByName(name);

        public List<Account> GetStaffAccounts() => AccountDAO.Instance.getAllStaffAccounts();

        public Account UpdateAccount(Account account) => AccountDAO.Instance.updateAccount(account);
    }
}
