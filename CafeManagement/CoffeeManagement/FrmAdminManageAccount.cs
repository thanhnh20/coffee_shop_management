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
    public partial class FrmAdminManageAccount : Form
    {
        public FrmAdminDashboard FrmAdminDashboard { get; set; }
        public FrmAdminManageAccount()
        {
            InitializeComponent();
            LoadData();
        }

        private void BtnAddNewAccount_Click(object sender, EventArgs e)
        {
            FrmAdminInsertAccount frm = new FrmAdminInsertAccount();
            frm.ShowDialog();
        }
        private void LoadData()
        {
            List<AccStaViewModel> accstalis = GeStaffAccountList();
            DgvAccountList.AutoGenerateColumns = false;
            DgvAccountList.DataSource = accstalis;
            CbFilterAccountList.SelectedItem = "Username";
        }

        private void BtnSearchList_Click(object sender, EventArgs e)
        {
            if (CbFilterAccountList.SelectedText.Equals("") && TxtSearchAccountFollowingFilter.Text.Equals(""))
            {
                MessageBox.Show("Show All Accounts!\n You can search a Account By fill in the Username or RoleId in the Empty Box next to Search Button!");
                LoadData();
            }
            else if(TxtSearchAccountFollowingFilter.Text != "" && CbFilterAccountList.SelectedItem.Equals("Username"))
            {
                try
                {
                    List<AccStaViewModel> accstalis = GeStaffAccountList(TxtSearchAccountFollowingFilter.Text);
                    if (accstalis != null && accstalis.Count > 0)
                    {
                        DgvAccountList.AutoGenerateColumns = false;
                        DgvAccountList.DataSource = accstalis;
                    }
                    else
                    {
                        MessageBox.Show("Username not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        LoadData();
                    }
                }
                catch (Exception er)
                {
                    MessageBox.Show("Error while processing your request!: \n"+ er.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        //Get Staff Account List (auto refresh everytime this method is called)
        private List<AccStaViewModel> GeStaffAccountList(string name = "")
        {
            IAccountService accountService = new AccountServiceIml();
            IStaffServices staffService = new StaffServiceIml();
            List<AccStaViewModel> accstalis = new();
            var acclis = accountService.GetAccounts();
            if (name != "")
            {
                acclis = accountService.GetAccountsByName(name);
            }
            if(acclis != null)
            {
                foreach (var account in acclis)
                {
                    var accstanew = new AccStaViewModel()
                    {
                        Username = account.Username,
                        Password = account.Password,
                        RoleId = account.RoleId,
                        Status = account.Status
                    };
                    if (account.staff != null)
                    {
                        account.staff = staffService.GetstaffById(account.staff.StaffId);
                        accstanew.Fullname = account.staff.Fullname;
                        accstanew.Address = account.staff.Address;
                        accstanew.DateJoin = account.staff.DateJoin;
                        accstanew.DateOfBirth = account.staff.DateOfBirth;
                        accstanew.PhoneNumber = account.staff.PhoneNumber;
                        accstanew.Salary = account.staff.Salary;
                        accstanew.StaffId = account.staff.StaffId;
                        accstanew.TaxCode = account.staff.TaxCode;
                    }
                    accstalis.Add(accstanew);
                }
            }
            return accstalis;
        }

        private void BtnUpdateExistedAccount_Click(object sender, EventArgs e)
        {
            if (DgvAccountList.SelectedRows.Count > 0)
            {
                IAccountService accountService = new AccountServiceIml();
                var updateAcc = accountService.GetAccountByName(DgvAccountList.SelectedRows[0].Cells[1].Value.ToString());
                if (updateAcc != null)
                {
                    FrmAdminUpdateAccount formUpdateAcc = new FrmAdminUpdateAccount(updateAcc);
                    formUpdateAcc.ShowDialog();
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
                MessageBox.Show("Please select a Staff Account to Update!");
            }
        }
    }
}
