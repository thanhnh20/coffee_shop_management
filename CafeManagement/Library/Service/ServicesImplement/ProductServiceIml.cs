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
        public List<Product> GetAllProduct() => ProductDAO.Instance.GetAllProduct();

    }
}
