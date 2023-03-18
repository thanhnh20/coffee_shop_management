using Library.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataAccess
{
    public class ProductDAO
    {
        private static ProductDAO instance = null;
        private static readonly object instancelock = new object();
        private ProductDAO() { }
        public static ProductDAO Instance
        {
            get
            {
                lock (instancelock)
                {
                    if (instance == null)
                    {
                        instance = new ProductDAO();
                    }
                    return instance;
                }
            }
        }

        public List<Product> GetAllProduct()
        {
            using (var db = new CoffeeShopManagementContext())
            {
                return db.Products.ToList();
            }
        } 
    }
}
