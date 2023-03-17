using Library.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Service
{
    public interface IIngredientProductService
    {
        public void insertIngredientProduct(Product product, int id, int mass);

        public void updateIngredientProduct(Product product, int id, int mass);

        public IngredientProduct GetByID(int id);
    }
}
