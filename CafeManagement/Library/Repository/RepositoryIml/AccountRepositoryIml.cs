using Library.DataAccess;
using Library.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Repository.RepositoryIml
{
    public class AccountRepositoryIml : AccountRepository
    {
        public Account checkLogin(string username, string password) => AccountDAO.Instance.checkLogin(username, password);
    }
}
