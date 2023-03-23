using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Library.Model
{
    public partial class Product
    {
        public Product()
        {
            IngredientProducts = new HashSet<IngredientProduct>();
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int ProductId { get; set; }

        [Required]
        public string ProductName { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public double? Price { get; set; }

        [Required]
        public string Image { get; set; }
        public int? Status { get; set; }
        public int? CategoryId { get; set; }

        public virtual CategoryProduct Category { get; set; }
        public virtual ICollection<IngredientProduct> IngredientProducts { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
