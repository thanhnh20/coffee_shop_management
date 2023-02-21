using CafeManagement.Infrastructure.DAO;
using CafeManagement.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagement.Infrastructure.Repositories.RepositoryImplementations
{
    public class AccountRepository : IAccountRepository
    {

        public bool CreateAccount(Account account)
        {
            return AccountDAO.getInstance.CreateAccount(account);
        }

        public bool DeleteAccount(Account account)
        {
            return AccountDAO.getInstance.DeleteAccount(account);
        }

        public Account GetAccountByName(string name)
        {
            return AccountDAO.getInstance.GetAccbyName(name);
        }

        public Account GetAccountByNameAndPass(string name, string pwd)
        {
            return AccountDAO.getInstance.GetAccByNameAndPass(name, pwd);
        }

        public Account GetAccountByStaff(int staffid)
        {
            return AccountDAO.getInstance.GetAccbyStaff(staffid);
        }

        public IEnumerable<Account> GetAccounts()
        {
            return AccountDAO.getInstance.GetAllAccounts();
        }

        public bool UpdateAccount(Account account)
        {
            return AccountDAO.getInstance.UpdateAccount(account);
        }
    }
}
