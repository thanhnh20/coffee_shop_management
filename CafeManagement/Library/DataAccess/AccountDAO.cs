using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Model;
using Microsoft.EntityFrameworkCore;
<<<<<<< HEAD
=======
using Microsoft.EntityFrameworkCore.ChangeTracking;
>>>>>>> 796617b80527656193a787505ec464c5228c8b8b

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
<<<<<<< HEAD
        public List<Account> GetAllAccounts() => db.Accounts.Include(sta => sta.staff).ToList();
        public Account GetAccbyName(string name) => db.Accounts.Include(sta => sta.staff).FirstOrDefault(acc => acc.Username.Equals(name));
        public Account GetAccbyStaff(int staffid) => db.Accounts.Include(sta => sta.staff).FirstOrDefault(acc => acc.staff.StaffId.Equals(staffid));
        public Account CreateAccount(Account account)
=======
        public Account createAccount(Account account)
>>>>>>> 796617b80527656193a787505ec464c5228c8b8b
        {
            try
            {
                db.Accounts.Add(account);
                db.SaveChanges();
<<<<<<< HEAD
                account = GetAccbyName(account.Username);
=======
                account = getAccbyName(account.Username);
>>>>>>> 796617b80527656193a787505ec464c5228c8b8b
                return account;
            }
            catch
            {
                throw;
            }
        }
<<<<<<< HEAD
        public bool DeleteAccount(Account account)
        {
            try
            {
                var user = GetAccbyName(account.Username);
=======
        public bool deleteAccount(string username)
        {
            try
            {
                var user = getAccbyName(username);
>>>>>>> 796617b80527656193a787505ec464c5228c8b8b
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
<<<<<<< HEAD
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
=======
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
>>>>>>> 796617b80527656193a787505ec464c5228c8b8b
                    return user;
                }
                return null;
            }
            catch { throw; }
        }
    }
}
