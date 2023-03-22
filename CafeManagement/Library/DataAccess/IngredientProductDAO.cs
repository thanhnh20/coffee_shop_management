using Library.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataAccess
{
    public class IngredientProductDAO
    {
        private static IngredientProductDAO instance = null;
        private static readonly object instancelock = new object();
        private IngredientProductDAO() { }
        public static IngredientProductDAO Instance
        {
            get
            {
                lock (instancelock)
                {
                    if (instance == null)
                    {
                        instance = new IngredientProductDAO();
                    }
                    return instance;
                }
            }
        }

        public IngredientProduct GetByID(int id) { 
            using (var db = new CoffeeShopManagementContext())
            {
                return db.IngredientProducts.Where(i => i.ProductId.Equals(id)).FirstOrDefault();
            }
        }

        public void updateIngredientProduct(Product product, int id, int mass)
        {
            using (CoffeeShopManagementContext db = new CoffeeShopManagementContext())
            {
                var ingredientProduct = db.IngredientProducts.Where(l => l.ProductId == product.ProductId && l.IngredientId == id).FirstOrDefault();
                if(ingredientProduct != null)
                {
                    ingredientProduct.Mass = mass;
                    db.SaveChanges();
                }
                else
                {
                    var temp = new IngredientProduct()
                    {
                        IngredientId = id,
                        ProductId = product.ProductId,
                        Mass = mass
                    };
                    db.Add(temp);
                    db.SaveChanges();
                }
                
            }
        }

        public void insertIngredientProduct(Product product, int id, int mass)
        {
            var temp = new IngredientProduct()
            {
                IngredientId = id,
                ProductId = product.ProductId,
                Mass = mass
            };
            using (var db = new CoffeeShopManagementContext())
            {
                db.Add(temp);
                db.SaveChanges();
            }
        }
    }
}
