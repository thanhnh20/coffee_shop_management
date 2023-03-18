namespace CoffeeManagement
{
    partial class FrmStaffProfile
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
            this.PnInformationStudent = new System.Windows.Forms.Panel();
            this.txtDoB = new System.Windows.Forms.TextBox();
            this.LbDoB = new System.Windows.Forms.Label();
            this.txtTaxCode = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtStaffID = new System.Windows.Forms.TextBox();
            this.txtStaffname = new System.Windows.Forms.TextBox();
            this.LbTaxcode = new System.Windows.Forms.Label();
            this.LbPhoneNumber = new System.Windows.Forms.Label();
            this.lbAddress = new System.Windows.Forms.Label();
            this.LbStaffID = new System.Windows.Forms.Label();
            this.LbStaffNAme = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LbStaffInformation = new System.Windows.Forms.Label();
            this.TblPnHeaderHome = new System.Windows.Forms.TableLayoutPanel();
            this.PnJobHeader = new System.Windows.Forms.Panel();
            this.lbSalaryHeader = new System.Windows.Forms.Label();
            this.LbActiveJobsHeader = new System.Windows.Forms.Label();
            this.PicJobHeader = new FontAwesome.Sharp.IconPictureBox();
            this.PnCompanyHeader = new System.Windows.Forms.Panel();
            this.lbDateJoinHeader = new System.Windows.Forms.Label();
            this.LbCompanyNameHader = new System.Windows.Forms.Label();
            this.PicsStaffHeader = new FontAwesome.Sharp.IconPictureBox();
            this.PnInformationStudent.SuspendLayout();
            this.panel1.SuspendLayout();
            this.TblPnHeaderHome.SuspendLayout();
            this.PnJobHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicJobHeader)).BeginInit();
            this.PnCompanyHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicsStaffHeader)).BeginInit();
            this.SuspendLayout();
            // 
            // PnInformationStudent
            // 
            this.PnInformationStudent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnInformationStudent.BackColor = System.Drawing.Color.White;
            this.PnInformationStudent.Controls.Add(this.txtDoB);
            this.PnInformationStudent.Controls.Add(this.LbDoB);
            this.PnInformationStudent.Controls.Add(this.txtTaxCode);
            this.PnInformationStudent.Controls.Add(this.txtAddress);
            this.PnInformationStudent.Controls.Add(this.txtPhoneNumber);
            this.PnInformationStudent.Controls.Add(this.txtStaffID);
            this.PnInformationStudent.Controls.Add(this.txtStaffname);
            this.PnInformationStudent.Controls.Add(this.LbTaxcode);
            this.PnInformationStudent.Controls.Add(this.LbPhoneNumber);
            this.PnInformationStudent.Controls.Add(this.lbAddress);
            this.PnInformationStudent.Controls.Add(this.LbStaffID);
            this.PnInformationStudent.Controls.Add(this.LbStaffNAme);
            this.PnInformationStudent.Controls.Add(this.panel1);
            this.PnInformationStudent.Location = new System.Drawing.Point(100, 134);
            this.PnInformationStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PnInformationStudent.Name = "PnInformationStudent";
            this.PnInformationStudent.Size = new System.Drawing.Size(757, 196);
            this.PnInformationStudent.TabIndex = 2;
            // 
            // txtDoB
            // 
            this.txtDoB.Enabled = false;
            this.txtDoB.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDoB.Location = new System.Drawing.Point(519, 64);
            this.txtDoB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDoB.Name = "txtDoB";
            this.txtDoB.Size = new System.Drawing.Size(208, 27);
            this.txtDoB.TabIndex = 16;
            // 
            // LbDoB
            // 
            this.LbDoB.AutoSize = true;
            this.LbDoB.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbDoB.Location = new System.Drawing.Point(393, 70);
            this.LbDoB.Name = "LbDoB";
            this.LbDoB.Size = new System.Drawing.Size(100, 19);
            this.LbDoB.TabIndex = 15;
            this.LbDoB.Text = "Date of Birth: ";
            // 
            // txtTaxCode
            // 
            this.txtTaxCode.Enabled = false;
            this.txtTaxCode.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTaxCode.Location = new System.Drawing.Point(521, 131);
            this.txtTaxCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTaxCode.Name = "txtTaxCode";
            this.txtTaxCode.Size = new System.Drawing.Size(206, 27);
            this.txtTaxCode.TabIndex = 14;
            // 
            // txtAddress
            // 
            this.txtAddress.Enabled = false;
            this.txtAddress.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAddress.Location = new System.Drawing.Point(160, 135);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(208, 27);
            this.txtAddress.TabIndex = 13;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Enabled = false;
            this.txtPhoneNumber.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPhoneNumber.Location = new System.Drawing.Point(519, 98);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(208, 27);
            this.txtPhoneNumber.TabIndex = 11;
            // 
            // txtStaffID
            // 
            this.txtStaffID.Enabled = false;
            this.txtStaffID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtStaffID.Location = new System.Drawing.Point(160, 98);
            this.txtStaffID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStaffID.Name = "txtStaffID";
            this.txtStaffID.Size = new System.Drawing.Size(208, 27);
            this.txtStaffID.TabIndex = 10;
            // 
            // txtStaffname
            // 
            this.txtStaffname.Enabled = false;
            this.txtStaffname.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtStaffname.Location = new System.Drawing.Point(160, 64);
            this.txtStaffname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStaffname.Name = "txtStaffname";
            this.txtStaffname.Size = new System.Drawing.Size(208, 27);
            this.txtStaffname.TabIndex = 9;
            // 
            // LbTaxcode
            // 
            this.LbTaxcode.AutoSize = true;
            this.LbTaxcode.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbTaxcode.Location = new System.Drawing.Point(393, 137);
            this.LbTaxcode.Name = "LbTaxcode";
            this.LbTaxcode.Size = new System.Drawing.Size(76, 19);
            this.LbTaxcode.TabIndex = 7;
            this.LbTaxcode.Text = "Tax Code: ";
            // 
            // LbPhoneNumber
            // 
            this.LbPhoneNumber.AutoSize = true;
            this.LbPhoneNumber.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbPhoneNumber.Location = new System.Drawing.Point(393, 104);
            this.LbPhoneNumber.Name = "LbPhoneNumber";
            this.LbPhoneNumber.Size = new System.Drawing.Size(112, 19);
            this.LbPhoneNumber.TabIndex = 6;
            this.LbPhoneNumber.Text = "Phone Number: ";
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbAddress.Location = new System.Drawing.Point(34, 141);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(65, 19);
            this.lbAddress.TabIndex = 5;
            this.lbAddress.Text = "Address:";
            // 
            // LbStaffID
            // 
            this.LbStaffID.AutoSize = true;
            this.LbStaffID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbStaffID.Location = new System.Drawing.Point(34, 104);
            this.LbStaffID.Name = "LbStaffID";
            this.LbStaffID.Size = new System.Drawing.Size(64, 19);
            this.LbStaffID.TabIndex = 3;
            this.LbStaffID.Text = "Staff ID: ";
            // 
            // LbStaffNAme
            // 
            this.LbStaffNAme.AutoSize = true;
            this.LbStaffNAme.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbStaffNAme.Location = new System.Drawing.Point(34, 71);
            this.LbStaffNAme.Name = "LbStaffNAme";
            this.LbStaffNAme.Size = new System.Drawing.Size(86, 19);
            this.LbStaffNAme.TabIndex = 2;
            this.LbStaffNAme.Text = "Staff name: ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.LbStaffInformation);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(757, 49);
            this.panel1.TabIndex = 1;
            // 
            // LbStaffInformation
            // 
            this.LbStaffInformation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LbStaffInformation.AutoSize = true;
            this.LbStaffInformation.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbStaffInformation.ForeColor = System.Drawing.Color.White;
            this.LbStaffInformation.Location = new System.Drawing.Point(279, 10);
            this.LbStaffInformation.Name = "LbStaffInformation";
            this.LbStaffInformation.Size = new System.Drawing.Size(179, 29);
            this.LbStaffInformation.TabIndex = 0;
            this.LbStaffInformation.Text = "Staff Information";
            // 
            // TblPnHeaderHome
            // 
            this.TblPnHeaderHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TblPnHeaderHome.ColumnCount = 2;
            this.TblPnHeaderHome.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TblPnHeaderHome.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TblPnHeaderHome.Controls.Add(this.PnJobHeader, 1, 0);
            this.TblPnHeaderHome.Controls.Add(this.PnCompanyHeader);
            this.TblPnHeaderHome.Location = new System.Drawing.Point(210, 38);
            this.TblPnHeaderHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TblPnHeaderHome.Name = "TblPnHeaderHome";
            this.TblPnHeaderHome.RowCount = 1;
            this.TblPnHeaderHome.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TblPnHeaderHome.Size = new System.Drawing.Size(543, 82);
            this.TblPnHeaderHome.TabIndex = 3;
            // 
            // PnJobHeader
            // 
            this.PnJobHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.PnJobHeader.Controls.Add(this.lbSalaryHeader);
            this.PnJobHeader.Controls.Add(this.LbActiveJobsHeader);
            this.PnJobHeader.Controls.Add(this.PicJobHeader);
            this.PnJobHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnJobHeader.Location = new System.Drawing.Point(274, 2);
            this.PnJobHeader.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PnJobHeader.Name = "PnJobHeader";
            this.PnJobHeader.Size = new System.Drawing.Size(266, 78);
            this.PnJobHeader.TabIndex = 2;
            // 
            // lbSalaryHeader
            // 
            this.lbSalaryHeader.AutoSize = true;
            this.lbSalaryHeader.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbSalaryHeader.ForeColor = System.Drawing.Color.White;
            this.lbSalaryHeader.Location = new System.Drawing.Point(135, 42);
            this.lbSalaryHeader.Name = "lbSalaryHeader";
            this.lbSalaryHeader.Size = new System.Drawing.Size(54, 18);
            this.lbSalaryHeader.TabIndex = 4;
            this.lbSalaryHeader.Text = "100.000";
            // 
            // LbActiveJobsHeader
            // 
            this.LbActiveJobsHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LbActiveJobsHeader.AutoSize = true;
            this.LbActiveJobsHeader.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbActiveJobsHeader.ForeColor = System.Drawing.Color.White;
            this.LbActiveJobsHeader.Location = new System.Drawing.Point(134, 10);
            this.LbActiveJobsHeader.Name = "LbActiveJobsHeader";
            this.LbActiveJobsHeader.Size = new System.Drawing.Size(48, 19);
            this.LbActiveJobsHeader.TabIndex = 3;
            this.LbActiveJobsHeader.Text = "Salary";
            // 
            // PicJobHeader
            // 
            this.PicJobHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.PicJobHeader.IconChar = FontAwesome.Sharp.IconChar.MoneyBill;
            this.PicJobHeader.IconColor = System.Drawing.Color.White;
            this.PicJobHeader.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.PicJobHeader.IconSize = 30;
            this.PicJobHeader.Location = new System.Drawing.Point(43, 27);
            this.PicJobHeader.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PicJobHeader.Name = "PicJobHeader";
            this.PicJobHeader.Size = new System.Drawing.Size(35, 30);
            this.PicJobHeader.TabIndex = 0;
            this.PicJobHeader.TabStop = false;
            // 
            // PnCompanyHeader
            // 
            this.PnCompanyHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
            this.PnCompanyHeader.Controls.Add(this.lbDateJoinHeader);
            this.PnCompanyHeader.Controls.Add(this.LbCompanyNameHader);
            this.PnCompanyHeader.Controls.Add(this.PicsStaffHeader);
            this.PnCompanyHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnCompanyHeader.Location = new System.Drawing.Point(3, 2);
            this.PnCompanyHeader.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PnCompanyHeader.Name = "PnCompanyHeader";
            this.PnCompanyHeader.Size = new System.Drawing.Size(265, 78);
            this.PnCompanyHeader.TabIndex = 1;
            // 
            // lbDateJoinHeader
            // 
            this.lbDateJoinHeader.AutoSize = true;
            this.lbDateJoinHeader.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbDateJoinHeader.ForeColor = System.Drawing.Color.White;
            this.lbDateJoinHeader.Location = new System.Drawing.Point(119, 42);
            this.lbDateJoinHeader.Name = "lbDateJoinHeader";
            this.lbDateJoinHeader.Size = new System.Drawing.Size(69, 18);
            this.lbDateJoinHeader.TabIndex = 5;
            this.lbDateJoinHeader.Text = "3/13/2023";
            // 
            // LbCompanyNameHader
            // 
            this.LbCompanyNameHader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LbCompanyNameHader.AutoSize = true;
            this.LbCompanyNameHader.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbCompanyNameHader.ForeColor = System.Drawing.Color.White;
            this.LbCompanyNameHader.Location = new System.Drawing.Point(119, 11);
            this.LbCompanyNameHader.Name = "LbCompanyNameHader";
            this.LbCompanyNameHader.Size = new System.Drawing.Size(69, 19);
            this.LbCompanyNameHader.TabIndex = 1;
            this.LbCompanyNameHader.Text = "Date Join";
            // 
            // PicsStaffHeader
            // 
            this.PicsStaffHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PicsStaffHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
            this.PicsStaffHeader.IconChar = FontAwesome.Sharp.IconChar.CalendarDay;
            this.PicsStaffHeader.IconColor = System.Drawing.Color.White;
            this.PicsStaffHeader.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.PicsStaffHeader.IconSize = 30;
            this.PicsStaffHeader.Location = new System.Drawing.Point(28, 29);
            this.PicsStaffHeader.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PicsStaffHeader.Name = "PicsStaffHeader";
            this.PicsStaffHeader.Size = new System.Drawing.Size(39, 30);
            this.PicsStaffHeader.TabIndex = 0;
            this.PicsStaffHeader.TabStop = false;
            // 
            // FrmStaffProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 459);
            this.Controls.Add(this.TblPnHeaderHome);
            this.Controls.Add(this.PnInformationStudent);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(1052, 535);
            this.MinimumSize = new System.Drawing.Size(974, 498);
            this.Name = "FrmStaffProfile";
            this.Text = "Staff Information";
            this.PnInformationStudent.ResumeLayout(false);
            this.PnInformationStudent.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.TblPnHeaderHome.ResumeLayout(false);
            this.PnJobHeader.ResumeLayout(false);
            this.PnJobHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicJobHeader)).EndInit();
            this.PnCompanyHeader.ResumeLayout(false);
            this.PnCompanyHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicsStaffHeader)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnInformationStudent;
        private System.Windows.Forms.TextBox txtTaxCode;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtStaffID;
        private System.Windows.Forms.TextBox txtStaffname;
        private System.Windows.Forms.Label LbTaxcode;
        private System.Windows.Forms.Label LbPhoneNumber;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.Label LbStaffID;
        private System.Windows.Forms.Label LbStaffNAme;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LbStaffInformation;
        private System.Windows.Forms.TextBox txtDoB;
        private System.Windows.Forms.Label LbDoB;
        private System.Windows.Forms.TableLayoutPanel TblPnHeaderHome;
        private System.Windows.Forms.Panel PnJobHeader;
        private System.Windows.Forms.Label LbActiveJobsHeader;
        private FontAwesome.Sharp.IconPictureBox PicJobHeader;
        private System.Windows.Forms.Panel PnCompanyHeader;
        private System.Windows.Forms.Label LbCompanyNameHader;
        private FontAwesome.Sharp.IconPictureBox PicsStaffHeader;
        private System.Windows.Forms.Label lbSalaryHeader;
        private System.Windows.Forms.Label lbDateJoinHeader;
    }
}