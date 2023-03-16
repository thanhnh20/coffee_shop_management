using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

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
        public List<Account> getAllAccounts() => db.Accounts.Include(sta => sta.staff).ToList();
        public List<Account> getAllStaffAccounts()
        {
            //Join(db.staff, acc => acc.staff.StaffId, sta => sta.StaffId, (acc, staf) => new { Account = acc, staff = staf }).Select(accsta => new(accsta, staff)
            return db.Accounts.Include(stafre =>
                stafre.staff).ToList();
        }

        public List<Account> getAllAccountsByName(string name) => db.Accounts.Where(acc => acc.Username.Contains(name)).Include(sta => sta.staff).ToList();
        public Account getAccbyName(string name) => db.Accounts.Include(sta => sta.staff).FirstOrDefault(acc => acc.Username.Equals(name));
        public Account getAccbyStaff(int staffid) => db.Accounts.Include(sta => sta.staff).FirstOrDefault(acc => acc.staff.StaffId.Equals(staffid));
        public Account checkLogin(string username, string password)
            => db.Accounts.Where(m => m.Username.Equals(username) && m.Password.Equals(password)).FirstOrDefault();
        public Account createAccount(Account account)
        {
            try
            {
                db.Accounts.Add(account);
                db.SaveChanges();
                account = getAccbyName(account.Username);
                return account;
            }
            catch
            {
                throw;
            }
        }
        public bool deleteAccount(string username)
        {
            try
            {
                var user = getAccbyName(username);
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
        public Account updateAccount(Account account)
        {
            try
            {
                var user = getAccbyName(account.Username);
                if (user != null)
                {
                    user.Password = account.Password;
                    user.Status = account.Status;
                    user.RoleId = account.RoleId;
                    db.Accounts.Update(user);
                    db.SaveChanges();
                    user = getAccbyName(account.Username);
                    return user;
                }
                return null;
            }
            catch { throw; }
        }
    }
}
