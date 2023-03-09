using CafeManagement.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagement.Infrastructure.DAO
{
    public class StaffDAO
    {
        CoffeeShopManagementContext _context = new();
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
        //public List<Staff> GetAllStaffs() => _context.Staffs.ToList();
        public IEnumerable<staff> GetAllStaffs() => _context.staff.AsEnumerable();
        public staff GetAccbyUserName(string username) => _context.staff.FirstOrDefault(acc => acc.Username == username);
        public staff GetAccbyStaffId(int staffid) => _context.staff.FirstOrDefault(acc => acc.StaffId == staffid);
        public staff CreateStaff(staff staff)
        {
            try
            {
                _context.staff.Add(staff);
                _context.SaveChanges();
                staff = GetAccbyStaffId(staff.StaffId);
                return staff;
            }
            catch
            {
                throw;
            }
        }
        public bool DeleteStaff(staff staff)
        {
            try
            {
                var user = GetAccbyStaffId(staff.StaffId);
                if (user != null)
                {
                    _context.staff.Remove(user);
                    _context.SaveChanges();
                    return true;
                }
                return false;
            }
            catch
            {
                throw;
            }
        }
        public staff UpdateStaff(staff staff)
        {
            try
            {
                var user = GetAccbyStaffId(staff.StaffId);
                if (user != null)
                {
                    var tracker = _context.Attach(user);
                    tracker.State = EntityState.Modified;
                    _context.SaveChanges();
                    user = GetAccbyStaffId(staff.StaffId);
                    return user;
                }
                return null;
            }
            catch { throw; }
        }
    }
}
