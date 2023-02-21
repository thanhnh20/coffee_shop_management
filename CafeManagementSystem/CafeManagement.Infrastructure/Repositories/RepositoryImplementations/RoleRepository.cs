using CafeManagement.Infrastructure.DAO;
using CafeManagement.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagement.Infrastructure.Repositories.RepositoryImplementations
{
    public class RoleRepository : IRoleRepository
    {
        public bool CreateRole(Role role)
        {
            return RoleDAO.getInstance.CreateRole(role);
        }

        public bool DeleteRole(Role role)
        {
            return RoleDAO.getInstance.DeleteRole(role);
        }

        public Role GetRoleById(int roleId)
        {
            return RoleDAO.getInstance.GetRoleById(roleId);
        }

        public IEnumerable<Role> GetRoles()
        {
            return RoleDAO.getInstance.GetAllRoles();
        }

        public IEnumerable<Role> GetRolesByName(string name)
        {
            return RoleDAO.getInstance.GetRoleByName(name);
        }

        public bool UpdateRole(Role role)
        {
            return RoleDAO.getInstance.UpdateRole(role);
        }
    }
}
