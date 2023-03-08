using CafeManagement.Infrastructure.Models;
using CafeManagement.Infrastructure.Repositories;
using CafeManagement.Services.API.VModels;
using System.Security.Principal;

namespace CafeManagement.Services.API.Services.ServiceImplementations
{
    public class RoleServices : IRoleServices
    {
        private readonly IRoleRepository rolrep;
        public RoleServices(IRoleRepository roleRepository)
        {
            rolrep = roleRepository;
        }
        public RoleVM CreateRole(RoleM Role)
        {
            var rol = GetRoleById(Role.RoleId);
            if (rol == null)
            {
                Role rolobj = new()
                {
                    RoleId = Role.RoleId,
                    Name= Role.Name,
                };
                rolobj = rolrep.CreateRole(rolobj);
                return new RoleVM()
                {
                    RoleId = Role.RoleId,
                    Name = Role.Name,
                };
            }
            return rol;
        }

        public bool DeleteRole(int id)
        {
            var rol = rolrep.GetRoleById(id);
            if (rol == null)
            {
                return false;
            }
            return rolrep.DeleteRole(rol);
        }

        public RoleVM GetRoleById(int id)
        {
            var data = rolrep.GetRoleById(id);
            if (data != null)
            {
                RoleVM accobj = new()
                {
                    RoleId = data.RoleId,
                    Name = data.Name,
                };
                return accobj;
            }
            return null;
        }

        public IEnumerable<RoleVM> GetRoles()
        {
            List<RoleVM> enumRoleVM = new();
            IEnumerable<Role> lisrol = rolrep.GetRoles();
            foreach (Role rol in lisrol)
            {
                RoleVM rolvm = new()
                {
                    RoleId = rol.RoleId,
                    Name = rol.Name
                };
                enumRoleVM.Add(rolvm);
            }
            return enumRoleVM.AsEnumerable();
        }

        public IEnumerable<RoleVM> GetRolesByName(string name)
        {
            List<RoleVM> enumRoleVM = new();
            IEnumerable<Role> lisrol = rolrep.GetRoles().Where(rolname => rolname.Name.Contains(name)).AsEnumerable();
            foreach (Role rol in lisrol)
            {
                RoleVM rolvm = new()
                {
                    RoleId = rol.RoleId,
                    Name = rol.Name
                };
                enumRoleVM.Add(rolvm);
            }
            return enumRoleVM;
        }

        public RoleVM UpdateRole(RoleVM Role, int id)
        {
            var rol = rolrep.GetRoleById(id);
            if (rol == null)
            {
                return null;
            }
            rol.Name = Role.Name;
            rol = rolrep.UpdateRole(rol);
            return new RoleVM()
            {
                RoleId = rol.RoleId,
                Name = rol.Name
            };
        }
    }
}
