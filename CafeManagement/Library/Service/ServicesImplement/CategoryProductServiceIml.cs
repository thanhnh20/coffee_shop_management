using Library.DataAccess;
using Library.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Service.ServicesImplement
{
    public class CategoryProductServiceIml : ICategoryProductService
    {
        public IEnumerable<String> GetCategoryProductsName() => CategoryDAO.Instance.GetNameCategoryProducts();

        public CategoryProduct GetCategoryProductByName(string name) => CategoryDAO.Instance.GetCategoryProductByName(name);
    }
}
