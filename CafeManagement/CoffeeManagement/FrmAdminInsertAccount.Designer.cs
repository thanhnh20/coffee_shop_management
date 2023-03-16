namespace CoffeeManagement
{
    partial class FrmAdminInsertAccount
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
            this.BtnCreateAccount = new System.Windows.Forms.Button();
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
            this.PnHeader.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PnHeader.Name = "PnHeader";
            this.PnHeader.Size = new System.Drawing.Size(511, 58);
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
            this.LbHeader.Location = new System.Drawing.Point(86, 9);
            this.LbHeader.Name = "LbHeader";
            this.LbHeader.Size = new System.Drawing.Size(345, 37);
            this.LbHeader.TabIndex = 0;
            this.LbHeader.Text = "Insert A New Staff Account";
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbUsername.Location = new System.Drawing.Point(56, 273);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(79, 19);
            this.lbUsername.TabIndex = 6;
            this.lbUsername.Text = "Username:";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUsername.Location = new System.Drawing.Point(203, 270);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(161, 27);
            this.txtUsername.TabIndex = 1;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbPassword.Location = new System.Drawing.Point(56, 309);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(75, 19);
            this.lbPassword.TabIndex = 8;
            this.lbPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPassword.Location = new System.Drawing.Point(203, 301);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(161, 27);
            this.txtPassword.TabIndex = 2;
            // 
            // PnControls
            // 
            this.PnControls.Controls.Add(this.BtnCreateAccount);
            this.PnControls.Controls.Add(this.BtnCancel);
            this.PnControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnControls.Location = new System.Drawing.Point(0, 400);
            this.PnControls.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PnControls.Name = "PnControls";
            this.PnControls.Size = new System.Drawing.Size(511, 62);
            this.PnControls.TabIndex = 10;
            // 
            // BtnCreateAccount
            // 
            this.BtnCreateAccount.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCreateAccount.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnCreateAccount.Location = new System.Drawing.Point(301, 16);
            this.BtnCreateAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnCreateAccount.Name = "BtnCreateAccount";
            this.BtnCreateAccount.Size = new System.Drawing.Size(142, 29);
            this.BtnCreateAccount.TabIndex = 6;
            this.BtnCreateAccount.Text = "Insert";
            this.BtnCreateAccount.UseVisualStyleBackColor = true;
            this.BtnCreateAccount.Click += new System.EventHandler(this.BtnCreateAccount_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnCancel.Location = new System.Drawing.Point(62, 16);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(142, 29);
            this.BtnCancel.TabIndex = 5;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // PnLayout1
            // 
            this.PnLayout1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(113)))), ((int)(((byte)(36)))));
            this.PnLayout1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnLayout1.Location = new System.Drawing.Point(0, 399);
            this.PnLayout1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PnLayout1.Name = "PnLayout1";
            this.PnLayout1.Size = new System.Drawing.Size(511, 1);
            this.PnLayout1.TabIndex = 11;
            // 
            // lbConfirmPassword
            // 
            this.lbConfirmPassword.AutoSize = true;
            this.lbConfirmPassword.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbConfirmPassword.Location = new System.Drawing.Point(56, 335);
            this.lbConfirmPassword.Name = "lbConfirmPassword";
            this.lbConfirmPassword.Size = new System.Drawing.Size(129, 19);
            this.lbConfirmPassword.TabIndex = 19;
            this.lbConfirmPassword.Text = "Confirm Password:";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtConfirmPassword.Location = new System.Drawing.Point(203, 332);
            this.txtConfirmPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(161, 27);
            this.txtConfirmPassword.TabIndex = 3;
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbStatus.Location = new System.Drawing.Point(56, 366);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(53, 19);
            this.lbStatus.TabIndex = 21;
            this.lbStatus.Text = "Status:";
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(203, 363);
            this.cbStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(161, 27);
            this.cbStatus.TabIndex = 4;
            // 
            // LbFullName
            // 
            this.LbFullName.AutoSize = true;
            this.LbFullName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbFullName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LbFullName.Location = new System.Drawing.Point(56, 7);
            this.LbFullName.Name = "LbFullName";
            this.LbFullName.Size = new System.Drawing.Size(82, 19);
            this.LbFullName.TabIndex = 26;
            this.LbFullName.Text = "Full Name: ";
            // 
            // LbPhonenumber
            // 
            this.LbPhonenumber.AutoSize = true;
            this.LbPhonenumber.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbPhonenumber.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LbPhonenumber.Location = new System.Drawing.Point(56, 69);
            this.LbPhonenumber.Name = "LbPhonenumber";
            this.LbPhonenumber.Size = new System.Drawing.Size(112, 19);
            this.LbPhonenumber.TabIndex = 28;
            this.LbPhonenumber.Text = "Phone Number: ";
            // 
            // LbDateOfBirth
            // 
            this.LbDateOfBirth.AutoSize = true;
            this.LbDateOfBirth.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbDateOfBirth.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LbDateOfBirth.Location = new System.Drawing.Point(56, 162);
            this.LbDateOfBirth.Name = "LbDateOfBirth";
            this.LbDateOfBirth.Size = new System.Drawing.Size(100, 19);
            this.LbDateOfBirth.TabIndex = 29;
            this.LbDateOfBirth.Text = "Date of Birth: ";
            // 
            // LbSalary
            // 
            this.LbSalary.AutoSize = true;
            this.LbSalary.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbSalary.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LbSalary.Location = new System.Drawing.Point(56, 131);
            this.LbSalary.Name = "LbSalary";
            this.LbSalary.Size = new System.Drawing.Size(52, 19);
            this.LbSalary.TabIndex = 30;
            this.LbSalary.Text = "Salary:";
            // 
            // LbTaxCode
            // 
            this.LbTaxCode.AutoSize = true;
            this.LbTaxCode.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbTaxCode.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LbTaxCode.Location = new System.Drawing.Point(56, 100);
            this.LbTaxCode.Name = "LbTaxCode";
            this.LbTaxCode.Size = new System.Drawing.Size(76, 19);
            this.LbTaxCode.TabIndex = 31;
            this.LbTaxCode.Text = "Tax Code: ";
            // 
            // LbAddress
            // 
            this.LbAddress.AutoSize = true;
            this.LbAddress.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbAddress.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LbAddress.Location = new System.Drawing.Point(56, 218);
            this.LbAddress.Name = "LbAddress";
            this.LbAddress.Size = new System.Drawing.Size(69, 19);
            this.LbAddress.TabIndex = 32;
            this.LbAddress.Text = "Address: ";
            // 
            // TxtFullName
            // 
            this.TxtFullName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtFullName.Location = new System.Drawing.Point(203, 4);
            this.TxtFullName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtFullName.Name = "TxtFullName";
            this.TxtFullName.Size = new System.Drawing.Size(249, 27);
            this.TxtFullName.TabIndex = 33;
            // 
            // TxtPhoneNumber
            // 
            this.TxtPhoneNumber.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtPhoneNumber.Location = new System.Drawing.Point(203, 66);
            this.TxtPhoneNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtPhoneNumber.MaxLength = 10;
            this.TxtPhoneNumber.Name = "TxtPhoneNumber";
            this.TxtPhoneNumber.Size = new System.Drawing.Size(161, 27);
            this.TxtPhoneNumber.TabIndex = 35;
            // 
            // TxtTaxCode
            // 
            this.TxtTaxCode.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtTaxCode.Location = new System.Drawing.Point(203, 97);
            this.TxtTaxCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtTaxCode.MaxLength = 1;
            this.TxtTaxCode.Name = "TxtTaxCode";
            this.TxtTaxCode.PasswordChar = '*';
            this.TxtTaxCode.Size = new System.Drawing.Size(161, 27);
            this.TxtTaxCode.TabIndex = 36;
            // 
            // TxtAddress
            // 
            this.TxtAddress.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtAddress.Location = new System.Drawing.Point(203, 190);
            this.TxtAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtAddress.Multiline = true;
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.Size = new System.Drawing.Size(249, 76);
            this.TxtAddress.TabIndex = 39;
            // 
            // MtxtDateOfBirth
            // 
            this.MtxtDateOfBirth.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MtxtDateOfBirth.Location = new System.Drawing.Point(203, 159);
            this.MtxtDateOfBirth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MtxtDateOfBirth.Mask = "00/00/0000";
            this.MtxtDateOfBirth.Name = "MtxtDateOfBirth";
            this.MtxtDateOfBirth.Size = new System.Drawing.Size(161, 27);
            this.MtxtDateOfBirth.TabIndex = 38;
            this.MtxtDateOfBirth.ValidatingType = typeof(System.DateTime);
            // 
            // txtSalary
            // 
            this.txtSalary.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSalary.Location = new System.Drawing.Point(203, 128);
            this.txtSalary.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.PasswordChar = '*';
            this.txtSalary.Size = new System.Drawing.Size(249, 27);
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
            this.PnInformation.Location = new System.Drawing.Point(0, 58);
            this.PnInformation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PnInformation.Name = "PnInformation";
            this.PnInformation.Size = new System.Drawing.Size(511, 462);
            this.PnInformation.TabIndex = 5;
            // 
            // MtxtDateJoin
            // 
            this.MtxtDateJoin.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MtxtDateJoin.Location = new System.Drawing.Point(203, 35);
            this.MtxtDateJoin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MtxtDateJoin.Mask = "00/00/0000";
            this.MtxtDateJoin.Name = "MtxtDateJoin";
            this.MtxtDateJoin.Size = new System.Drawing.Size(161, 27);
            this.MtxtDateJoin.TabIndex = 34;
            this.MtxtDateJoin.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(56, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 19);
            this.label1.TabIndex = 40;
            this.label1.Text = "Date Join";
            // 
            // FrmAdminInsertAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 520);
            this.Controls.Add(this.PnInformation);
            this.Controls.Add(this.PnHeader);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmAdminInsertAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create New Staff Account";
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
        private System.Windows.Forms.Button BtnCreateAccount;
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