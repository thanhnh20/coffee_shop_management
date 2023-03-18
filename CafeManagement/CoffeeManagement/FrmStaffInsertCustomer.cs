using Library.Model;
using Library.Service;
using Library.Service.ServicesImplement;
using Library.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeManagement
{
    public partial class FrmStaffInsertCustomer : Form
    {
        IOrderService orderServices; 
        IStaffService staffService;
        ICustomerService customerService;
        public Account AccountStaff { get; set; }

        public List<Product> listOrder { get; set; }

        public double amount { get; set; }

        public bool isPayment { get; set; }
        public FrmStaffInsertCustomer()
        {
            InitializeComponent();
            customerService = new CustomerServiceIml();
            orderServices = new OrderServiceIml();
            staffService = new StaffServiceIml();
        }

        public void CreateCustomer()
        {
            Customer customer = new Customer()
            {
                PhoneNumber = txtPhoneNumber.Text,
                Email = txtEmail.Text,
                Address = TxtAddress.Text,
                Name = txtName.Text,
            };
            var error = MyHelper.CheckValid(customer);
            if (error != null)
            {
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var staffInfor = staffService.getStaffByUserName(AccountStaff.Username);
                var customerExist = customerService.GetCustomerByPhone(customer.PhoneNumber);
                if (customerExist != null)
                {
                    customerService.UpdateCustomer(customer);
                }
                else
                {
                    customerService.CreateCustomerToOrder(customer);       
                }
                if (isPayment)
                {
                    if (CreateOrder(customer, staffInfor))
                    {
                        this.Hide();
                        MessageBox.Show("Order successfully");
                        
                    }
                }
            }
        }
        public bool CreateOrder(Customer customer, staff staffInfor)
        {
            try
            {
                return orderServices.CreateOrder(listOrder, customer, staffInfor, amount);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            CreateCustomer();
        }
    }
}
