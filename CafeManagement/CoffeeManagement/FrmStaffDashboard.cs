using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeManagement
{
    public partial class FrmStaffDashboard : Form
    {
        //Fields Cấu hình giao diện
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        public FrmStaffDashboard()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            PnDashBoard.Controls.Add(leftBorderBtn);
            OpenChildForm(new FrmStaffProfile()
            {
                FrmStaffDashboard = this
            });

            /*
             change image
            PictureBox imageheader = PicLogo;
            imageheader.Image = Properties.Resources.cafe2;
            */
        }

        private void ActiveButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                //cần trả nguyên lại ban đầu cho các nút đã được nhấn trước
                DisableButton();

                //1. chỉnh button được hover
                // lấy cái button được nhấn
                currentBtn = (IconButton)senderBtn;
                // đổi màu background cho button đó
                currentBtn.BackColor = Color.FromName("Khaki");
                // đổi đổi màu chữ
                currentBtn.ForeColor = color;
                // chỉnh giữa cho chữ
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                // chỉnh màu cho icon 
                currentBtn.IconColor = color;
                // chỉnh thứ tự chữ và icon
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                // canh chỉnh icon đằng sau của chữ
                currentBtn.ImageAlign = ContentAlignment.BottomRight;


                //2. chỉnh cái left boarder button đã định nghĩa ở trên
                // chỉnh màu backgorund
                leftBorderBtn.BackColor = color;
                // chỉnh vì trí đúng với button được active
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                // cho button đã được định nghĩa trước đè lên cái cũ
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                PicIconControlHeader.IconChar = currentBtn.IconChar;
                LbControlHeader.Text = currentBtn.Text;
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                //1. chỉnh button được hover quay về bình thường
                // đổi màu background cho button đó khi hết được active
                currentBtn.BackColor = Color.FromName("LemonChiffon");
                // đổi đổi màu chữ về bình thường
                currentBtn.ForeColor = Color.Black;
                // chỉnh giữa cho chữ về bình thường
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                // chỉnh màu cho icon về bình thường
                currentBtn.IconColor = Color.Black;
                // chỉnh thứ tự chữ và icon về như cũ
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                // canh chỉnh icon trước chữ
                currentBtn.ImageAlign = ContentAlignment.BottomLeft;
            }
        }

        //Medthod: Open frmLogin khi Logout
        private void OpenFrmLogin()
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.ShowDialog();
        }


        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                // cái form trước sẽ bị tắt đi 
                currentChildForm.Close();

            }
            //cấu hình cho child form mới
            currentChildForm = childForm;
            childForm.Dock = DockStyle.Fill;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            PnChildForm.Controls.Add(childForm);
            PnChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            LbControlHeader.Text = childForm.Text;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Thread newThread = new Thread(new ThreadStart(OpenFrmLogin));
            newThread.Start();
            this.Close();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, Color.FromName("Black"));
            OpenChildForm(new FrmStaffOrderProduct()
            {
                FrmStaffDashboard = this
            });
        }

        private void btnMyProfile_Click(object sender, EventArgs e)
        {
            // cấu hình nút khi được click
            ActiveButton(sender, Color.FromName("Black"));
            OpenChildForm(new FrmStaffProfile()
            {
                FrmStaffDashboard = this
            });
        }
    }
}
