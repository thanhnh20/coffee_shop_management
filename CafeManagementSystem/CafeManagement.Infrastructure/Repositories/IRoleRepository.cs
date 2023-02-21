using CafeManagement.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagement.Infrastructure.Repositories
{
    public interface IRoleRepository
    {
        public IEnumerable<Role> GetRoles();

        public IEnumerable<Role> GetRolesByName(string name);
        public Role GetRoleById(int roleId);
        public bool CreateRole(Role role);
        public bool UpdateRole(Role role);
        public bool DeleteRole(Role role);
    }

}
