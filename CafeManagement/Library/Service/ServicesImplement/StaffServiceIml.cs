using Library.DataAccess;
using Library.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Service.ServicesImplement
{
    public class StaffServiceIml : IStaffServices
    {
        public staff Createstaff(staff account)
        {
            return StaffDAO.getInstance.CreateStaff(account);
        }

        public bool Deletestaff(int staffid)
        {
            return StaffDAO.getInstance.DeleteStaff(staffid);
        }

        public staff GetstaffById(int staffid)
        {
            return StaffDAO.getInstance.GetStaffbyId(staffid);
        }

        public List<staff> GetStaffs()
        {
            return StaffDAO.getInstance.GetAllStaffs();
        }

        public staff GetStaffsByUserName(string username)
        {
            return StaffDAO.getInstance.GetStaffbyUserName(username);
        }

        public staff Updatestaff(staff account)
        {
            return StaffDAO.getInstance.UpdateStaff(account);
        }
    }
}
