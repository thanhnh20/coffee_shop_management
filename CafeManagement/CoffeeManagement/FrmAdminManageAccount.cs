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
    public partial class FrmAdminManageAccount : Form
    {
        public FrmAdminDashboard FrmAdminDashboard { get; set; }
        public FrmAdminManageAccount()
        {
            InitializeComponent();
        }

        private void BtnAddNewAccount_Click(object sender, EventArgs e)
        {
            FrmAdminInsertAccount frm = new FrmAdminInsertAccount();
            frm.ShowDialog();
        }
    }
}
