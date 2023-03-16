namespace CoffeeManagement
{
    partial class FrmAdminManageAccount
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
            this.PnFilter = new System.Windows.Forms.Panel();
            this.BtnAddNewAccount = new FontAwesome.Sharp.IconButton();
            this.LbFilterCompanyList = new System.Windows.Forms.Label();
            this.CbFilterAccountList = new System.Windows.Forms.ComboBox();
            this.BtnSearchList = new FontAwesome.Sharp.IconButton();
            this.TxtSearchAccountFollowingFilter = new System.Windows.Forms.TextBox();
            this.DgvAccountList = new System.Windows.Forms.DataGridView();
            this.StaffId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateJoin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaxCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Roleid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnUpdateExistedAccount = new FontAwesome.Sharp.IconButton();
            this.PnFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAccountList)).BeginInit();
            this.SuspendLayout();
            // 
            // PnFilter
            // 
            this.PnFilter.BackColor = System.Drawing.SystemColors.Control;
            this.PnFilter.Controls.Add(this.BtnUpdateExistedAccount);
            this.PnFilter.Controls.Add(this.BtnAddNewAccount);
            this.PnFilter.Controls.Add(this.LbFilterCompanyList);
            this.PnFilter.Controls.Add(this.CbFilterAccountList);
            this.PnFilter.Controls.Add(this.BtnSearchList);
            this.PnFilter.Controls.Add(this.TxtSearchAccountFollowingFilter);
            this.PnFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnFilter.Location = new System.Drawing.Point(0, 0);
            this.PnFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PnFilter.Name = "PnFilter";
            this.PnFilter.Size = new System.Drawing.Size(929, 87);
            this.PnFilter.TabIndex = 6;
            // 
            // BtnAddNewAccount
            // 
            this.BtnAddNewAccount.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnAddNewAccount.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.BtnAddNewAccount.IconColor = System.Drawing.Color.Black;
            this.BtnAddNewAccount.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnAddNewAccount.IconSize = 25;
            this.BtnAddNewAccount.Location = new System.Drawing.Point(836, 59);
            this.BtnAddNewAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnAddNewAccount.Name = "BtnAddNewAccount";
            this.BtnAddNewAccount.Size = new System.Drawing.Size(93, 28);
            this.BtnAddNewAccount.TabIndex = 4;
            this.BtnAddNewAccount.Text = "Insert";
            this.BtnAddNewAccount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAddNewAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAddNewAccount.UseVisualStyleBackColor = true;
            this.BtnAddNewAccount.Click += new System.EventHandler(this.BtnAddNewAccount_Click);
            // 
            // LbFilterCompanyList
            // 
            this.LbFilterCompanyList.AutoSize = true;
            this.LbFilterCompanyList.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbFilterCompanyList.Location = new System.Drawing.Point(79, 21);
            this.LbFilterCompanyList.Name = "LbFilterCompanyList";
            this.LbFilterCompanyList.Size = new System.Drawing.Size(80, 19);
            this.LbFilterCompanyList.TabIndex = 0;
            this.LbFilterCompanyList.Text = "Search By: ";
            // 
            // CbFilterAccountList
            // 
            this.CbFilterAccountList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CbFilterAccountList.DisplayMember = "Username";
            this.CbFilterAccountList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbFilterAccountList.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CbFilterAccountList.FormattingEnabled = true;
            this.CbFilterAccountList.Items.AddRange(new object[] {
            "Username",
            "Staff ID",
            "Role ID"});
            this.CbFilterAccountList.Location = new System.Drawing.Point(165, 17);
            this.CbFilterAccountList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CbFilterAccountList.Name = "CbFilterAccountList";
            this.CbFilterAccountList.Size = new System.Drawing.Size(156, 27);
            this.CbFilterAccountList.TabIndex = 1;
            // 
            // BtnSearchList
            // 
            this.BtnSearchList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnSearchList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSearchList.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnSearchList.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.BtnSearchList.IconColor = System.Drawing.Color.Black;
            this.BtnSearchList.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnSearchList.IconSize = 25;
            this.BtnSearchList.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnSearchList.Location = new System.Drawing.Point(808, 17);
            this.BtnSearchList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnSearchList.Name = "BtnSearchList";
            this.BtnSearchList.Size = new System.Drawing.Size(56, 27);
            this.BtnSearchList.TabIndex = 3;
            this.BtnSearchList.UseVisualStyleBackColor = true;
            this.BtnSearchList.Click += new System.EventHandler(this.BtnSearchList_Click);
            // 
            // TxtSearchAccountFollowingFilter
            // 
            this.TxtSearchAccountFollowingFilter.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtSearchAccountFollowingFilter.Location = new System.Drawing.Point(351, 17);
            this.TxtSearchAccountFollowingFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtSearchAccountFollowingFilter.Name = "TxtSearchAccountFollowingFilter";
            this.TxtSearchAccountFollowingFilter.Size = new System.Drawing.Size(429, 27);
            this.TxtSearchAccountFollowingFilter.TabIndex = 2;
            // 
            // DgvAccountList
            // 
            this.DgvAccountList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAccountList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StaffId,
            this.Username,
            this.Fullname,
            this.DateJoin,
            this.Address,
            this.PhoneNumber,
            this.DateOfBirth,
            this.TaxCode,
            this.Salary,
            this.Password,
            this.Roleid,
            this.Status});
            this.DgvAccountList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvAccountList.Location = new System.Drawing.Point(0, 87);
            this.DgvAccountList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DgvAccountList.MultiSelect = false;
            this.DgvAccountList.Name = "DgvAccountList";
            this.DgvAccountList.ReadOnly = true;
            this.DgvAccountList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.DgvAccountList.RowTemplate.Height = 29;
            this.DgvAccountList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvAccountList.Size = new System.Drawing.Size(929, 326);
            this.DgvAccountList.TabIndex = 7;
            // 
            // StaffId
            // 
            this.StaffId.DataPropertyName = "staffID";
            this.StaffId.HeaderText = "Staff ID";
            this.StaffId.Name = "StaffId";
            this.StaffId.ReadOnly = true;
            // 
            // Username
            // 
            this.Username.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Username.DataPropertyName = "username";
            this.Username.HeaderText = "Username";
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            this.Username.Width = 85;
            // 
            // Fullname
            // 
            this.Fullname.DataPropertyName = "fullname";
            this.Fullname.HeaderText = "Full Name";
            this.Fullname.Name = "Fullname";
            this.Fullname.ReadOnly = true;
            // 
            // DateJoin
            // 
            this.DateJoin.DataPropertyName = "dateJoin";
            this.DateJoin.HeaderText = "Date Join";
            this.DateJoin.Name = "DateJoin";
            this.DateJoin.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "address";
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.DataPropertyName = "phoneNumber";
            this.PhoneNumber.HeaderText = "Phone Number";
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.ReadOnly = true;
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.DataPropertyName = "dateOfBirth";
            this.DateOfBirth.HeaderText = "Date of Birth";
            this.DateOfBirth.Name = "DateOfBirth";
            this.DateOfBirth.ReadOnly = true;
            // 
            // TaxCode
            // 
            this.TaxCode.DataPropertyName = "taxCode";
            this.TaxCode.HeaderText = "Tax Code";
            this.TaxCode.Name = "TaxCode";
            this.TaxCode.ReadOnly = true;
            // 
            // Salary
            // 
            this.Salary.DataPropertyName = "salary";
            this.Salary.HeaderText = "Salary";
            this.Salary.Name = "Salary";
            this.Salary.ReadOnly = true;
            // 
            // Password
            // 
            this.Password.DataPropertyName = "password";
            this.Password.HeaderText = "Password";
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            // 
            // Roleid
            // 
            this.Roleid.DataPropertyName = "roleID";
            this.Roleid.HeaderText = "Role Id";
            this.Roleid.Name = "Roleid";
            this.Roleid.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // BtnUpdateExistedAccount
            // 
            this.BtnUpdateExistedAccount.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnUpdateExistedAccount.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.BtnUpdateExistedAccount.IconColor = System.Drawing.Color.Black;
            this.BtnUpdateExistedAccount.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnUpdateExistedAccount.IconSize = 25;
            this.BtnUpdateExistedAccount.Location = new System.Drawing.Point(737, 59);
            this.BtnUpdateExistedAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnUpdateExistedAccount.Name = "BtnUpdateExistedAccount";
            this.BtnUpdateExistedAccount.Size = new System.Drawing.Size(93, 28);
            this.BtnUpdateExistedAccount.TabIndex = 5;
            this.BtnUpdateExistedAccount.Text = "Update";
            this.BtnUpdateExistedAccount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnUpdateExistedAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnUpdateExistedAccount.UseVisualStyleBackColor = true;
            this.BtnUpdateExistedAccount.Click += new System.EventHandler(this.BtnUpdateExistedAccount_Click);
            // 
            // FrmAdminManageAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 413);
            this.Controls.Add(this.DgvAccountList);
            this.Controls.Add(this.PnFilter);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmAdminManageAccount";
            this.Text = "Manage Account";
            this.PnFilter.ResumeLayout(false);
            this.PnFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAccountList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnFilter;
        private FontAwesome.Sharp.IconButton BtnAddNewAccount;
        private System.Windows.Forms.Label LbFilterCompanyList;
        private System.Windows.Forms.ComboBox CbFilterAccountList;
        private FontAwesome.Sharp.IconButton BtnSearchList;
        private System.Windows.Forms.TextBox TxtSearchAccountFollowingFilter;
        private System.Windows.Forms.DataGridView DgvAccountList;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateJoin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaxCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salary;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn Roleid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private FontAwesome.Sharp.IconButton BtnUpdateExistedAccount;
    }
}