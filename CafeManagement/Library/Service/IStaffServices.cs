using Library.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Service
{
    public interface IStaffServices
    {
        public List<staff> GetStaffs();
        public staff GetStaffsByUserName(string username);
        public staff GetstaffById(int staffid);
        public staff Createstaff(staff account);
        public staff Updatestaff(staff account);
        public bool Deletestaff(int staffid);
    }
}
