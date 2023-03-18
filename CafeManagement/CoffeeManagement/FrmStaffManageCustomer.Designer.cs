namespace CoffeeManagement
{
    partial class FrmStaffManageCustomer
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
            this.BtnUpdateExistedAccount = new FontAwesome.Sharp.IconButton();
            this.BtnAddNewCustomer = new FontAwesome.Sharp.IconButton();
            this.LbFilterCompanyList = new System.Windows.Forms.Label();
            this.CbFilterAccountList = new System.Windows.Forms.ComboBox();
            this.BtnSearchList = new FontAwesome.Sharp.IconButton();
            this.TxtSearchAccountFollowingFilter = new System.Windows.Forms.TextBox();
            this.DgvAccountList = new System.Windows.Forms.DataGridView();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PnFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAccountList)).BeginInit();
            this.SuspendLayout();
            // 
            // PnFilter
            // 
            this.PnFilter.BackColor = System.Drawing.SystemColors.Control;
            this.PnFilter.Controls.Add(this.BtnUpdateExistedAccount);
            this.PnFilter.Controls.Add(this.BtnAddNewCustomer);
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
            // BtnAddNewCustomer
            // 
            this.BtnAddNewCustomer.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnAddNewCustomer.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.BtnAddNewCustomer.IconColor = System.Drawing.Color.Black;
            this.BtnAddNewCustomer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnAddNewCustomer.IconSize = 25;
            this.BtnAddNewCustomer.Location = new System.Drawing.Point(836, 59);
            this.BtnAddNewCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnAddNewCustomer.Name = "BtnAddNewCustomer";
            this.BtnAddNewCustomer.Size = new System.Drawing.Size(93, 28);
            this.BtnAddNewCustomer.TabIndex = 4;
            this.BtnAddNewCustomer.Text = "Insert";
            this.BtnAddNewCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAddNewCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAddNewCustomer.UseVisualStyleBackColor = true;
            this.BtnAddNewCustomer.Click += new System.EventHandler(this.BtnAddNewCustomer_Click);
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
            "Phone Number",
            "Name",
            "Email"});
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
            this.PhoneNumber,
            this.CustomerName,
            this.Email,
            this.Address});
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
            // PhoneNumber
            // 
            this.PhoneNumber.DataPropertyName = "phoneNumber";
            this.PhoneNumber.HeaderText = "Phone Number";
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.ReadOnly = true;
            // 
            // CustomerName
            // 
            this.CustomerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CustomerName.DataPropertyName = "name";
            this.CustomerName.HeaderText = "Customer Name";
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.ReadOnly = true;
            this.CustomerName.Width = 109;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "address";
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // FrmStaffManageCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 413);
            this.Controls.Add(this.DgvAccountList);
            this.Controls.Add(this.PnFilter);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmStaffManageCustomer";
            this.Text = "Manage Customer";
            this.PnFilter.ResumeLayout(false);
            this.PnFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAccountList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnFilter;
        private FontAwesome.Sharp.IconButton BtnAddNewCustomer;
        private System.Windows.Forms.Label LbFilterCompanyList;
        private System.Windows.Forms.ComboBox CbFilterAccountList;
        private FontAwesome.Sharp.IconButton BtnSearchList;
        private System.Windows.Forms.TextBox TxtSearchAccountFollowingFilter;
        private System.Windows.Forms.DataGridView DgvAccountList;
        private FontAwesome.Sharp.IconButton BtnUpdateExistedAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
    }
}