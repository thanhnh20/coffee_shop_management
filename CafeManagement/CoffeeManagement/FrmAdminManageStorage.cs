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
    public partial class FrmAdminManageStorage : Form
    {
        public FrmAdminDashboard FrmAdminDashboard { get; set; }
        public FrmAdminManageStorage()
        {
            InitializeComponent();
        }

        private void BtnAddNewIngreadient_Click(object sender, EventArgs e)
        {
            FrmAdminInsertIngredient frm  = new FrmAdminInsertIngredient();
            frm.ShowDialog();
        }
    }
}
