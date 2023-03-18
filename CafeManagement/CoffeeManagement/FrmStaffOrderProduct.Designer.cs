namespace CoffeeManagement
{
    partial class FrmStaffOrderProduct
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
            this.flpProduct = new System.Windows.Forms.FlowLayoutPanel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.dgvListProductOrdered = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dudQuantity = new System.Windows.Forms.DomainUpDown();
            this.btnOrder = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbProductName = new System.Windows.Forms.Label();
            this.PnFilter = new System.Windows.Forms.Panel();
            this.LbFilterCompanyList = new System.Windows.Forms.Label();
            this.BtnSearchList = new FontAwesome.Sharp.IconButton();
            this.TxtSearchIngredientFollowingFilter = new System.Windows.Forms.TextBox();
            this.btnRemove = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconButton21 = new FontAwesome.Sharp.IconButton();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.flpProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListProductOrdered)).BeginInit();
            this.panel1.SuspendLayout();
            this.PnFilter.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpProduct
            // 
            this.flpProduct.Controls.Add(this.iconButton1);
            this.flpProduct.Location = new System.Drawing.Point(0, 67);
            this.flpProduct.Name = "flpProduct";
            this.flpProduct.Size = new System.Drawing.Size(738, 484);
            this.flpProduct.TabIndex = 0;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.ForestGreen;
            this.iconButton1.BackgroundImage = global::CoffeeManagement.Properties.Resources.coffee;
            this.iconButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton1.FlatAppearance.BorderSize = 2;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(3, 3);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(175, 107);
            this.iconButton1.TabIndex = 0;
            this.iconButton1.Text = "Đen đá không đường";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // dgvListProductOrdered
            // 
            this.dgvListProductOrdered.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListProductOrdered.Location = new System.Drawing.Point(744, 183);
            this.dgvListProductOrdered.Name = "dgvListProductOrdered";
            this.dgvListProductOrdered.RowHeadersWidth = 51;
            this.dgvListProductOrdered.RowTemplate.Height = 29;
            this.dgvListProductOrdered.Size = new System.Drawing.Size(315, 280);
            this.dgvListProductOrdered.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(778, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Products ordered";
            // 
            // dudQuantity
            // 
            this.dudQuantity.Location = new System.Drawing.Point(43, 57);
            this.dudQuantity.Name = "dudQuantity";
            this.dudQuantity.Size = new System.Drawing.Size(57, 27);
            this.dudQuantity.TabIndex = 14;
            this.dudQuantity.Text = "1";
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.Gold;
            this.btnOrder.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOrder.ForeColor = System.Drawing.Color.Crimson;
            this.btnOrder.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            this.btnOrder.IconColor = System.Drawing.Color.Crimson;
            this.btnOrder.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnOrder.IconSize = 35;
            this.btnOrder.Location = new System.Drawing.Point(117, 44);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(131, 51);
            this.btnOrder.TabIndex = 15;
            this.btnOrder.Text = "Order";
            this.btnOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbProductName);
            this.panel1.Controls.Add(this.btnOrder);
            this.panel1.Controls.Add(this.dudQuantity);
            this.panel1.Location = new System.Drawing.Point(774, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(261, 100);
            this.panel1.TabIndex = 16;
            // 
            // lbProductName
            // 
            this.lbProductName.AutoSize = true;
            this.lbProductName.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbProductName.ForeColor = System.Drawing.Color.Black;
            this.lbProductName.Location = new System.Drawing.Point(27, 11);
            this.lbProductName.Name = "lbProductName";
            this.lbProductName.Size = new System.Drawing.Size(0, 27);
            this.lbProductName.TabIndex = 16;
            // 
            // PnFilter
            // 
            this.PnFilter.BackColor = System.Drawing.SystemColors.Control;
            this.PnFilter.Controls.Add(this.LbFilterCompanyList);
            this.PnFilter.Controls.Add(this.BtnSearchList);
            this.PnFilter.Controls.Add(this.TxtSearchIngredientFollowingFilter);
            this.PnFilter.Location = new System.Drawing.Point(0, 0);
            this.PnFilter.Name = "PnFilter";
            this.PnFilter.Size = new System.Drawing.Size(738, 63);
            this.PnFilter.TabIndex = 17;
            // 
            // LbFilterCompanyList
            // 
            this.LbFilterCompanyList.AutoSize = true;
            this.LbFilterCompanyList.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbFilterCompanyList.Location = new System.Drawing.Point(11, 21);
            this.LbFilterCompanyList.Name = "LbFilterCompanyList";
            this.LbFilterCompanyList.Size = new System.Drawing.Size(154, 24);
            this.LbFilterCompanyList.TabIndex = 3;
            this.LbFilterCompanyList.Text = "Search By Name: ";
            // 
            // BtnSearchList
            // 
            this.BtnSearchList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSearchList.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnSearchList.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.BtnSearchList.IconColor = System.Drawing.Color.Black;
            this.BtnSearchList.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnSearchList.IconSize = 25;
            this.BtnSearchList.Location = new System.Drawing.Point(656, 19);
            this.BtnSearchList.Name = "BtnSearchList";
            this.BtnSearchList.Size = new System.Drawing.Size(64, 32);
            this.BtnSearchList.TabIndex = 1;
            this.BtnSearchList.UseVisualStyleBackColor = true;
            this.BtnSearchList.Click += new System.EventHandler(this.BtnSearchList_Click);
            // 
            // TxtSearchIngredientFollowingFilter
            // 
            this.TxtSearchIngredientFollowingFilter.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtSearchIngredientFollowingFilter.Location = new System.Drawing.Point(171, 19);
            this.TxtSearchIngredientFollowingFilter.Name = "TxtSearchIngredientFollowingFilter";
            this.TxtSearchIngredientFollowingFilter.Size = new System.Drawing.Size(463, 32);
            this.TxtSearchIngredientFollowingFilter.TabIndex = 0;
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Red;
            this.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemove.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnRemove.IconColor = System.Drawing.Color.White;
            this.btnRemove.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRemove.IconSize = 15;
            this.btnRemove.Location = new System.Drawing.Point(965, 155);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(93, 28);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Remove";
            this.btnRemove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.iconButton21);
            this.panel2.Controls.Add(this.txtAmount);
            this.panel2.Location = new System.Drawing.Point(744, 469);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(315, 69);
            this.panel2.TabIndex = 17;
            // 
            // iconButton21
            // 
            this.iconButton21.BackColor = System.Drawing.Color.DarkSlateGray;
            this.iconButton21.Dock = System.Windows.Forms.DockStyle.Right;
            this.iconButton21.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconButton21.ForeColor = System.Drawing.Color.LavenderBlush;
            this.iconButton21.IconChar = FontAwesome.Sharp.IconChar.MoneyBill;
            this.iconButton21.IconColor = System.Drawing.Color.White;
            this.iconButton21.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton21.IconSize = 35;
            this.iconButton21.Location = new System.Drawing.Point(184, 0);
            this.iconButton21.Name = "iconButton21";
            this.iconButton21.Size = new System.Drawing.Size(131, 69);
            this.iconButton21.TabIndex = 15;
            this.iconButton21.Text = "Payment";
            this.iconButton21.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton21.UseVisualStyleBackColor = false;
            this.iconButton21.Click += new System.EventHandler(this.iconButton21_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Enabled = false;
            this.txtAmount.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtAmount.ForeColor = System.Drawing.Color.Red;
            this.txtAmount.Location = new System.Drawing.Point(3, 19);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(180, 36);
            this.txtAmount.TabIndex = 13;
            // 
            // FrmStaffOrderProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 551);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.PnFilter);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvListProductOrdered);
            this.Controls.Add(this.flpProduct);
            this.Name = "FrmStaffOrderProduct";
            this.Text = "Order Product";
            this.flpProduct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListProductOrdered)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PnFilter.ResumeLayout(false);
            this.PnFilter.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpProduct;
        private System.Windows.Forms.DataGridView dgvListProductOrdered;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DomainUpDown dudQuantity;
        private FontAwesome.Sharp.IconButton btnOrder;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PnFilter;
        private FontAwesome.Sharp.IconButton BtnSearchList;
        private System.Windows.Forms.TextBox TxtSearchIngredientFollowingFilter;
        private System.Windows.Forms.Label LbFilterCompanyList;
        private FontAwesome.Sharp.IconButton btnRemove;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton iconButton21;
        private System.Windows.Forms.TextBox txtAmount;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Label lbProductName;
    }
}