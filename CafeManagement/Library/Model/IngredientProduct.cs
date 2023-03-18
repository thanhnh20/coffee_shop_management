using System;
using System.Collections.Generic;

#nullable disable

namespace Library.Model
{
    public partial class IngredientProduct
    {
        public int ProductId { get; set; }
        public int IngredientId { get; set; }
        public int Mass { get; set; }

        public virtual Ingredient Ingredient { get; set; }
        public virtual Product Product { get; set; }


    }
}
