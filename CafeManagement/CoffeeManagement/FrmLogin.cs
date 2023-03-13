using Library.Model;
using Library.Repository;
using Library.Repository.RepositoryIml;
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
         
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string error = "";
            //Code login
            string username = txtUsername.Text;
            string password = TxtPassword.Text;
            if(username.Length == 0 || password.Length == 0)
            {
                error = "Username and Password is required\n";
            }
            else
            {
                AccountRepository accountRepository = new AccountRepositoryIml();
                var account = accountRepository.checkLogin(username, password);
                if(account != null)
                {
                    if(account.RoleId == 0)
                    {
                        FrmAdminDashboard frmAdminDashboard = new FrmAdminDashboard();
                        this.Hide();
                        frmAdminDashboard.ShowDialog();
                    }
                    else if(account.RoleId == 1)
                    {
                        FrmStaffDashboard frmStaffDashboard = new FrmStaffDashboard();
                        this.Hide();
                        frmStaffDashboard.ShowDialog();
                    }
                }
                else
                {
                    error = "Invalid username and password";
                    MessageBox.Show(error, "Login - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }                      
        }
    }
}
