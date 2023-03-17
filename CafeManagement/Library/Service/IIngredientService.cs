using Library.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Service
{
    public interface IIngredientService
    {

        public void InserIngredient(Ingredient ingredient);

        public void UpdateIngredient(Ingredient ingredient);

        public IEnumerable<Ingredient> LoadIngredient();

        public Ingredient GetIngredientById(int id);

        public Int32 GetStatus(int id);

        public IEnumerable<Ingredient> GetIngredientByID(int id);

        public IEnumerable<string> GetNameIngredient();

        public IEnumerable<Ingredient> GetIngredientByName(string name);
    }
}
