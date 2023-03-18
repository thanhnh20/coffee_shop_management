namespace CoffeeManagement
{
    partial class FrmAdminManageStorage
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
            this.BtnAddNewIngreadient = new FontAwesome.Sharp.IconButton();
            this.LbFilterCompanyList = new System.Windows.Forms.Label();
            this.CbFilterIngredientList = new System.Windows.Forms.ComboBox();
            this.BtnSearchList = new FontAwesome.Sharp.IconButton();
            this.TxtSearchIngredientFollowingFilter = new System.Windows.Forms.TextBox();
            this.DgvIngredientList = new System.Windows.Forms.DataGridView();
            this.PnFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvIngredientList)).BeginInit();
            this.SuspendLayout();
            // 
            // PnFilter
            // 
            this.PnFilter.BackColor = System.Drawing.SystemColors.Control;
            this.PnFilter.Controls.Add(this.BtnAddNewIngreadient);
            this.PnFilter.Controls.Add(this.LbFilterCompanyList);
            this.PnFilter.Controls.Add(this.CbFilterIngredientList);
            this.PnFilter.Controls.Add(this.BtnSearchList);
            this.PnFilter.Controls.Add(this.TxtSearchIngredientFollowingFilter);
            this.PnFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnFilter.Location = new System.Drawing.Point(0, 0);
            this.PnFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PnFilter.Name = "PnFilter";
            this.PnFilter.Size = new System.Drawing.Size(931, 87);
            this.PnFilter.TabIndex = 6;
            // 
            // BtnAddNewIngreadient
            // 
            this.BtnAddNewIngreadient.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnAddNewIngreadient.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.BtnAddNewIngreadient.IconColor = System.Drawing.Color.Black;
            this.BtnAddNewIngreadient.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnAddNewIngreadient.IconSize = 25;
            this.BtnAddNewIngreadient.Location = new System.Drawing.Point(836, 64);
            this.BtnAddNewIngreadient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnAddNewIngreadient.Name = "BtnAddNewIngreadient";
            this.BtnAddNewIngreadient.Size = new System.Drawing.Size(93, 23);
            this.BtnAddNewIngreadient.TabIndex = 4;
            this.BtnAddNewIngreadient.Text = "Insert";
            this.BtnAddNewIngreadient.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAddNewIngreadient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAddNewIngreadient.UseVisualStyleBackColor = true;
            this.BtnAddNewIngreadient.Click += new System.EventHandler(this.BtnAddNewIngreadient_Click);
            // 
            // LbFilterCompanyList
            // 
            this.LbFilterCompanyList.AutoSize = true;
            this.LbFilterCompanyList.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbFilterCompanyList.Location = new System.Drawing.Point(73, 23);
            this.LbFilterCompanyList.Name = "LbFilterCompanyList";
            this.LbFilterCompanyList.Size = new System.Drawing.Size(80, 19);
            this.LbFilterCompanyList.TabIndex = 3;
            this.LbFilterCompanyList.Text = "Search By: ";
            // 
            // CbFilterIngredientList
            // 
            this.CbFilterIngredientList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CbFilterIngredientList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbFilterIngredientList.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CbFilterIngredientList.FormattingEnabled = true;
            this.CbFilterIngredientList.Items.AddRange(new object[] {
            "Ingredient ID"});
            this.CbFilterIngredientList.Location = new System.Drawing.Point(165, 17);
            this.CbFilterIngredientList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CbFilterIngredientList.Name = "CbFilterIngredientList";
            this.CbFilterIngredientList.Size = new System.Drawing.Size(156, 27);
            this.CbFilterIngredientList.TabIndex = 2;
            // 
            // BtnSearchList
            // 
            this.BtnSearchList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSearchList.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnSearchList.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.BtnSearchList.IconColor = System.Drawing.Color.Black;
            this.BtnSearchList.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnSearchList.IconSize = 25;
            this.BtnSearchList.Location = new System.Drawing.Point(808, 17);
            this.BtnSearchList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnSearchList.Name = "BtnSearchList";
            this.BtnSearchList.Size = new System.Drawing.Size(56, 24);
            this.BtnSearchList.TabIndex = 1;
            this.BtnSearchList.UseVisualStyleBackColor = true;
            this.BtnSearchList.Click += new System.EventHandler(this.BtnSearchList_Click);
            // 
            // TxtSearchIngredientFollowingFilter
            // 
            this.TxtSearchIngredientFollowingFilter.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtSearchIngredientFollowingFilter.Location = new System.Drawing.Point(351, 17);
            this.TxtSearchIngredientFollowingFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtSearchIngredientFollowingFilter.Name = "TxtSearchIngredientFollowingFilter";
            this.TxtSearchIngredientFollowingFilter.Size = new System.Drawing.Size(429, 27);
            this.TxtSearchIngredientFollowingFilter.TabIndex = 0;
            // 
            // DgvIngredientList
            // 
            this.DgvIngredientList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvIngredientList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvIngredientList.Location = new System.Drawing.Point(0, 87);
            this.DgvIngredientList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DgvIngredientList.Name = "DgvIngredientList";
            this.DgvIngredientList.RowHeadersWidth = 51;
            this.DgvIngredientList.RowTemplate.Height = 29;
            this.DgvIngredientList.Size = new System.Drawing.Size(931, 326);
            this.DgvIngredientList.TabIndex = 7;
            this.DgvIngredientList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvIngredientList_CellClick);
            this.DgvIngredientList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvIngredientList_CellDoubleClick);
            // 
            // FrmAdminManageStorage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 413);
            this.Controls.Add(this.DgvIngredientList);
            this.Controls.Add(this.PnFilter);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmAdminManageStorage";
            this.Text = "Manage Storage";
            this.Load += new System.EventHandler(this.FrmAdminManageStorage_Load);
            this.PnFilter.ResumeLayout(false);
            this.PnFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvIngredientList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnFilter;
        private FontAwesome.Sharp.IconButton BtnAddNewIngreadient;
        private System.Windows.Forms.Label LbFilterCompanyList;
        private System.Windows.Forms.ComboBox CbFilterIngredientList;
        private FontAwesome.Sharp.IconButton BtnSearchList;
        private System.Windows.Forms.TextBox TxtSearchIngredientFollowingFilter;
        private System.Windows.Forms.DataGridView DgvIngredientList;
    }
}