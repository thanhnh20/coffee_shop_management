using Library.DataAccess;
using Library.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Service.ServicesImplement
{
    public class IngredientProductServiceIml : IIngredientProductService
    {
        public void insertIngredientProduct(Product product, int id, int mass) => IngredientProductDAO.Instance.insertIngredientProduct(product, id, mass);

        public void updateIngredientProduct(Product product, int id, int mass) => IngredientProductDAO.Instance.updateIngredientProduct(product, id, mass);

        public IngredientProduct GetByID(int id) => IngredientProductDAO.Instance.GetByID(id);

    }
}
