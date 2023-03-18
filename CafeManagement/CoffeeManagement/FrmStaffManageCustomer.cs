using Library.Service.ServiceImplement;
using Library.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Model;
using Library.Service.ServicesImplement;
using Library.Utils;

namespace CoffeeManagement
{
    public partial class FrmStaffManageCustomer : Form
    {
        public FrmStaffDashboard FrmStaffDashboard { get; set; }
        public Account AccountStaff { get; set; }
        public FrmStaffManageCustomer(Account accountStaff)
        {
            InitializeComponent();
            LoadData();
            AccountStaff = accountStaff;
        }
        private void LoadData()
        {
            ICustomerService customerService = new CustomerServiceIml();
            List<Customer> cusstalis = new();
            cusstalis = customerService.GetCustomers();
            DgvAccountList.AutoGenerateColumns = false;
            DgvAccountList.DataSource = cusstalis;
            CbFilterAccountList.SelectedItem = "Name";
        }

        private void BtnSearchList_Click(object sender, EventArgs e)
        {
            if (CbFilterAccountList.SelectedText.Equals("") && TxtSearchAccountFollowingFilter.Text.Equals(""))
            {
                MessageBox.Show("Show All Customers!\n You can search a Customer By fill in the Name or Phone Number in the Empty Box next to Search Button!");
                LoadData();
            }
            else if(TxtSearchAccountFollowingFilter.Text != "" && CbFilterAccountList.SelectedItem.Equals("Name"))
            {
                try
                {
                    ICustomerService customerService = new CustomerServiceIml();
                    List<Customer> cusstalis = customerService.GetCustomersByName(TxtSearchAccountFollowingFilter.Text);
                    if (cusstalis != null && cusstalis.Count > 0)
                    {
                        DgvAccountList.AutoGenerateColumns = false;
                        DgvAccountList.DataSource = cusstalis;
                    }
                    else
                    {
                        MessageBox.Show("Name not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        LoadData();
                    }
                }
                catch (Exception er)
                {
                    MessageBox.Show("Error while processing your request!: \n"+ er.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnUpdateExistedAccount_Click(object sender, EventArgs e)
        {
            if (DgvAccountList.SelectedRows.Count > 0)
            {
                ICustomerService customerService = new CustomerServiceIml();
                var updatecus = customerService.GetCustomerByPhone(DgvAccountList.SelectedRows[0].Cells[0].Value.ToString());
                if (updatecus != null)
                {
                    FrmStaffUpdateCustomer formUpdatecus = new FrmStaffUpdateCustomer(AccountStaff,updatecus);
                    formUpdatecus.ShowDialog();
                }
                LoadData();
                #region old codes
                /*FormUpdateCategory fuc = new();
                fuc.ShowDialog();
                var cate = new Category()
                {
                    Id = (int)dataGridView1.SelectedRows[0].Cells[0].Value,
                    Name = (string)dataGridView1.SelectedRows[0].Cells[1].Value,
                    Status = (int)dataGridView1.SelectedRows[0].Cells[2].Value
                };
                fuc.LoadCategory(cate);*/
                #endregion
            }
            else
            {
                MessageBox.Show("Please select a Customer to Update!");
            }
        }

        private void BtnAddNewCustomer_Click(object sender, EventArgs e)
        {
            FrmStaffInsertCustomer frm = new FrmStaffInsertCustomer(AccountStaff);
            frm.ShowDialog();
            LoadData();
        }
    }
}
