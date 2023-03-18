namespace CoffeeManagement
{
    partial class FrmStaffDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PnDashBoard = new System.Windows.Forms.Panel();
            this.btnLogout = new FontAwesome.Sharp.IconButton();
            this.btnCustomer = new FontAwesome.Sharp.IconButton();
            this.btnOrder = new FontAwesome.Sharp.IconButton();
            this.btnMyProfile = new FontAwesome.Sharp.IconButton();
            this.PnLogo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PicLogo = new System.Windows.Forms.PictureBox();
            this.PnHeader = new System.Windows.Forms.Panel();
            this.PicIconControlHeader = new FontAwesome.Sharp.IconPictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LbWelcomeHeader = new System.Windows.Forms.Label();
            this.LbControlHeader = new System.Windows.Forms.Label();
            this.PnChildForm = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.PnDashBoard.SuspendLayout();
            this.PnLogo.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).BeginInit();
            this.PnHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicIconControlHeader)).BeginInit();
            this.SuspendLayout();
            // 
            // PnDashBoard
            // 
            this.PnDashBoard.BackColor = System.Drawing.Color.LemonChiffon;
            this.PnDashBoard.Controls.Add(this.btnLogout);
            this.PnDashBoard.Controls.Add(this.btnCustomer);
            this.PnDashBoard.Controls.Add(this.btnOrder);
            this.PnDashBoard.Controls.Add(this.btnMyProfile);
            this.PnDashBoard.Controls.Add(this.PnLogo);
            this.PnDashBoard.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnDashBoard.Location = new System.Drawing.Point(0, 0);
            this.PnDashBoard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PnDashBoard.Name = "PnDashBoard";
            this.PnDashBoard.Size = new System.Drawing.Size(219, 525);
            this.PnDashBoard.TabIndex = 5;
            // 
            // btnLogout
            // 
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogout.ForeColor = System.Drawing.Color.Black;
            this.btnLogout.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnLogout.IconColor = System.Drawing.Color.Black;
            this.btnLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 259);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(9, 0, 18, 0);
            this.btnLogout.Size = new System.Drawing.Size(219, 49);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "Log out";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCustomer.FlatAppearance.BorderSize = 0;
            this.btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomer.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCustomer.ForeColor = System.Drawing.Color.Black;
            this.btnCustomer.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            this.btnCustomer.IconColor = System.Drawing.Color.Black;
            this.btnCustomer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomer.Location = new System.Drawing.Point(0, 210);
            this.btnCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Padding = new System.Windows.Forms.Padding(9, 0, 18, 0);
            this.btnCustomer.Size = new System.Drawing.Size(219, 49);
            this.btnCustomer.TabIndex = 9;
            this.btnCustomer.Text = "Customer";
            this.btnCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOrder.FlatAppearance.BorderSize = 0;
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOrder.ForeColor = System.Drawing.Color.Black;
            this.btnOrder.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            this.btnOrder.IconColor = System.Drawing.Color.Black;
            this.btnOrder.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrder.Location = new System.Drawing.Point(0, 161);
            this.btnOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Padding = new System.Windows.Forms.Padding(9, 0, 18, 0);
            this.btnOrder.Size = new System.Drawing.Size(219, 49);
            this.btnOrder.TabIndex = 5;
            this.btnOrder.Text = "Order";
            this.btnOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnMyProfile
            // 
            this.btnMyProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMyProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMyProfile.FlatAppearance.BorderSize = 0;
            this.btnMyProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyProfile.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMyProfile.ForeColor = System.Drawing.Color.Black;
            this.btnMyProfile.IconChar = FontAwesome.Sharp.IconChar.IdCard;
            this.btnMyProfile.IconColor = System.Drawing.Color.Black;
            this.btnMyProfile.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMyProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMyProfile.Location = new System.Drawing.Point(0, 112);
            this.btnMyProfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMyProfile.Name = "btnMyProfile";
            this.btnMyProfile.Padding = new System.Windows.Forms.Padding(9, 0, 18, 0);
            this.btnMyProfile.Size = new System.Drawing.Size(219, 49);
            this.btnMyProfile.TabIndex = 2;
            this.btnMyProfile.Text = "My Profile";
            this.btnMyProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMyProfile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMyProfile.UseVisualStyleBackColor = true;
            this.btnMyProfile.Click += new System.EventHandler(this.btnMyProfile_Click);
            // 
            // PnLogo
            // 
            this.PnLogo.BackColor = System.Drawing.Color.Khaki;
            this.PnLogo.Controls.Add(this.panel1);
            this.PnLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnLogo.Location = new System.Drawing.Point(0, 0);
            this.PnLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PnLogo.Name = "PnLogo";
            this.PnLogo.Size = new System.Drawing.Size(219, 112);
            this.PnLogo.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Khaki;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.PicLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 112);
            this.panel1.TabIndex = 1;
            // 
            // label3
            // 
            /*
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(78, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 74);
            this.label3.TabIndex = 1;
            this.label3.Text = "Camasy Cafe \r\n   Manager";*/
            // 
            // PicLogo
            // 
            this.PicLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicLogo.Image = global::CoffeeManagement.Properties.Resources.cafe_11;
            this.PicLogo.InitialImage = null;
            this.PicLogo.Location = new System.Drawing.Point(3, 33);
            this.PicLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PicLogo.Name = "PicLogo";
            this.PicLogo.Size = new System.Drawing.Size(72, 54);
            this.PicLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicLogo.TabIndex = 0;
            this.PicLogo.TabStop = false;
            // 
            // PnHeader
            // 
            this.PnHeader.BackColor = System.Drawing.Color.LightSlateGray;
            this.PnHeader.Controls.Add(this.PicIconControlHeader);
            this.PnHeader.Controls.Add(this.label2);
            this.PnHeader.Controls.Add(this.label1);
            this.PnHeader.Controls.Add(this.LbWelcomeHeader);
            this.PnHeader.Controls.Add(this.LbControlHeader);
            this.PnHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnHeader.Location = new System.Drawing.Point(219, 0);
            this.PnHeader.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PnHeader.Name = "PnHeader";
            this.PnHeader.Size = new System.Drawing.Size(931, 44);
            this.PnHeader.TabIndex = 6;
            // 
            // PicIconControlHeader
            // 
            this.PicIconControlHeader.BackColor = System.Drawing.Color.LightSlateGray;
            this.PicIconControlHeader.ForeColor = System.Drawing.Color.Black;
            this.PicIconControlHeader.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.PicIconControlHeader.IconColor = System.Drawing.Color.Black;
            this.PicIconControlHeader.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.PicIconControlHeader.IconSize = 30;
            this.PicIconControlHeader.Location = new System.Drawing.Point(17, 12);
            this.PicIconControlHeader.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PicIconControlHeader.Name = "PicIconControlHeader";
            this.PicIconControlHeader.Size = new System.Drawing.Size(35, 30);
            this.PicIconControlHeader.TabIndex = 8;
            this.PicIconControlHeader.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(871, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "STAFF";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(1518, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Welcome, Full Name";
            // 
            // LbWelcomeHeader
            // 
            this.LbWelcomeHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LbWelcomeHeader.AutoSize = true;
            this.LbWelcomeHeader.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbWelcomeHeader.Location = new System.Drawing.Point(2386, 14);
            this.LbWelcomeHeader.Name = "LbWelcomeHeader";
            this.LbWelcomeHeader.Size = new System.Drawing.Size(142, 19);
            this.LbWelcomeHeader.TabIndex = 3;
            this.LbWelcomeHeader.Text = "Welcome, Full Name";
            // 
            // LbControlHeader
            // 
            this.LbControlHeader.AutoSize = true;
            this.LbControlHeader.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbControlHeader.Location = new System.Drawing.Point(57, 16);
            this.LbControlHeader.Name = "LbControlHeader";
            this.LbControlHeader.Size = new System.Drawing.Size(47, 19);
            this.LbControlHeader.TabIndex = 1;
            this.LbControlHeader.Text = "Home";
            // 
            // PnChildForm
            // 
            this.PnChildForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PnChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnChildForm.Location = new System.Drawing.Point(219, 44);
            this.PnChildForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PnChildForm.Name = "PnChildForm";
            this.PnChildForm.Size = new System.Drawing.Size(931, 481);
            this.PnChildForm.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(71, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 61);
            this.label4.TabIndex = 2;
            this.label4.Text = "Camasy Cafe Manager";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FrmStaffDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 525);
            this.Controls.Add(this.PnChildForm);
            this.Controls.Add(this.PnHeader);
            this.Controls.Add(this.PnDashBoard);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmStaffDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Staff Dashboard";
            this.PnDashBoard.ResumeLayout(false);
            this.PnLogo.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).EndInit();
            this.PnHeader.ResumeLayout(false);
            this.PnHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicIconControlHeader)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnDashBoard;
        private FontAwesome.Sharp.IconButton btnCustomer;
        private FontAwesome.Sharp.IconButton btnMyProfile;
        private System.Windows.Forms.Panel PnHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LbWelcomeHeader;
        private System.Windows.Forms.Label LbControlHeader;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconPictureBox PicIconControlHeader;
        private System.Windows.Forms.Panel PnChildForm;
        private FontAwesome.Sharp.IconButton btnOrder;
        private System.Windows.Forms.Panel PnLogo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox PicLogo;
        private FontAwesome.Sharp.IconButton btnLogout;
        private System.Windows.Forms.Label label4;
    }
}