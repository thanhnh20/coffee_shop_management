using System;
using System.Collections.Generic;

namespace CafeManagement.Infrastructure.Models
{
    public partial class staff
    {
        public staff()
        {
            Orders = new HashSet<Order>();
        }

        public int StaffId { get; set; }
        public string Fullname { get; set; } = null!;
        public DateTime DateJoin { get; set; }
        public string? Address { get; set; }
        public string? PhoneNumber { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? TaxCode { get; set; }
        public double? Salary { get; set; }
        public string? Username { get; set; }

        public virtual Account? UsernameNavigation { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
