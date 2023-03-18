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

        public IEnumerable<Product> GetProducts()
        {
            using (CoffeeShopManagementContext db = new CoffeeShopManagementContext())
            {
                return db.Products.ToList();
            }
        }

        public Product GetProductsByID(int id)
        {
            using (CoffeeShopManagementContext db = new CoffeeShopManagementContext())
            {
                return db.Products.Where(i => i.ProductId.Equals(id)).FirstOrDefault();
            }
        }


        public IEnumerable<Product> GetProductsByName(string name)
        {
            using (CoffeeShopManagementContext db = new CoffeeShopManagementContext())
            {
                return db.Products.Where(p => p.ProductName.Contains(name)).ToList();
            }
        }

        public void UpdateProduct(Product product)
        {
            using (CoffeeShopManagementContext db = new CoffeeShopManagementContext())
            {
                db.Entry<Product>(product).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void InsertProduct(Product product)
        {
            using (CoffeeShopManagementContext db = new CoffeeShopManagementContext())
            {
                db.Add(product);
                db.SaveChanges();
            }

        }
    }
}
