using Library.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Service
{
    public interface IOrderService
    {
        public bool CreateOrder(List<Product> listOrder, Customer customer, staff staff, double amount);

        public List<Order> ListALL();

        public List<Order> ListALLByOrderID(int orderid);

    }
}
