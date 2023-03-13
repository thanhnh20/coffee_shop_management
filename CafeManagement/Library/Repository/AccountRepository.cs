using Library.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Repository
{
    public interface AccountRepository
    {
        public Account checkLogin(string username, string password);
    }
}
