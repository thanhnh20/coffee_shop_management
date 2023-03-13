using System;
using System.Collections.Generic;

#nullable disable

namespace Library.Model
{
    public partial class Storage
    {
        public int StorageId { get; set; }
        public int IngredientId { get; set; }
        public int Quantity { get; set; }

        public virtual Ingredient Ingredient { get; set; }
    }
}
