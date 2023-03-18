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
        CoffeeShopManagementContext db = new CoffeeShopManagementContext();

        private static StaffDAO instance = null;
        private static readonly object instancelock = new object();
        private StaffDAO() { }
        public static StaffDAO Instance
        {
            get
            {
                lock (instancelock)
                {
                    if (instance == null)
                    {
                        instance = new StaffDAO();
                    }
                    return instance;
                }
            }
        }
        public List<staff> GetAllStaffs() => db.staff.Include(sta => sta.UsernameNavigation).ToList();
        public List<staff> GetAllStaffsByName(string name) => db.staff.Include(sta => sta.UsernameNavigation).Where(sta => sta.Fullname.Contains(name)).ToList();
        public staff GetStaffbyName(string name) => db.staff.Include(sta => sta.UsernameNavigation).FirstOrDefault(acc => acc.Username.Equals(name));
        public staff GetStaffbyId(int staffid) => db.staff.Include(sta => sta.UsernameNavigation).FirstOrDefault(acc => acc.StaffId.Equals(staffid));
        public staff CreateStaff(staff sta)
        {
            try
            {
                db.staff.Add(sta);
                db.SaveChanges();
                sta = GetStaffbyId(sta.StaffId);
                return sta;
            }
            catch
            {
                throw;
            }
        }
        public bool DeleteStaff(int staid)
        {
            try
            {
                var user = GetStaffbyId(staid);
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

        public staff getStaffByUserName(string username)
        {
            using (var db = new CoffeeShopManagementContext())
            {
                return db.staff.Where(s => s.Username.Equals(username)).FirstOrDefault();
            }
        }
    }
}