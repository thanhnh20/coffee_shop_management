namespace CoffeeManagement
{
    partial class FrmAdminManageProductList
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
            this.BtnAddNewProduct = new FontAwesome.Sharp.IconButton();
            this.LbFilterCompanyList = new System.Windows.Forms.Label();
            this.CbFilterProductList = new System.Windows.Forms.ComboBox();
            this.BtnSearchList = new FontAwesome.Sharp.IconButton();
            this.TxtSearchProductFollowingFilter = new System.Windows.Forms.TextBox();
            this.DgvProductList = new System.Windows.Forms.DataGridView();
            this.PnFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProductList)).BeginInit();
            this.SuspendLayout();
            // 
            // PnFilter
            // 
            this.PnFilter.BackColor = System.Drawing.SystemColors.Control;
            this.PnFilter.Controls.Add(this.BtnAddNewProduct);
            this.PnFilter.Controls.Add(this.LbFilterCompanyList);
            this.PnFilter.Controls.Add(this.CbFilterProductList);
            this.PnFilter.Controls.Add(this.BtnSearchList);
            this.PnFilter.Controls.Add(this.TxtSearchProductFollowingFilter);
            this.PnFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnFilter.Location = new System.Drawing.Point(0, 0);
            this.PnFilter.Name = "PnFilter";
            this.PnFilter.Size = new System.Drawing.Size(1064, 116);
            this.PnFilter.TabIndex = 5;
            // 
            // BtnAddNewProduct
            // 
            this.BtnAddNewProduct.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnAddNewProduct.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.BtnAddNewProduct.IconColor = System.Drawing.Color.Black;
            this.BtnAddNewProduct.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnAddNewProduct.IconSize = 25;
            this.BtnAddNewProduct.Location = new System.Drawing.Point(955, 86);
            this.BtnAddNewProduct.Name = "BtnAddNewProduct";
            this.BtnAddNewProduct.Size = new System.Drawing.Size(106, 31);
            this.BtnAddNewProduct.TabIndex = 4;
            this.BtnAddNewProduct.Text = "Insert";
            this.BtnAddNewProduct.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAddNewProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAddNewProduct.UseVisualStyleBackColor = true;
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
            // CbFilterProductList
            // 
            this.CbFilterProductList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CbFilterProductList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbFilterProductList.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CbFilterProductList.FormattingEnabled = true;
            this.CbFilterProductList.Items.AddRange(new object[] {
            "Company Name"});
            this.CbFilterProductList.Location = new System.Drawing.Point(189, 23);
            this.CbFilterProductList.Name = "CbFilterProductList";
            this.CbFilterProductList.Size = new System.Drawing.Size(178, 32);
            this.CbFilterProductList.TabIndex = 2;
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
            // TxtSearchProductFollowingFilter
            // 
            this.TxtSearchProductFollowingFilter.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtSearchProductFollowingFilter.Location = new System.Drawing.Point(401, 23);
            this.TxtSearchProductFollowingFilter.Name = "TxtSearchProductFollowingFilter";
            this.TxtSearchProductFollowingFilter.Size = new System.Drawing.Size(490, 32);
            this.TxtSearchProductFollowingFilter.TabIndex = 0;
            // 
            // DgvProductList
            // 
            this.DgvProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProductList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvProductList.Location = new System.Drawing.Point(0, 116);
            this.DgvProductList.Name = "DgvProductList";
            this.DgvProductList.RowHeadersWidth = 51;
            this.DgvProductList.RowTemplate.Height = 29;
            this.DgvProductList.Size = new System.Drawing.Size(1064, 435);
            this.DgvProductList.TabIndex = 6;
            // 
            // FrmAdminManageProductList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 551);
            this.Controls.Add(this.DgvProductList);
            this.Controls.Add(this.PnFilter);
            this.Name = "FrmAdminManageProductList";
            this.Text = "Manage Product";
            this.PnFilter.ResumeLayout(false);
            this.PnFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProductList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnFilter;
        private FontAwesome.Sharp.IconButton BtnAddNewProduct;
        private System.Windows.Forms.Label LbFilterCompanyList;
        private System.Windows.Forms.ComboBox CbFilterProductList;
        private FontAwesome.Sharp.IconButton BtnSearchList;
        private System.Windows.Forms.TextBox TxtSearchProductFollowingFilter;
        private System.Windows.Forms.DataGridView DgvProductList;
    }
}