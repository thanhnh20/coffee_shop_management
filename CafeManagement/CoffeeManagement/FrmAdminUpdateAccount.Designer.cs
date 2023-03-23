namespace CoffeeManagement
{
    partial class FrmAdminUpdateAccount
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
            this.PnHeader = new System.Windows.Forms.Panel();
            this.LbHeader = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.PnControls = new System.Windows.Forms.Panel();
            this.BtnUpdateAccount = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.PnLayout1 = new System.Windows.Forms.Panel();
            this.lbConfirmPassword = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.lbStatus = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.LbFullName = new System.Windows.Forms.Label();
            this.LbPhonenumber = new System.Windows.Forms.Label();
            this.LbDateOfBirth = new System.Windows.Forms.Label();
            this.LbSalary = new System.Windows.Forms.Label();
            this.LbTaxCode = new System.Windows.Forms.Label();
            this.LbAddress = new System.Windows.Forms.Label();
            this.TxtFullName = new System.Windows.Forms.TextBox();
            this.TxtPhoneNumber = new System.Windows.Forms.TextBox();
            this.TxtTaxCode = new System.Windows.Forms.TextBox();
            this.TxtAddress = new System.Windows.Forms.TextBox();
            this.MtxtDateOfBirth = new System.Windows.Forms.MaskedTextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.PnInformation = new System.Windows.Forms.Panel();
            this.MtxtDateJoin = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PnHeader.SuspendLayout();
            this.PnControls.SuspendLayout();
            this.PnInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnHeader
            // 
            this.PnHeader.Controls.Add(this.LbHeader);
            this.PnHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnHeader.Location = new System.Drawing.Point(0, 0);
            this.PnHeader.Name = "PnHeader";
            this.PnHeader.Size = new System.Drawing.Size(584, 77);
            this.PnHeader.TabIndex = 3;
            // 
            // LbHeader
            // 
            this.LbHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LbHeader.AutoSize = true;
            this.LbHeader.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbHeader.ForeColor = System.Drawing.Color.Orange;
            this.LbHeader.Location = new System.Drawing.Point(170, 12);
            this.LbHeader.Name = "LbHeader";
            this.LbHeader.Size = new System.Drawing.Size(261, 45);
            this.LbHeader.TabIndex = 0;
            this.LbHeader.Text = "Update Account";
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbUsername.Location = new System.Drawing.Point(64, 364);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(100, 24);
            this.lbUsername.TabIndex = 6;
            this.lbUsername.Text = "Username:";
            // 
            // txtUsername
            // 
            this.txtUsername.Enabled = false;
            this.txtUsername.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUsername.Location = new System.Drawing.Point(232, 360);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.ReadOnly = true;
            this.txtUsername.Size = new System.Drawing.Size(183, 32);
            this.txtUsername.TabIndex = 1;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbPassword.Location = new System.Drawing.Point(64, 412);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(94, 24);
            this.lbPassword.TabIndex = 8;
            this.lbPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPassword.Location = new System.Drawing.Point(232, 401);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(183, 32);
            this.txtPassword.TabIndex = 2;
            // 
            // PnControls
            // 
            this.PnControls.Controls.Add(this.BtnUpdateAccount);
            this.PnControls.Controls.Add(this.BtnCancel);
            this.PnControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnControls.Location = new System.Drawing.Point(0, 533);
            this.PnControls.Name = "PnControls";
            this.PnControls.Size = new System.Drawing.Size(584, 83);
            this.PnControls.TabIndex = 10;
            // 
            // BtnUpdateAccount
            // 
            this.BtnUpdateAccount.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnUpdateAccount.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnUpdateAccount.Location = new System.Drawing.Point(344, 21);
            this.BtnUpdateAccount.Name = "BtnUpdateAccount";
            this.BtnUpdateAccount.Size = new System.Drawing.Size(162, 39);
            this.BtnUpdateAccount.TabIndex = 6;
            this.BtnUpdateAccount.Text = "Update";
            this.BtnUpdateAccount.UseVisualStyleBackColor = true;
            this.BtnUpdateAccount.Click += new System.EventHandler(this.BtnUpdateAccount_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnCancel.Location = new System.Drawing.Point(71, 21);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(162, 39);
            this.BtnCancel.TabIndex = 5;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // PnLayout1
            // 
            this.PnLayout1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(113)))), ((int)(((byte)(36)))));
            this.PnLayout1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnLayout1.Location = new System.Drawing.Point(0, 532);
            this.PnLayout1.Name = "PnLayout1";
            this.PnLayout1.Size = new System.Drawing.Size(584, 1);
            this.PnLayout1.TabIndex = 11;
            // 
            // lbConfirmPassword
            // 
            this.lbConfirmPassword.AutoSize = true;
            this.lbConfirmPassword.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbConfirmPassword.Location = new System.Drawing.Point(64, 447);
            this.lbConfirmPassword.Name = "lbConfirmPassword";
            this.lbConfirmPassword.Size = new System.Drawing.Size(166, 24);
            this.lbConfirmPassword.TabIndex = 19;
            this.lbConfirmPassword.Text = "Confirm Password:";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtConfirmPassword.Location = new System.Drawing.Point(232, 443);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(183, 32);
            this.txtConfirmPassword.TabIndex = 3;
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbStatus.Location = new System.Drawing.Point(64, 488);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(67, 24);
            this.lbStatus.TabIndex = 21;
            this.lbStatus.Text = "Status:";
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(232, 484);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(183, 32);
            this.cbStatus.TabIndex = 4;
            // 
            // LbFullName
            // 
            this.LbFullName.AutoSize = true;
            this.LbFullName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbFullName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LbFullName.Location = new System.Drawing.Point(64, 9);
            this.LbFullName.Name = "LbFullName";
            this.LbFullName.Size = new System.Drawing.Size(104, 24);
            this.LbFullName.TabIndex = 26;
            this.LbFullName.Text = "Full Name: ";
            // 
            // LbPhonenumber
            // 
            this.LbPhonenumber.AutoSize = true;
            this.LbPhonenumber.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbPhonenumber.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LbPhonenumber.Location = new System.Drawing.Point(64, 92);
            this.LbPhonenumber.Name = "LbPhonenumber";
            this.LbPhonenumber.Size = new System.Drawing.Size(146, 24);
            this.LbPhonenumber.TabIndex = 28;
            this.LbPhonenumber.Text = "Phone Number: ";
            // 
            // LbDateOfBirth
            // 
            this.LbDateOfBirth.AutoSize = true;
            this.LbDateOfBirth.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbDateOfBirth.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LbDateOfBirth.Location = new System.Drawing.Point(64, 216);
            this.LbDateOfBirth.Name = "LbDateOfBirth";
            this.LbDateOfBirth.Size = new System.Drawing.Size(127, 24);
            this.LbDateOfBirth.TabIndex = 29;
            this.LbDateOfBirth.Text = "Date of Birth: ";
            // 
            // LbSalary
            // 
            this.LbSalary.AutoSize = true;
            this.LbSalary.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbSalary.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LbSalary.Location = new System.Drawing.Point(64, 175);
            this.LbSalary.Name = "LbSalary";
            this.LbSalary.Size = new System.Drawing.Size(65, 24);
            this.LbSalary.TabIndex = 30;
            this.LbSalary.Text = "Salary:";
            // 
            // LbTaxCode
            // 
            this.LbTaxCode.AutoSize = true;
            this.LbTaxCode.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbTaxCode.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LbTaxCode.Location = new System.Drawing.Point(64, 133);
            this.LbTaxCode.Name = "LbTaxCode";
            this.LbTaxCode.Size = new System.Drawing.Size(95, 24);
            this.LbTaxCode.TabIndex = 31;
            this.LbTaxCode.Text = "Tax Code: ";
            // 
            // LbAddress
            // 
            this.LbAddress.AutoSize = true;
            this.LbAddress.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbAddress.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LbAddress.Location = new System.Drawing.Point(64, 291);
            this.LbAddress.Name = "LbAddress";
            this.LbAddress.Size = new System.Drawing.Size(87, 24);
            this.LbAddress.TabIndex = 32;
            this.LbAddress.Text = "Address: ";
            // 
            // TxtFullName
            // 
            this.TxtFullName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtFullName.Location = new System.Drawing.Point(232, 5);
            this.TxtFullName.Name = "TxtFullName";
            this.TxtFullName.Size = new System.Drawing.Size(284, 32);
            this.TxtFullName.TabIndex = 33;
            // 
            // TxtPhoneNumber
            // 
            this.TxtPhoneNumber.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtPhoneNumber.Location = new System.Drawing.Point(232, 88);
            this.TxtPhoneNumber.MaxLength = 10;
            this.TxtPhoneNumber.Name = "TxtPhoneNumber";
            this.TxtPhoneNumber.Size = new System.Drawing.Size(183, 32);
            this.TxtPhoneNumber.TabIndex = 35;
            // 
            // TxtTaxCode
            // 
            this.TxtTaxCode.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtTaxCode.Location = new System.Drawing.Point(232, 129);
            this.TxtTaxCode.MaxLength = 1;
            this.TxtTaxCode.Name = "TxtTaxCode";
            this.TxtTaxCode.Size = new System.Drawing.Size(183, 32);
            this.TxtTaxCode.TabIndex = 36;
            // 
            // TxtAddress
            // 
            this.TxtAddress.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtAddress.Location = new System.Drawing.Point(232, 253);
            this.TxtAddress.Multiline = true;
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.Size = new System.Drawing.Size(284, 100);
            this.TxtAddress.TabIndex = 39;
            // 
            // MtxtDateOfBirth
            // 
            this.MtxtDateOfBirth.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MtxtDateOfBirth.Location = new System.Drawing.Point(232, 212);
            this.MtxtDateOfBirth.Mask = "00/00/0000";
            this.MtxtDateOfBirth.Name = "MtxtDateOfBirth";
            this.MtxtDateOfBirth.Size = new System.Drawing.Size(183, 32);
            this.MtxtDateOfBirth.TabIndex = 38;
            this.MtxtDateOfBirth.ValidatingType = typeof(System.DateTime);
            // 
            // txtSalary
            // 
            this.txtSalary.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSalary.Location = new System.Drawing.Point(232, 171);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(284, 32);
            this.txtSalary.TabIndex = 37;
            // 
            // PnInformation
            // 
            this.PnInformation.Controls.Add(this.MtxtDateJoin);
            this.PnInformation.Controls.Add(this.label1);
            this.PnInformation.Controls.Add(this.txtSalary);
            this.PnInformation.Controls.Add(this.MtxtDateOfBirth);
            this.PnInformation.Controls.Add(this.TxtAddress);
            this.PnInformation.Controls.Add(this.TxtTaxCode);
            this.PnInformation.Controls.Add(this.TxtPhoneNumber);
            this.PnInformation.Controls.Add(this.TxtFullName);
            this.PnInformation.Controls.Add(this.LbAddress);
            this.PnInformation.Controls.Add(this.LbTaxCode);
            this.PnInformation.Controls.Add(this.LbSalary);
            this.PnInformation.Controls.Add(this.LbDateOfBirth);
            this.PnInformation.Controls.Add(this.LbPhonenumber);
            this.PnInformation.Controls.Add(this.LbFullName);
            this.PnInformation.Controls.Add(this.cbStatus);
            this.PnInformation.Controls.Add(this.lbStatus);
            this.PnInformation.Controls.Add(this.txtConfirmPassword);
            this.PnInformation.Controls.Add(this.lbConfirmPassword);
            this.PnInformation.Controls.Add(this.PnLayout1);
            this.PnInformation.Controls.Add(this.PnControls);
            this.PnInformation.Controls.Add(this.txtPassword);
            this.PnInformation.Controls.Add(this.lbPassword);
            this.PnInformation.Controls.Add(this.txtUsername);
            this.PnInformation.Controls.Add(this.lbUsername);
            this.PnInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnInformation.Location = new System.Drawing.Point(0, 77);
            this.PnInformation.Name = "PnInformation";
            this.PnInformation.Size = new System.Drawing.Size(584, 616);
            this.PnInformation.TabIndex = 5;
            // 
            // MtxtDateJoin
            // 
            this.MtxtDateJoin.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MtxtDateJoin.Location = new System.Drawing.Point(232, 47);
            this.MtxtDateJoin.Mask = "00/00/0000";
            this.MtxtDateJoin.Name = "MtxtDateJoin";
            this.MtxtDateJoin.Size = new System.Drawing.Size(183, 32);
            this.MtxtDateJoin.TabIndex = 34;
            this.MtxtDateJoin.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(64, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 24);
            this.label1.TabIndex = 40;
            this.label1.Text = "Date Join";
            // 
            // FrmAdminUpdateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 693);
            this.Controls.Add(this.PnInformation);
            this.Controls.Add(this.PnHeader);
            this.Name = "FrmAdminUpdateAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Update Existing Account";
            this.PnHeader.ResumeLayout(false);
            this.PnHeader.PerformLayout();
            this.PnControls.ResumeLayout(false);
            this.PnInformation.ResumeLayout(false);
            this.PnInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnHeader;
        private System.Windows.Forms.Label LbHeader;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Panel PnControls;
        private System.Windows.Forms.Button BtnUpdateAccount;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Panel PnLayout1;
        private System.Windows.Forms.Label lbConfirmPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label LbFullName;
        private System.Windows.Forms.Label LbPhonenumber;
        private System.Windows.Forms.Label LbDateOfBirth;
        private System.Windows.Forms.Label LbSalary;
        private System.Windows.Forms.Label LbTaxCode;
        private System.Windows.Forms.Label LbAddress;
        private System.Windows.Forms.TextBox TxtFullName;
        private System.Windows.Forms.TextBox TxtPhoneNumber;
        private System.Windows.Forms.TextBox TxtTaxCode;
        private System.Windows.Forms.TextBox TxtAddress;
        private System.Windows.Forms.MaskedTextBox MtxtDateOfBirth;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Panel PnInformation;
        private System.Windows.Forms.MaskedTextBox MtxtDateJoin;
        private System.Windows.Forms.Label label1;
    }
}