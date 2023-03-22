using Library.Model;
using Library.Service;
using Library.Service.ServicesImplement;
using Library.Utils;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CoffeeManagement
{
    public partial class FrmStaffInsertCustomer : Form
    {
        IOrderService orderServices;
        IStaffServices staffService;
        ICustomerService customerService;
        public Account AccountStaff { get; set; }

        public List<Product> listOrder { get; set; }

        public double amount { get; set; }

        public bool isPayment { get; set; }
        public FrmStaffInsertCustomer(Account account)
        {
            InitializeComponent();
            AccountStaff = account;
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
                var staffInfor = staffService.GetStaffsByUserName(AccountStaff.Username);
                if (isPayment)
                {
                    var customerCheck = customerService.GetCustomerByPhone(customer.PhoneNumber);
                    if (customerCheck != null)
                    {
                        customerService.UpdateCustomer(customer);
                    }

                    if (CreateOrder(customer, staffInfor))
                    {
                        this.Hide();
                        MessageBox.Show("Order successfully");

                    }
                }
                else
                {
                    var customerExist = customerService.GetCustomerByPhone(customer.PhoneNumber);
                    if (customerExist != null)
                    {
                        MessageBox.Show("Customer Already Existed!", "Customer Existed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                    }
                    else
                    {
                        customerService.CreateCustomerToOrder(customer);
                        MessageBox.Show("Successfully adding new Customer!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
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
