using Library.Model;
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
    public partial class FrmStaffProfile : Form
    {
        public FrmStaffDashboard FrmStaffDashboard { get; set; }
        public Account AccountStaff { get; set; }
        public FrmStaffProfile()
        {
            InitializeComponent();
        }
        public FrmStaffProfile(Account account)
        {
            InitializeComponent();
            LoadData(account);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            FrmStaffEditProfile frmStaffEditProfile = new FrmStaffEditProfile();
            frmStaffEditProfile.ShowDialog();
        }
        private void LoadData(Account account)
        {
            staff accsta = account.staff;
            lbDateJoinHeader.Text = accsta.DateJoin.ToString("dd/MM/yyyy");
            lbSalaryHeader.Text = String.Format("{0:0,0 đ}", accsta.Salary);
            txtStaffname.Text = accsta.Fullname.ToString();
            txtTaxCode.Text = accsta.TaxCode.ToString();
            txtStaffID.Text = accsta.StaffId.ToString();
            txtAddress.Text = accsta.Address;
            txtPhoneNumber.Text = accsta.PhoneNumber;
            txtDoB.Text = accsta.DateOfBirth.Value.ToString("dd/MM/yyyy");
        }
    }
}
