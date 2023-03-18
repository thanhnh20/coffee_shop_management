namespace CoffeeManagement
{
    partial class FrmInvoiceHistory
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
            this.LbFilterCompanyList = new System.Windows.Forms.Label();
            this.CbFilterInvoiceHistoryList = new System.Windows.Forms.ComboBox();
            this.BtnSearchList = new FontAwesome.Sharp.IconButton();
            this.TxtSearchInvoiceFollowingFilter = new System.Windows.Forms.TextBox();
            this.DgvInvoiceHistoryList = new System.Windows.Forms.DataGridView();
            this.PnFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvInvoiceHistoryList)).BeginInit();
            this.SuspendLayout();
            // 
            // PnFilter
            // 
            this.PnFilter.BackColor = System.Drawing.SystemColors.Control;
            this.PnFilter.Controls.Add(this.LbFilterCompanyList);
            this.PnFilter.Controls.Add(this.CbFilterInvoiceHistoryList);
            this.PnFilter.Controls.Add(this.BtnSearchList);
            this.PnFilter.Controls.Add(this.TxtSearchInvoiceFollowingFilter);
            this.PnFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnFilter.Location = new System.Drawing.Point(0, 0);
            this.PnFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PnFilter.Name = "PnFilter";
            this.PnFilter.Size = new System.Drawing.Size(931, 87);
            this.PnFilter.TabIndex = 7;
            // 
            // LbFilterCompanyList
            // 
            this.LbFilterCompanyList.AutoSize = true;
            this.LbFilterCompanyList.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbFilterCompanyList.Location = new System.Drawing.Point(73, 33);
            this.LbFilterCompanyList.Name = "LbFilterCompanyList";
            this.LbFilterCompanyList.Size = new System.Drawing.Size(80, 19);
            this.LbFilterCompanyList.TabIndex = 3;
            this.LbFilterCompanyList.Text = "Search By: ";
            // 
            // CbFilterInvoiceHistoryList
            // 
            this.CbFilterInvoiceHistoryList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CbFilterInvoiceHistoryList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbFilterInvoiceHistoryList.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CbFilterInvoiceHistoryList.FormattingEnabled = true;
            this.CbFilterInvoiceHistoryList.Items.AddRange(new object[] {
            "Order\'s ID"});
            this.CbFilterInvoiceHistoryList.Location = new System.Drawing.Point(165, 27);
            this.CbFilterInvoiceHistoryList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CbFilterInvoiceHistoryList.Name = "CbFilterInvoiceHistoryList";
            this.CbFilterInvoiceHistoryList.Size = new System.Drawing.Size(156, 27);
            this.CbFilterInvoiceHistoryList.TabIndex = 2;
            // 
            // BtnSearchList
            // 
            this.BtnSearchList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSearchList.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnSearchList.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.BtnSearchList.IconColor = System.Drawing.Color.Black;
            this.BtnSearchList.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnSearchList.IconSize = 25;
            this.BtnSearchList.Location = new System.Drawing.Point(808, 27);
            this.BtnSearchList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnSearchList.Name = "BtnSearchList";
            this.BtnSearchList.Size = new System.Drawing.Size(56, 24);
            this.BtnSearchList.TabIndex = 1;
            this.BtnSearchList.UseVisualStyleBackColor = true;
            this.BtnSearchList.Click += new System.EventHandler(this.BtnSearchList_Click);
            // 
            // TxtSearchInvoiceFollowingFilter
            // 
            this.TxtSearchInvoiceFollowingFilter.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtSearchInvoiceFollowingFilter.Location = new System.Drawing.Point(351, 27);
            this.TxtSearchInvoiceFollowingFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtSearchInvoiceFollowingFilter.Name = "TxtSearchInvoiceFollowingFilter";
            this.TxtSearchInvoiceFollowingFilter.Size = new System.Drawing.Size(429, 27);
            this.TxtSearchInvoiceFollowingFilter.TabIndex = 0;
            // 
            // DgvInvoiceHistoryList
            // 
            this.DgvInvoiceHistoryList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvInvoiceHistoryList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvInvoiceHistoryList.Location = new System.Drawing.Point(0, 87);
            this.DgvInvoiceHistoryList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DgvInvoiceHistoryList.Name = "DgvInvoiceHistoryList";
            this.DgvInvoiceHistoryList.RowHeadersWidth = 51;
            this.DgvInvoiceHistoryList.RowTemplate.Height = 29;
            this.DgvInvoiceHistoryList.Size = new System.Drawing.Size(931, 326);
            this.DgvInvoiceHistoryList.TabIndex = 8;
            this.DgvInvoiceHistoryList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvInvoiceHistoryList_CellClick);
            // 
            // FrmInvoiceHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 413);
            this.Controls.Add(this.DgvInvoiceHistoryList);
            this.Controls.Add(this.PnFilter);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmInvoiceHistory";
            this.Text = "Invoice History";
            this.PnFilter.ResumeLayout(false);
            this.PnFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvInvoiceHistoryList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnFilter;
        private System.Windows.Forms.Label LbFilterCompanyList;
        private System.Windows.Forms.ComboBox CbFilterInvoiceHistoryList;
        private FontAwesome.Sharp.IconButton BtnSearchList;
        private System.Windows.Forms.TextBox TxtSearchInvoiceFollowingFilter;
        private System.Windows.Forms.DataGridView DgvInvoiceHistoryList;
    }
}