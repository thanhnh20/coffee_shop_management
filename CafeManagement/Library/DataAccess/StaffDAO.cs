using Library.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataAccess
{
    public class StaffDAO
    {
        CoffeeShopManagementContext db = new();
        private static StaffDAO instance = null;
        private static readonly object instanceLock = new object();
        private StaffDAO() { }
        public static StaffDAO getInstance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new StaffDAO();
                    }
                    return instance;
                }
            }
        }
        //public List<Staff> GetAllStaffs() => db.Staffs.ToList();
        public List<staff> GetAllStaffs() => db.staff.ToList();
        public staff GetStaffbyUserName(string username) => db.staff.FirstOrDefault(acc => acc.Username == username);
        public staff GetStaffbyId(int staffid) => db.staff.FirstOrDefault(acc => acc.StaffId == staffid);
        public staff CreateStaff(staff staff)
        {
            try
            {
                db.staff.Add(staff);
                db.SaveChanges();
                staff = GetStaffbyId(staff.StaffId);
                return staff;
            }
            catch
            {
                throw;
            }
        }
        public bool DeleteStaff(int staffid)
        {
            try
            {
                var user = GetStaffbyId(staffid);
                if (user != null)
                {
                    db.staff.Remove(user);
                    db.SaveChanges();
                    return true;
                }
                return false;
            }
            catch
            {
                throw;
            }
        }

        #region old update codes
        /*var tracker = db.Attach(user);
         * tracker.State = EntityState.Modified;
                    tracker.Property("Fullname").IsModified = true;
                    tracker.Property("Username").IsModified = true;
                    tracker.Property("DateJoin").IsModified = true;
                    tracker.Property("Address").IsModified = true;
                    tracker.Property("PhoneNumber").IsModified = true;
                    tracker.Property("DateOfBirth").IsModified = true;
                    tracker.Property("TaxCode").IsModified = true;
                    tracker.Property("Salary").IsModified = true;
        var tracker = db.Attach(user);
                    tracker.Property("Password").IsModified = true;
                    tracker.Property("RoleId").IsModified = true;
                    tracker.Property("Status").IsModified = true;
        */
        #endregion
        public staff UpdateStaff(staff staff)
        {
            try
            {
                var user = GetStaffbyId(staff.StaffId);
                if (user != null)
                {
                    user.Fullname = staff.Fullname;
                    user.Address = staff.Address;
                    user.DateJoin = staff.DateJoin;
                    user.DateOfBirth = staff.DateOfBirth;
                    user.PhoneNumber = staff.PhoneNumber;
                    user.TaxCode = staff.TaxCode;
                    user.Salary = staff.Salary;
                    db.staff.Update(user);
                    db.SaveChanges();
                    user = GetStaffbyId(staff.StaffId);
                    return user;
                }
                return null;
            }
            catch { throw; }
        }
    }
}
