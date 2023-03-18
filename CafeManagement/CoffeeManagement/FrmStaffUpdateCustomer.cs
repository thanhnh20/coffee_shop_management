using Library.Model;
using Library.Service;
using Library.Service.ServicesImplement;
using Library.Utils;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CoffeeManagement
{
    public partial class FrmStaffUpdateCustomer : Form
    {
        IOrderService orderServices;
        IStaffServices staffService;
        ICustomerService customerService;
        public Account AccountStaff { get; set; }

        public List<Product> listOrder { get; set; }

        public double amount { get; set; }

        public bool isPayment { get; set; }
        public FrmStaffUpdateCustomer(Account account, Customer customer)
        {
            InitializeComponent();
            AccountStaff = account;
            customerService = new CustomerServiceIml();
            orderServices = new OrderServiceIml();
            staffService = new StaffServiceIml();
            LoadData(customer);
        }
        private void LoadData(Customer customer)
        {
            txtPhoneNumber.Text = customer.PhoneNumber;
            txtEmail.Text = customer.Email;
            txtName.Text = customer.Name;
            TxtAddress.Text = customer.Address;
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
                var customerExist = customerService.GetCustomerByPhone(customer.PhoneNumber);
                if (customerExist != null)
                {
                    customerService.UpdateCustomer(customer);
                    MessageBox.Show("Successfully Updating Customer!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
                else
                {
                    customerService.CreateCustomerToOrder(customer);
                    MessageBox.Show("Create New Customer Instead!", "Customer Existed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
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
