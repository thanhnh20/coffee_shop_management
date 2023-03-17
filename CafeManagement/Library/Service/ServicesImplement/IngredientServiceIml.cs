using Library.DataAccess;
using Library.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Service.ServicesImplement
{
    public class IngredientServiceIml : IIngredientService
    {
        public void InserIngredient(Ingredient ingredient) => IngredientDAO.Instance.InsertIngredient(ingredient);

        public IEnumerable<Ingredient> LoadIngredient() => IngredientDAO.Instance.LoadIngredient();

        public Ingredient GetIngredientById(int id) => IngredientDAO.Instance.GetIngredientById(id);

        public Int32 GetStatus(int id) => IngredientDAO.Instance.GetStatus(id);

        public IEnumerable<Ingredient> GetIngredientByID(int id) => IngredientDAO.Instance.GetIngredientByID(id);

        public void UpdateIngredient(Ingredient ingredient) => IngredientDAO.Instance.UpdateIngredient(ingredient);

        public IEnumerable<string> GetNameIngredient() => IngredientDAO.Instance.GetNameIngredient().ToList();

        public IEnumerable<Ingredient> GetIngredientByName(string name) => IngredientDAO.Instance.GetIngredientByName(name);

    }
}
