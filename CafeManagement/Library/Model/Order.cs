using System;
using System.Collections.Generic;

#nullable disable

namespace Library.Model
{
    public partial class Order
    {
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int OrderId { get; set; }
        public DateTime? DateOrder { get; set; }
        public double? Amount { get; set; }
        public int StaffId { get; set; }
        public string PhoneNumber { get; set; }
        public int PaymentMethodId { get; set; }
        public int StatusOrderId { get; set; }

        public virtual PaymentMethod PaymentMethod { get; set; }
        public virtual Customer PhoneNumberNavigation { get; set; }
        public virtual staff Staff { get; set; }
        public virtual StatusOrder StatusOrder { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
