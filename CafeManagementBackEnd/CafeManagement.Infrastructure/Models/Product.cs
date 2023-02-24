using System;
using System.Collections.Generic;

namespace CafeManagement.Infrastructure.Models
{
    public partial class Product
    {
        public Product()
        {
            IngredientProducts = new HashSet<IngredientProduct>();
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; } = null!;
        public string? Description { get; set; }
        public double? Price { get; set; }
        public string? Image { get; set; }
        public int? Status { get; set; }
        public int? CategoryId { get; set; }

        public virtual CategoryProduct? Category { get; set; }
        public virtual ICollection<IngredientProduct> IngredientProducts { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
