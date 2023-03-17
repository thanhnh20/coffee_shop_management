using Library.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataAccess
{
    public class CategoryDAO
    {


        private static CategoryDAO instance = null;
        private static readonly object instancelock = new object();
        private CategoryDAO() { }
        public static CategoryDAO Instance
        {
            get
            {
                lock (instancelock)
                {
                    if (instance == null)
                    {
                        instance = new CategoryDAO();
                    }
                    return instance;
                }
            }
        }

        public IEnumerable<String> GetNameCategoryProducts()
        {
            using (var db = new CoffeeShopManagementContext())
            {
                return db.CategoryProducts.Select(m => m.Name).ToList();
            }
        }

        public CategoryProduct GetCategoryProductByName(string name)
        {
            using (var db = new CoffeeShopManagementContext())
            {
                return db.CategoryProducts.Where(m => m.Name.Equals(name)).FirstOrDefault();
            }
        }
    }
}
