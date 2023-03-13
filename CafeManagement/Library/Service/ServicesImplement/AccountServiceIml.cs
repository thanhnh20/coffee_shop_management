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
    }
}
