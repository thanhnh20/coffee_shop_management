using Library.DataAccess;
using Library.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Service.ServicesImplement
{
    public class CustomerServiceIml : ICustomerService
    {
        public void CreateCustomerToOrder(Customer customerCreate) => CustomerDAO.Instance.CreateCustomerToOrder(customerCreate);

        public bool DeleteCustomer(string phoneNumber) => CustomerDAO.Instance.DeleteCustomer(phoneNumber);

        public Customer GetCustomerByPhone(string numberPhone) => CustomerDAO.Instance.GetCustomerByNumberPhone(numberPhone);

        public List<Customer> GetCustomers() => CustomerDAO.Instance.getAllCustomers();

        public List<Customer> GetCustomersByName(string name) => CustomerDAO.Instance.getAllCustomersByName(name);  

        public bool UpdateCustomer(Customer customer) => CustomerDAO.Instance.UpdateCustomer(customer);
    }
}
