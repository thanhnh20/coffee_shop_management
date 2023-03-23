using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Library.Model
{
    public partial class IngredientProduct
    {
        public int ProductId { get; set; }
        [Required]

        public int IngredientId { get; set; }
        [Required]

        public int Mass { get; set; }

        public virtual Ingredient Ingredient { get; set; }
        public virtual Product Product { get; set; }


    }
}
