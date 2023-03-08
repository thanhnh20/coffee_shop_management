using CafeManagement.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagement.Infrastructure.DAO
{
    public class AccountDAO
    {
        CoffeeShopManagementContext _context = new();
        private static AccountDAO instance = null;
        private static readonly object instanceLock = new object();
        private AccountDAO() { }
        public static AccountDAO getInstance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new AccountDAO();
                    }
                    return instance;
                }
            }
        }
        //public List<Account> GetAllAccounts() => _context.Accounts.ToList();
        public IEnumerable<Account> GetAllAccounts() => _context.Accounts.AsEnumerable();
        public Account GetAccbyName(string name) => _context.Accounts.FirstOrDefault(acc => acc.Username == name);
        public Account GetAccbyStaff(int staffid) => _context.Accounts.FirstOrDefault(acc => acc.staff.StaffId == staffid);
        public Account GetAccByNameAndPass(string name, string pwd) => _context.Accounts.FirstOrDefault(acc => acc.Username == name && acc.Password == pwd);
        public Account CreateAccount(Account account)
        {
            try
            {
                _context.Accounts.Add(account);
                _context.SaveChanges();
                account = GetAccByNameAndPass(account.Username,account.Password);
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
                var user = GetAccByNameAndPass(account.Username,account.Password);
                if (user != null)
                {
                    _context.Accounts.Remove(user);
                    _context.SaveChanges();
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
                var user = GetAccByNameAndPass(account.Username, account.Password);
                if (user != null)
                {
                    var tracker = _context.Attach(user);
                    tracker.State = EntityState.Modified;
                    _context.SaveChanges();
                    user = GetAccByNameAndPass(account.Username, account.Password);
                    return user;
                }
                return null;
            }
            catch { throw; }
        }
    }
}
