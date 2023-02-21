using CafeManagement.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagement.Infrastructure.DAO
{
    public class RoleDAO
    {
        CoffeeShopManagementContext _context = new();
        private static RoleDAO instance = null;
        private static readonly object instanceLock = new object();
        private RoleDAO() { }
        public static RoleDAO getInstance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new RoleDAO();
                    }
                    return instance;
                }
            }
        }
        public IEnumerable<Role> GetAllRoles() => _context.Roles.AsEnumerable();
        public Role GetRoleById(int id) => _context.Roles.SingleOrDefault(rol => rol.RoleId == id);
        public IEnumerable<Role> GetRoleByName(string name) => _context.Roles.Where(rol=> rol.Name.Contains(name)).AsEnumerable();
        public bool CreateRole(Role role)
        {
            try
            {
                if (GetRoleById(role.RoleId) != null) return false;
                _context.Roles.Add(role);
                _context.SaveChanges();
                if (GetRoleById(role.RoleId) != null) return true;
                return false;
            }
            catch
            {
                throw;
            }
        }
        public bool DeleteRole(Role role)
        {
            try
            {
                var rol = GetRoleById(role.RoleId);
                if (rol != null)
                {
                    _context.Roles.Remove(role);
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
        public bool UpdateRole(Role role)
        {
            try
            {
                var rol = GetRoleById(role.RoleId);
                if(rol != null)
                {
                    var tracker = _context.Attach(rol);
                    tracker.State = EntityState.Modified;
                    _context.SaveChanges();
                    return true;
                }
                return false;
            }
            catch { throw; }
        }
    }
}
