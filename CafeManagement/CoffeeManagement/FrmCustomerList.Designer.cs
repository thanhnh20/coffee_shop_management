namespace CoffeeManagement
{
    partial class FrmCustomerList
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
            this.BtnAddNewCustomer = new FontAwesome.Sharp.IconButton();
            this.LbFilterCompanyList = new System.Windows.Forms.Label();
            this.CbFilterCustomerList = new System.Windows.Forms.ComboBox();
            this.BtnSearchList = new FontAwesome.Sharp.IconButton();
            this.TxtSearchCustomerFollowingFilter = new System.Windows.Forms.TextBox();
            this.DgvIngredientList = new System.Windows.Forms.DataGridView();
            this.PnFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvIngredientList)).BeginInit();
            this.SuspendLayout();
            // 
            // PnFilter
            // 
            this.PnFilter.BackColor = System.Drawing.SystemColors.Control;
            this.PnFilter.Controls.Add(this.BtnAddNewCustomer);
            this.PnFilter.Controls.Add(this.LbFilterCompanyList);
            this.PnFilter.Controls.Add(this.CbFilterCustomerList);
            this.PnFilter.Controls.Add(this.BtnSearchList);
            this.PnFilter.Controls.Add(this.TxtSearchCustomerFollowingFilter);
            this.PnFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnFilter.Location = new System.Drawing.Point(0, 0);
            this.PnFilter.Name = "PnFilter";
            this.PnFilter.Size = new System.Drawing.Size(1064, 116);
            this.PnFilter.TabIndex = 7;
            // 
            // BtnAddNewCustomer
            // 
            this.BtnAddNewCustomer.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnAddNewCustomer.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.BtnAddNewCustomer.IconColor = System.Drawing.Color.Black;
            this.BtnAddNewCustomer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnAddNewCustomer.IconSize = 25;
            this.BtnAddNewCustomer.Location = new System.Drawing.Point(955, 86);
            this.BtnAddNewCustomer.Name = "BtnAddNewCustomer";
            this.BtnAddNewCustomer.Size = new System.Drawing.Size(106, 31);
            this.BtnAddNewCustomer.TabIndex = 4;
            this.BtnAddNewCustomer.Text = "Insert";
            this.BtnAddNewCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAddNewCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAddNewCustomer.UseVisualStyleBackColor = true;
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
            // CbFilterCustomerList
            // 
            this.CbFilterCustomerList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CbFilterCustomerList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbFilterCustomerList.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CbFilterCustomerList.FormattingEnabled = true;
            this.CbFilterCustomerList.Items.AddRange(new object[] {
            "Company Name"});
            this.CbFilterCustomerList.Location = new System.Drawing.Point(189, 23);
            this.CbFilterCustomerList.Name = "CbFilterCustomerList";
            this.CbFilterCustomerList.Size = new System.Drawing.Size(178, 32);
            this.CbFilterCustomerList.TabIndex = 2;
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
            // TxtSearchCustomerFollowingFilter
            // 
            this.TxtSearchCustomerFollowingFilter.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtSearchCustomerFollowingFilter.Location = new System.Drawing.Point(401, 23);
            this.TxtSearchCustomerFollowingFilter.Name = "TxtSearchCustomerFollowingFilter";
            this.TxtSearchCustomerFollowingFilter.Size = new System.Drawing.Size(490, 32);
            this.TxtSearchCustomerFollowingFilter.TabIndex = 0;
            // 
            // DgvIngredientList
            // 
            this.DgvIngredientList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvIngredientList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvIngredientList.Location = new System.Drawing.Point(0, 116);
            this.DgvIngredientList.Name = "DgvIngredientList";
            this.DgvIngredientList.RowHeadersWidth = 51;
            this.DgvIngredientList.RowTemplate.Height = 29;
            this.DgvIngredientList.Size = new System.Drawing.Size(1064, 435);
            this.DgvIngredientList.TabIndex = 8;
            // 
            // FrmCustomerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 551);
            this.Controls.Add(this.DgvIngredientList);
            this.Controls.Add(this.PnFilter);
            this.Name = "FrmCustomerList";
            this.Text = "Customer List";
            this.PnFilter.ResumeLayout(false);
            this.PnFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvIngredientList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnFilter;
        private FontAwesome.Sharp.IconButton BtnAddNewCustomer;
        private System.Windows.Forms.Label LbFilterCompanyList;
        private System.Windows.Forms.ComboBox CbFilterCustomerList;
        private FontAwesome.Sharp.IconButton BtnSearchList;
        private System.Windows.Forms.TextBox TxtSearchCustomerFollowingFilter;
        private System.Windows.Forms.DataGridView DgvIngredientList;
    }
}