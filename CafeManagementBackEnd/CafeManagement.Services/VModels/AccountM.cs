using CafeManagement.Infrastructure.Models;

namespace CafeManagement.Services.VModels
{
    public class AccountM
    {
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
        public int RoleId { get; set; }
        public int Status { get; set; }
    }
}
