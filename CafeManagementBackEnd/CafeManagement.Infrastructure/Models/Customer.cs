using System;
using System.Collections.Generic;

namespace CafeManagement.Infrastructure.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Orders = new HashSet<Order>();
        }

        public string PhoneNumber { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? Email { get; set; }
        public string? Address { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
