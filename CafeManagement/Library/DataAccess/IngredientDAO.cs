using Library.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataAccess
{
    public class IngredientDAO
    {
        CoffeeShopManagementContext db = new CoffeeShopManagementContext();

        private static IngredientDAO instance = null;
        private static readonly object instancelock = new object();
        private IngredientDAO() { }
        public static IngredientDAO Instance
        {
            get
            {
                lock (instancelock)
                {
                    if (instance == null)
                    {
                        instance = new IngredientDAO();
                    }
                    return instance;
                }
            }
        }

        public void InsertIngredient(Ingredient ingredient)
        {
            using (CoffeeShopManagementContext db = new CoffeeShopManagementContext())
            {
                db.Ingredients.Add(ingredient);
                db.SaveChanges();
            }
        }

        public void UpdateIngredient(Ingredient ingredient)
        {
            using (CoffeeShopManagementContext db = new CoffeeShopManagementContext())
            {
                db.Entry<Ingredient>(ingredient).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public IEnumerable<Ingredient> LoadIngredient()
        {
            using (CoffeeShopManagementContext db = new CoffeeShopManagementContext())
            {

                return db.Ingredients.ToList();

            }
        }

        public IEnumerable<string> GetNameIngredient()
        {
            using (CoffeeShopManagementContext db = new CoffeeShopManagementContext())
            {

                return db.Ingredients.Select(m => m.Name).ToList();

            }
        }

        public IEnumerable<Ingredient> GetIngredientByID(int id)
        {
            using (CoffeeShopManagementContext db = new CoffeeShopManagementContext())
            {
                return db.Ingredients.Where(i => i.IngredientId.Equals(id)).ToList();
            }
        }
        public Ingredient GetIngredientById(int id)
        {
            using (CoffeeShopManagementContext db = new CoffeeShopManagementContext())
            {
                return db.Ingredients.Where(i => i.IngredientId.Equals(id)).FirstOrDefault();
            }
        }

        public IEnumerable<Ingredient> GetIngredientByName(string name)
        {
            using (CoffeeShopManagementContext db = new CoffeeShopManagementContext())
            {
                return db.Ingredients.Where(i => i.Name.Equals(name)).ToList();
            }
        }

        public Int32 GetStatus(int id)
        {
            using (CoffeeShopManagementContext db = new CoffeeShopManagementContext())
            {
                return db.Ingredients.Where(i => i.IngredientId.Equals(id)).Select(s => s.Status).FirstOrDefault();
            }
        }

    }
}
