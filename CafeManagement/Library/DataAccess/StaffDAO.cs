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
            }
            catch
            {
                throw;
            }
        }
        public bool DeleteStaff(staff sta)
        {
            try
            {
                var user = GetStaffbyStaff(sta.StaffId);
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
                    return user;
                }
                return null;
            }
            catch { throw; }
        }
    }
}
