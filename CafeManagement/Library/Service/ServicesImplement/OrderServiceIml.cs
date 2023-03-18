using Library.DataAccess;
using Library.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Service.ServicesImplement
{
    public class OrderServiceIml : IOrderService
    {
        public bool CreateOrder(List<Product> listOrder, Customer customer, staff staff, double amount) => OrderDAO.Instance.CreateOrder(listOrder, customer, staff, amount);
    }
}
