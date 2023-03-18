using Library.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Service
{
    public interface ICustomerService
    {
        public void CreateCustomerToOrder(Customer customerCreate);

        public Customer GetCustomerByPhone(string numberPhone);

        public bool UpdateCustomer(Customer customer);
    }
}
