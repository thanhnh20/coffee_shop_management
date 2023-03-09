using CafeManagement.Infrastructure.Models;
using CafeManagement.Infrastructure.Repositories;
using CafeManagement.Services.API.VModels;

namespace CafeManagement.Services.API.Services.ServiceImplementations
{
    public class AccountServices : IAccountServices
    {
        private readonly IAccountRepository accrep;
        public AccountServices(IAccountRepository accountRepository)
        {
            accrep = accountRepository;
        }

        public AccountVM CreateAccount(AccountM account)
        {
            var acc = GetAccountByName(account.Username);
            if (acc == null)
            {
                Account accobj = new()
                {
                    Username = account.Username,
                    Password = account.Password,
                    RoleId = account.RoleId,
                    Status = account.Status
                };
                accobj = accrep.CreateAccount(accobj);
                return new AccountVM()
                {
                    Username = accobj.Username,
                    Password = accobj.Password,
                    RoleId = accobj.RoleId,
                    Status = accobj.Status
                };
            }
            return acc;
        }

        public bool DeleteAccount(string username)
        {
            var usr = accrep.GetAccountByName(username);
            if (usr == null)
            {
                return false;
            }
            return accrep.DeleteAccount(usr);
        }

        public AccountVM GetAccountByName(string username)
        {
            var data = accrep.GetAccountByName(username);
            if (data != null)
            {
                AccountVM accobj = new()
                {
                    Username = data.Username,
                    Password = data.Password,
                    RoleId = data.RoleId,
                    Status = data.Status
                };
                return accobj;
            }
            return null;
        }

        public AccountVM GetAccountByNameAndPass(string name, string pwd)
        {
            var data = accrep.GetAccountByNameAndPass(name, pwd);
            if (data != null)
            {
                AccountVM accobj = new()
                {
                    Username = data.Username,
                    Password = data.Password,
                    RoleId = data.RoleId,
                    Status = data.Status
                };
                return accobj;
            }
            return null;
        }

        public AccountVM GetAccountByStaff(int staffid)
        {
            var data = accrep.GetAccountByStaff(staffid);
            if (data != null)
            {
                AccountVM accobj = new()
                {
                    Username = data.Username,
                    Password = data.Password,
                    RoleId = data.RoleId,
                    Status = data.Status
                };
                return accobj;
            }
            return null;
        }

        public IEnumerable<AccountVM> GetAccounts()
        {
            List<AccountVM> enumAccountVM = new();
            IEnumerable<Account> lisacc = accrep.GetAccounts();
            foreach (Account acc in lisacc)
            {
                AccountVM accvm = new()
                {
                    Username = acc.Username,
                    Password = acc.Password,
                    RoleId = acc.RoleId,
                    Status = acc.Status
                };
                enumAccountVM.Add(accvm);
            }
            return enumAccountVM.AsEnumerable();
        }
        public IEnumerable<AccountVM> GetAccountsByName(string name)
        {
            List<AccountVM> enumAccountVM = new();
            IEnumerable<Account> lisacc = accrep.GetAccounts().Where(accname => accname.Username.Contains(name)).AsEnumerable();
            foreach (Account acc in lisacc)
            {
                AccountVM accvm = new()
                {
                    Username = acc.Username,
                    Password = acc.Password,
                    RoleId = acc.RoleId,
                    Status = acc.Status
                };
                enumAccountVM.Add(accvm);
            }
            return enumAccountVM;
        }

        public AccountVM UpdateAccount(AccountVM account, string username)
        {
            var usr = accrep.GetAccountByNameAndPass(username, account.Password);
            if (usr == null)
            {
                return null;
            }
            usr.Password = account.Password;
            usr.RoleId = account.RoleId;
            usr.Status = account.Status;
            usr = accrep.UpdateAccount(usr);
            return new AccountVM()
            {
                Username = usr.Username,
                Password = usr.Password,
                RoleId = usr.RoleId,
                Status = usr.Status
            };
        }
    }
}
