using CafeManagement.Services.API.VModels;

namespace CafeManagement.Services.API.Services
{
    public interface IRoleServices
    {
        public IEnumerable<RoleVM> GetRoles();
        public IEnumerable<RoleVM> GetRolesByName(string name);
        public RoleVM GetRoleById(int id);
        public RoleVM CreateRole(RoleM Role);
        public RoleVM UpdateRole(RoleVM Role, int id);
        public bool DeleteRole(int id);
    }
}
