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

        public Account CreateAccount(Account account) => AccountDAO.Instance.CreateAccount(account);

        public bool DeleteAccount(Account account) => AccountDAO.Instance.DeleteAccount(account);

        public Account GetAccountByName(string name) => AccountDAO.Instance.GetAccbyName(name);

        public Account GetAccountByStaff(int staffid) => AccountDAO.Instance.GetAccbyStaff(staffid);

        public List<Account> GetAccounts() => AccountDAO.Instance.GetAllAccounts();

        public Account UpdateAccount(Account account) => AccountDAO.Instance.UpdateAccount(account);
    }
}
