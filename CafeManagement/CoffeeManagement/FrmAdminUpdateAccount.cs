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
using Library.Service.ServicesImplement;
using System.Globalization;

namespace CoffeeManagement
{
    public partial class FrmAdminUpdateAccount : Form
    {
        private int staid;
        public FrmAdminUpdateAccount(Account account)
        {
            InitializeComponent();
            LoadData(account);
            LoadStatus(account);
        }
        //0 - Inactive/ 1 - Active
        private void LoadStatus(Account account)
        {
            Dictionary<int, string> comboSource = new Dictionary<int, string>() {
                {0,"InActive" },{1,"Active" }
            };
            cbStatus.DataSource = new BindingSource(comboSource, null);
            cbStatus.DisplayMember = "Value";
            cbStatus.ValueMember = "Key";
            cbStatus.SelectedValue = account.Status;
        }
        private void LoadData(Account account)
        {
            txtUsername.Text = account.Username;
            txtPassword.Text = account.Password;
            txtConfirmPassword.Text = account.Password;
            if(account.staff != null)
            {
                MtxtDateJoin.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                MtxtDateOfBirth.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                TxtFullName.Text = account.staff.Fullname;
                MtxtDateJoin.Text = account.staff.DateJoin.ToString("dd/MM/yyyy");
                MtxtDateOfBirth.Text = account.staff.DateOfBirth.Value.ToString("dd/MM/yyyy");
                TxtAddress.Text = account.staff.Address;
                TxtPhoneNumber.Text = account.staff.PhoneNumber;
                txtSalary.Text = account.staff.Salary.ToString();
                TxtTaxCode.Text = account.staff.TaxCode;
                MtxtDateJoin.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
                MtxtDateOfBirth.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
                staid = account.staff.StaffId;
            }

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnUpdateAccount_Click(object sender, EventArgs e)
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
                        StaffId = staid,
                        Fullname = TxtFullName.Text,
                        Address = TxtAddress.Text,
                        DateJoin = DateTime.ParseExact(MtxtDateJoin.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture),
                        PhoneNumber = TxtPhoneNumber.Text,
                        Salary = Convert.ToDouble(txtSalary.Text),
                        TaxCode = TxtTaxCode.Text,
                        DateOfBirth = DateTime.ParseExact(MtxtDateOfBirth.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture),
                        Username = acc.Username
                    };
                }
                catch (Exception ex)
                {
                    //if(ex.Message.Equals(""))
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    var staffacc = staffService.Updatestaff(sta);
                    var account = accountService.UpdateAccount(acc);

                    if (account != null && staffacc != null)
                    {
                        MessageBox.Show("Successfully update existing Account", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Failed update existing Account", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
