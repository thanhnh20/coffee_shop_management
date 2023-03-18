using Library.DataAccess;
using Library.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Service.ServicesImplement
{
    public class StaffServiceIml : IStaffService
    {
        public staff getStaffByUserName(string username) => StaffDAO.Instance.getStaffByUserName(username);
    }
}
