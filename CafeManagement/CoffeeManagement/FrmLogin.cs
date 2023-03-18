using Library.Model;
using Library.Service;
using Library.Service.ServiceImplement;
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
    public partial class FrmLogin : Form
    {
        private Account AccountStaff { get; set; }
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            //Code login
            string username = txtUsername.Text;
            string password = TxtPassword.Text;
            
            var accountInput = new Account()
            {
                Username = username,
                Password = password,
            };
            var resultError = MyHelper.CheckValid(accountInput);
            if(resultError != null)
            {
                MessageBox.Show(resultError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                IAccountService accountService = new AccountServiceIml();
                var account = accountService.checkLogin(username, password);
                if (account != null)
                {
                    if(account.Status != 0)
                    {
                        if (account.RoleId == 0)
                        {
                            FrmAdminDashboard frmAdminDashboard = new FrmAdminDashboard();
                            this.Hide();
                            frmAdminDashboard.ShowDialog();
                        }
                        else if (account.RoleId == 1)
                        {
                            FrmStaffDashboard frmStaffDashboard = new FrmStaffDashboard(account)
                            {
                                AccountStaff = account,
                            };
                            this.Hide();
                            frmStaffDashboard.ShowDialog();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Account not allow to this system", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }               
                }
                else
                {
                    MessageBox.Show("Username or Password is invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }          
            }             
        }

        private void FrmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                BtnLogin_Click(sender,e);
        }
    }
}
