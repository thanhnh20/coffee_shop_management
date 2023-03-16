using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Model;
using Microsoft.EntityFrameworkCore;

namespace Library.DataAccess
{
    public class AccountDAO
    {
        CoffeeShopManagementContext db = new CoffeeShopManagementContext();

        private static AccountDAO instance = null;
        private static readonly object instancelock = new object();
        private AccountDAO() { }
        public static AccountDAO Instance
        {
            get
            {
                lock (instancelock)
                {
                    if (instance == null)
                    {
                        instance = new AccountDAO();
                    }
                    return instance;
                }
            }
        }

        public Account checkLogin(string username, string password)
            => db.Accounts.Where(m => m.Username.Equals(username) && m.Password.Equals(password)).FirstOrDefault();
        public List<Account> GetAllAccounts() => db.Accounts.Include(sta => sta.staff).ToList();
        public Account GetAccbyName(string name) => db.Accounts.Include(sta => sta.staff).FirstOrDefault(acc => acc.Username.Equals(name));
        public Account GetAccbyStaff(int staffid) => db.Accounts.Include(sta => sta.staff).FirstOrDefault(acc => acc.staff.StaffId.Equals(staffid));
        public Account CreateAccount(Account account)
        {
            try
            {
                db.Accounts.Add(account);
                db.SaveChanges();
                account = GetAccbyName(account.Username);
                return account;
            }
            catch
            {
                throw;
            }
        }
        public bool DeleteAccount(Account account)
        {
            try
            {
                var user = GetAccbyName(account.Username);
                if (user != null)
                {
                    db.Accounts.Remove(user);
                    db.SaveChanges();
                    return true;
                }
                return false;
            }
            catch
            {
                throw;
            }
        }
        public Account UpdateAccount(Account account)
        {
            try
            {
                var user = GetAccbyName(account.Username);
                if (user != null)
                {
                    user.Password = account.Password;
                    user.RoleId = account.RoleId;
                    user.Status = account.Status;
                    db.Accounts.Update(user);
                    db.SaveChanges();
                    user = GetAccbyName(account.Username);
                    return user;
                }
                return null;
            }
            catch { throw; }
        }
    }
}
