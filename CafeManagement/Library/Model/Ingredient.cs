using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Numerics;

#nullable disable

namespace Library.Model
{
    public partial class Ingredient
    {
        public Ingredient()
        {
            IngredientProducts = new HashSet<IngredientProduct>();
            Storages = new HashSet<Storage>();
        }

        public int IngredientId { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        public string Unit { get; set; }
        [Required, Range(0, 1)] // 1: active, 0: inactive
        public int Status { get; set; }

        public virtual ICollection<IngredientProduct> IngredientProducts { get; set; }
        public virtual ICollection<Storage> Storages { get; set; }
    }
}
