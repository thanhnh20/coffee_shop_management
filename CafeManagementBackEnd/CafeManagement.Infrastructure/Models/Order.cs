using System;
using System.Collections.Generic;

namespace CafeManagement.Infrastructure.Models
{
    public partial class Order
    {
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int OrderId { get; set; }
        public DateTime CreateDate { get; set; }
        public int StaffId { get; set; }
        public string PhoneNumber { get; set; } = null!;
        public double? Amount { get; set; }
        public int PaymentMethodId { get; set; }
        public int StatusOrderId { get; set; }

        public virtual PaymentMethod PaymentMethod { get; set; } = null!;
        public virtual Customer PhoneNumberNavigation { get; set; } = null!;
        public virtual staff Staff { get; set; } = null!;
        public virtual StatusOrder StatusOrder { get; set; } = null!;
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
