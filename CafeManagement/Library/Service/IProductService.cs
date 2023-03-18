using Library.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Service
{
    public interface IProductService
    {
        public IEnumerable<Product> GetProducts();

        public IEnumerable<Product> GetProductByName(string name);

        public Product GetProductByID(int id);

        public void InsertProduct(Product product);

        public void UpdateProduct(Product product);

        public List<Product> GetAllProduct();
    }
}