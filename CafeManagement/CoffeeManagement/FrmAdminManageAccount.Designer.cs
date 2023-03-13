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
            this.PnFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAccountList)).BeginInit();
            this.SuspendLayout();
            // 
            // PnFilter
            // 
            this.PnFilter.BackColor = System.Drawing.SystemColors.Control;
            this.PnFilter.Controls.Add(this.BtnAddNewAccount);
            this.PnFilter.Controls.Add(this.LbFilterCompanyList);
            this.PnFilter.Controls.Add(this.CbFilterAccountList);
            this.PnFilter.Controls.Add(this.BtnSearchList);
            this.PnFilter.Controls.Add(this.TxtSearchAccountFollowingFilter);
            this.PnFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnFilter.Location = new System.Drawing.Point(0, 0);
            this.PnFilter.Name = "PnFilter";
            this.PnFilter.Size = new System.Drawing.Size(1064, 116);
            this.PnFilter.TabIndex = 6;
            // 
            // BtnAddNewAccount
            // 
            this.BtnAddNewAccount.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnAddNewAccount.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.BtnAddNewAccount.IconColor = System.Drawing.Color.Black;
            this.BtnAddNewAccount.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnAddNewAccount.IconSize = 25;
            this.BtnAddNewAccount.Location = new System.Drawing.Point(955, 86);
            this.BtnAddNewAccount.Name = "BtnAddNewAccount";
            this.BtnAddNewAccount.Size = new System.Drawing.Size(106, 31);
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
            this.LbFilterCompanyList.Location = new System.Drawing.Point(83, 31);
            this.LbFilterCompanyList.Name = "LbFilterCompanyList";
            this.LbFilterCompanyList.Size = new System.Drawing.Size(100, 24);
            this.LbFilterCompanyList.TabIndex = 3;
            this.LbFilterCompanyList.Text = "Search By: ";
            // 
            // CbFilterAccountList
            // 
            this.CbFilterAccountList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CbFilterAccountList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbFilterAccountList.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CbFilterAccountList.FormattingEnabled = true;
            this.CbFilterAccountList.Items.AddRange(new object[] {
            "Company Name"});
            this.CbFilterAccountList.Location = new System.Drawing.Point(189, 23);
            this.CbFilterAccountList.Name = "CbFilterAccountList";
            this.CbFilterAccountList.Size = new System.Drawing.Size(178, 32);
            this.CbFilterAccountList.TabIndex = 2;
            // 
            // BtnSearchList
            // 
            this.BtnSearchList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSearchList.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnSearchList.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.BtnSearchList.IconColor = System.Drawing.Color.Black;
            this.BtnSearchList.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnSearchList.IconSize = 25;
            this.BtnSearchList.Location = new System.Drawing.Point(924, 23);
            this.BtnSearchList.Name = "BtnSearchList";
            this.BtnSearchList.Size = new System.Drawing.Size(64, 32);
            this.BtnSearchList.TabIndex = 1;
            this.BtnSearchList.UseVisualStyleBackColor = true;
            // 
            // TxtSearchAccountFollowingFilter
            // 
            this.TxtSearchAccountFollowingFilter.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtSearchAccountFollowingFilter.Location = new System.Drawing.Point(401, 23);
            this.TxtSearchAccountFollowingFilter.Name = "TxtSearchAccountFollowingFilter";
            this.TxtSearchAccountFollowingFilter.Size = new System.Drawing.Size(490, 32);
            this.TxtSearchAccountFollowingFilter.TabIndex = 0;
            // 
            // DgvAccountList
            // 
            this.DgvAccountList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAccountList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvAccountList.Location = new System.Drawing.Point(0, 116);
            this.DgvAccountList.Name = "DgvAccountList";
            this.DgvAccountList.RowHeadersWidth = 51;
            this.DgvAccountList.RowTemplate.Height = 29;
            this.DgvAccountList.Size = new System.Drawing.Size(1064, 435);
            this.DgvAccountList.TabIndex = 7;
            // 
            // FrmAdminManageAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 551);
            this.Controls.Add(this.DgvAccountList);
            this.Controls.Add(this.PnFilter);
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
    }
}