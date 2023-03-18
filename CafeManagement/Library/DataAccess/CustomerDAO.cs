using Library.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataAccess
{
    public class CustomerDAO
    {
        CoffeeShopManagementContext db = new CoffeeShopManagementContext();
        private static CustomerDAO instance = null;
        private static readonly object instancelock = new object();
        private CustomerDAO() { }
        public static CustomerDAO Instance
        {
            get
            {
                lock (instancelock)
                {
                    if (instance == null)
                    {
                        instance = new CustomerDAO();
                    }
                    return instance;
                }
            }
        }

        public void CreateCustomerToOrder(Customer customerCreate) {
            using (var db = new CoffeeShopManagementContext()) {
                var customer = db.Customers.Where( c => c.PhoneNumber.Equals(customerCreate.PhoneNumber) ).FirstOrDefault();
                if(customer == null)
                {
                    db.Customers.Add(customerCreate);
                    db.SaveChanges();
                }
                else
                {
                    customer.Name = customerCreate.Name;
                    customer.Address = customerCreate.Address;
                    customer.Email = customerCreate.Email;
                    db.SaveChanges();
                }           
            }
        }

        public Customer GetCustomerByNumberPhone(string numberPhone) {
            using (var db = new CoffeeShopManagementContext()) {
                return db.Customers.Where(c => c.PhoneNumber.Equals(numberPhone)).FirstOrDefault();
            }
        }

        public bool UpdateCustomer(Customer customer) {
            using (var db = new CoffeeShopManagementContext()) {
                var customerFound = db.Customers.Where(c => c.PhoneNumber.Equals(customer.PhoneNumber)).FirstOrDefault();
                if (customerFound != null) {
                    customerFound.Name = customer.Name;
                    customerFound.Address = customer.Address;
                    customerFound.Email = customer.Email;
                    db.SaveChanges();
                    return true;
                }
                return false;
            }
        }
        public List<Customer> getAllCustomers() => db.Customers.ToList();
        public List<Customer> getAllCustomersByName(string name) => db.Customers.Where(acc => acc.Name.Contains(name)).ToList();
        public Customer getCustomerbyEmail(string email) => db.Customers.FirstOrDefault(acc => acc.Email.Equals(email));
        public bool DeleteCustomer(string phonenumber)
        {
            try
            {
                var user = GetCustomerByNumberPhone(phonenumber);
                if (user != null)
                {
                    db.Customers.Remove(user);
                    db.SaveChanges();
                    return true;
                }
                return false;
            }
            catch
            {
                throw;
            }
        }
    }
}

        