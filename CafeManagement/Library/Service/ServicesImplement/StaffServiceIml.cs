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
            return StaffDAO.Instance.CreateStaff(account);
        }

        public bool Deletestaff(int staffid)
        {
            return StaffDAO.Instance.DeleteStaff(staffid);
        }

        public staff GetstaffById(int staffid)
        {
            return StaffDAO.Instance.GetStaffbyId(staffid);
        }

        public List<staff> GetStaffs()
        {
            return StaffDAO.Instance.GetAllStaffs();
        }

        public staff GetStaffsByUserName(string username)
        {
            return StaffDAO.Instance.GetStaffbyName(username);
        }

        public staff Updatestaff(staff account)
        {
            return StaffDAO.Instance.UpdateStaff(account);
        }

        public staff getStaffByUserName(string username) => StaffDAO.Instance.GetStaffbyName(username);
    }
}