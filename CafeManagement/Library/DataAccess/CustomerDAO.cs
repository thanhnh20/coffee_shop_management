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
        public List<Customer> getAllCustomers() => db.Customers.ToList();

        public List<Customer> getAllCustomersByName(string name) => db.Customers.Where(acc => acc.Name.Contains(name)).ToList();
        public Customer getCustomerbyPhoneNumber(string phonenumber) => db.Customers.FirstOrDefault(acc => acc.PhoneNumber.Equals(phonenumber));
        public Customer getCustomerbyEmail(string email) => db.Customers.FirstOrDefault(acc => acc.Email.Equals(email));
        public Customer CreateCustomer(Customer account)
        {
            try
            {
                db.Customers.Add(account);
                db.SaveChanges();
                account = getCustomerbyPhoneNumber(account.PhoneNumber);
                return account;
            }
            catch
            {
                throw;
            }
        }
        public bool DeleteCustomer(Customer account)
        {
            try
            {
                var user = getCustomerbyPhoneNumber(account.PhoneNumber);
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
        public Customer UpdateCustomer(Customer account)
        {
            try
            {
                var user = getCustomerbyPhoneNumber(account.PhoneNumber);
                if (user != null)
                {
                    user.Name = account.Name;
                    user.Email = account.Email;
                    user.Address = account.Address;
                    db.Customers.Update(user);
                    db.SaveChanges();
                    user = getCustomerbyPhoneNumber(account.PhoneNumber);
                    return user;
                }
                return null;
            }
            catch { throw; }
        }
    }
}
