using Library.DataAccess;
using Library.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Service.ServicesImplement
{
    public class ProductServiceIml : IProductService
    {
        public IEnumerable<Product> GetProducts() => ProductDAO.Instance.GetProducts();

        public void InsertProduct(Product product) => ProductDAO.Instance.InsertProduct(product);

        public IEnumerable<Product> GetProductByName(string name) => ProductDAO.Instance.GetProductsByName(name);

        public Product GetProductByID(int id) => ProductDAO.Instance.GetProductsByID(id);

        public void UpdateProduct(Product product) => ProductDAO.Instance.UpdateProduct(product);

        public List<Product> GetAllProduct() => ProductDAO.Instance.GetAllProduct();
    }
}