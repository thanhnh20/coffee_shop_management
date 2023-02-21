using System;
using System.Collections.Generic;

namespace CafeManagement.Infrastructure.Models
{
    public partial class Storage
    {
        public int StorageId { get; set; }
        public int IngredientId { get; set; }
        public int Quantity { get; set; }

        public virtual Ingredient Ingredient { get; set; } = null!;
    }
}
