using Library.Model;
using Library.Service.ServiceImplement;
using Library.Service;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Globalization;
using Library.Service.ServicesImplement;

namespace CoffeeManagement
{
    public partial class FrmAdminInsertAccount : Form
    {
        public FrmAdminInsertAccount()
        {
            InitializeComponent();
            LoadStatus();
        }

        private void BtnCreateAccount_Click(object sender, EventArgs e)
        {
            if (!txtConfirmPassword.Text.Equals(txtPassword.Text)) MessageBox.Show("Password and Confirm Password not matched!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                Account acc = new Account()
                {
                    Username = txtUsername.Text,
                    Password = txtPassword.Text,
                    RoleId = 1,
                    Status = Convert.ToInt32(cbStatus.SelectedValue),
                };
                staff sta = new staff();
                try
                {
                    sta = new staff()
                    {
                        Fullname = TxtFullName.Text,
                        Address = TxtAddress.Text,
                        DateJoin = DateTime.ParseExact(MtxtDateJoin.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture),
                        PhoneNumber = TxtPhoneNumber.Text,
                        Salary = Convert.ToDouble(txtSalary.Text),
                        TaxCode = TxtTaxCode.Text,
                        DateOfBirth = DateTime.ParseExact(MtxtDateOfBirth.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture),
                        Username = txtUsername.Text,
                        UsernameNavigation = acc
                    };
                }
                catch(Exception ex)
                {
                    //if(ex.Message.Equals(""))
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                var resultError = MyHelper.CheckValid(acc) + MyHelper.CheckValid(sta);
                if (resultError != null && resultError.Count() > 0)
                {
                    MessageBox.Show(resultError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    IAccountService accountService = new AccountServiceIml();
                    IStaffServices staffService = new StaffServiceIml();
                    var staffacc = staffService.Createstaff(sta);
                    //var account = accountService.CreateAccount(acc);

                    if (staffacc != null)
                    {
                        MessageBox.Show("Successfully adding new Account", "Success", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Failed adding new Account", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        //0 - Inactive/ 1 - Active
        private void LoadStatus()
        {
            Dictionary<int, string> comboSource = new Dictionary<int, string>() {
                {0,"InActive" },{1,"Active" }
            };
            cbStatus.DataSource = new BindingSource(comboSource, null);
            cbStatus.DisplayMember = "Value";
            cbStatus.ValueMember = "Key";
            cbStatus.SelectedValue = 1;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
