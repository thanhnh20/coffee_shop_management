using Library.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Service
{
    public interface IStaffService
    {
        public staff getStaffByUserName(string username);
    }
}
