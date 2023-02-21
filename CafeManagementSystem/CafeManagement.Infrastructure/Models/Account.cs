using System;
using System.Collections.Generic;

namespace CafeManagement.Infrastructure.Models
{
    public partial class Account
    {
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
        public int RoleId { get; set; }
        public int Status { get; set; }

        public virtual Role Role { get; set; } = null!;
        public virtual staff? staff { get; set; }
    }
}
