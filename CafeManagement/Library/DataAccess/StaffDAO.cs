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
<<<<<<< HEAD
        CoffeeShopManagementContext db = new CoffeeShopManagementContext();

        private static StaffDAO instance = null;
        private static readonly object instancelock = new object();
        private StaffDAO() { }
        public static StaffDAO Instance
        {
            get
            {
                lock (instancelock)
=======
        CoffeeShopManagementContext db = new();
        private static StaffDAO instance = null;
        private static readonly object instanceLock = new object();
        private StaffDAO() { }
        public static StaffDAO getInstance
        {
            get
            {
                lock (instanceLock)
>>>>>>> 796617b80527656193a787505ec464c5228c8b8b
                {
                    if (instance == null)
                    {
                        instance = new StaffDAO();
                    }
                    return instance;
                }
            }
        }
<<<<<<< HEAD
        public List<staff> GetAllStaffs() => db.staff.Include(sta => sta.UsernameNavigation).ToList();
        public staff GetStaffbyName(string name) => db.staff.Include(sta => sta.UsernameNavigation).FirstOrDefault(acc => acc.Username.Equals(name));
        public staff GetStaffbyStaff(int staffid) => db.staff.Include(sta => sta.UsernameNavigation).FirstOrDefault(acc => acc.StaffId.Equals(staffid));
        public staff CreateStaff(staff sta)
        {
            try
            {
                db.staff.Add(sta);
                db.SaveChanges();
                sta = GetStaffbyStaff(sta.StaffId);
                return sta;
=======
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
>>>>>>> 796617b80527656193a787505ec464c5228c8b8b
            }
            catch
            {
                throw;
            }
        }
<<<<<<< HEAD
        public bool DeleteStaff(staff sta)
        {
            try
            {
                var user = GetStaffbyStaff(sta.StaffId);
=======
        public bool DeleteStaff(int staffid)
        {
            try
            {
                var user = GetStaffbyId(staffid);
>>>>>>> 796617b80527656193a787505ec464c5228c8b8b
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
<<<<<<< HEAD
        public staff UpdateStaff(staff sta)
        {
            try
            {
                var user = GetStaffbyStaff(sta.StaffId);
                if (user != null)
                {
                    user.PhoneNumber = sta.PhoneNumber;
                    user.Address = sta.Address;
                    user.DateJoin = sta.DateJoin;
                    user.DateOfBirth = sta.DateOfBirth;
                    user.Fullname = sta.Fullname;
                    user.TaxCode = sta.TaxCode;
                    user.Salary = sta.Salary;
                    user.Username = sta.Username;
                    db.staff.Update(user);
                    db.SaveChanges();
                    user = GetStaffbyStaff(sta.StaffId);
=======

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
>>>>>>> 796617b80527656193a787505ec464c5228c8b8b
                    return user;
                }
                return null;
            }
            catch { throw; }
        }
    }
}
