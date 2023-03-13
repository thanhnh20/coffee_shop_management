namespace CoffeeManagement
{
    partial class FrmAdminInsertNewProduct
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
            this.PnInformation = new System.Windows.Forms.Panel();
            this.btnSelectIngredient = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.lbStatus = new System.Windows.Forms.Label();
            this.CbCategory = new System.Windows.Forms.ComboBox();
            this.PnLayout1 = new System.Windows.Forms.Panel();
            this.PnControls = new System.Windows.Forms.Panel();
            this.BtnInsertANewProduct = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lbPrice = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lbProductName = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lbDescription = new System.Windows.Forms.Label();
            this.lbCategory = new System.Windows.Forms.Label();
            this.txtImage = new System.Windows.Forms.TextBox();
            this.lbImage = new System.Windows.Forms.Label();
            this.PnHeader.SuspendLayout();
            this.PnInformation.SuspendLayout();
            this.PnControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnHeader
            // 
            this.PnHeader.Controls.Add(this.LbHeader);
            this.PnHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnHeader.Location = new System.Drawing.Point(0, 0);
            this.PnHeader.Name = "PnHeader";
            this.PnHeader.Size = new System.Drawing.Size(650, 77);
            this.PnHeader.TabIndex = 1;
            // 
            // LbHeader
            // 
            this.LbHeader.AutoSize = true;
            this.LbHeader.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbHeader.ForeColor = System.Drawing.Color.Orange;
            this.LbHeader.Location = new System.Drawing.Point(151, 20);
            this.LbHeader.Name = "LbHeader";
            this.LbHeader.Size = new System.Drawing.Size(335, 45);
            this.LbHeader.TabIndex = 0;
            this.LbHeader.Text = "Insert A New Product";
            // 
            // PnInformation
            // 
            this.PnInformation.Controls.Add(this.btnSelectIngredient);
            this.PnInformation.Controls.Add(this.label1);
            this.PnInformation.Controls.Add(this.cbStatus);
            this.PnInformation.Controls.Add(this.lbStatus);
            this.PnInformation.Controls.Add(this.CbCategory);
            this.PnInformation.Controls.Add(this.PnLayout1);
            this.PnInformation.Controls.Add(this.PnControls);
            this.PnInformation.Controls.Add(this.txtPrice);
            this.PnInformation.Controls.Add(this.lbPrice);
            this.PnInformation.Controls.Add(this.txtProductName);
            this.PnInformation.Controls.Add(this.lbProductName);
            this.PnInformation.Controls.Add(this.txtDescription);
            this.PnInformation.Controls.Add(this.lbDescription);
            this.PnInformation.Controls.Add(this.lbCategory);
            this.PnInformation.Controls.Add(this.txtImage);
            this.PnInformation.Controls.Add(this.lbImage);
            this.PnInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnInformation.Location = new System.Drawing.Point(0, 77);
            this.PnInformation.Name = "PnInformation";
            this.PnInformation.Size = new System.Drawing.Size(650, 634);
            this.PnInformation.TabIndex = 3;
            // 
            // btnSelectIngredient
            // 
            this.btnSelectIngredient.IconChar = FontAwesome.Sharp.IconChar.Lemon;
            this.btnSelectIngredient.IconColor = System.Drawing.Color.Black;
            this.btnSelectIngredient.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSelectIngredient.IconSize = 25;
            this.btnSelectIngredient.Location = new System.Drawing.Point(236, 318);
            this.btnSelectIngredient.Name = "btnSelectIngredient";
            this.btnSelectIngredient.Size = new System.Drawing.Size(166, 35);
            this.btnSelectIngredient.TabIndex = 22;
            this.btnSelectIngredient.Text = "Select Ingredient";
            this.btnSelectIngredient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSelectIngredient.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(67, 322);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 21;
            this.label1.Text = "Ingredient: ";
            // 
            // cbStatus
            // 
            this.cbStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbStatus.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(236, 249);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(338, 32);
            this.cbStatus.TabIndex = 20;
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbStatus.Location = new System.Drawing.Point(67, 252);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(62, 24);
            this.lbStatus.TabIndex = 19;
            this.lbStatus.Text = "Status";
            // 
            // CbCategory
            // 
            this.CbCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CbCategory.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CbCategory.FormattingEnabled = true;
            this.CbCategory.Location = new System.Drawing.Point(236, 189);
            this.CbCategory.Name = "CbCategory";
            this.CbCategory.Size = new System.Drawing.Size(338, 32);
            this.CbCategory.TabIndex = 18;
            // 
            // PnLayout1
            // 
            this.PnLayout1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(113)))), ((int)(((byte)(36)))));
            this.PnLayout1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnLayout1.Location = new System.Drawing.Point(0, 515);
            this.PnLayout1.Name = "PnLayout1";
            this.PnLayout1.Size = new System.Drawing.Size(650, 1);
            this.PnLayout1.TabIndex = 11;
            // 
            // PnControls
            // 
            this.PnControls.Controls.Add(this.BtnInsertANewProduct);
            this.PnControls.Controls.Add(this.BtnCancel);
            this.PnControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnControls.Location = new System.Drawing.Point(0, 516);
            this.PnControls.Name = "PnControls";
            this.PnControls.Size = new System.Drawing.Size(650, 118);
            this.PnControls.TabIndex = 10;
            // 
            // BtnInsertANewProduct
            // 
            this.BtnInsertANewProduct.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnInsertANewProduct.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnInsertANewProduct.Location = new System.Drawing.Point(366, 40);
            this.BtnInsertANewProduct.Name = "BtnInsertANewProduct";
            this.BtnInsertANewProduct.Size = new System.Drawing.Size(162, 39);
            this.BtnInsertANewProduct.TabIndex = 5;
            this.BtnInsertANewProduct.Text = "Insert";
            this.BtnInsertANewProduct.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnCancel.Location = new System.Drawing.Point(123, 40);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(162, 39);
            this.BtnCancel.TabIndex = 4;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPrice.Location = new System.Drawing.Point(236, 76);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PasswordChar = '*';
            this.txtPrice.Size = new System.Drawing.Size(338, 32);
            this.txtPrice.TabIndex = 2;
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbPrice.Location = new System.Drawing.Point(67, 84);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(55, 24);
            this.lbPrice.TabIndex = 8;
            this.lbPrice.Text = "Price:";
            // 
            // txtProductName
            // 
            this.txtProductName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtProductName.Location = new System.Drawing.Point(236, 23);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(338, 32);
            this.txtProductName.TabIndex = 1;
            // 
            // lbProductName
            // 
            this.lbProductName.AutoSize = true;
            this.lbProductName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbProductName.Location = new System.Drawing.Point(67, 31);
            this.lbProductName.Name = "lbProductName";
            this.lbProductName.Size = new System.Drawing.Size(139, 24);
            this.lbProductName.TabIndex = 6;
            this.lbProductName.Text = "Product Name: ";
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDescription.Location = new System.Drawing.Point(236, 385);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(338, 104);
            this.txtDescription.TabIndex = 5;
            // 
            // lbDescription
            // 
            this.lbDescription.AutoSize = true;
            this.lbDescription.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbDescription.Location = new System.Drawing.Point(67, 393);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(109, 24);
            this.lbDescription.TabIndex = 4;
            this.lbDescription.Text = "Description:";
            // 
            // lbCategory
            // 
            this.lbCategory.AutoSize = true;
            this.lbCategory.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbCategory.Location = new System.Drawing.Point(67, 192);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(84, 24);
            this.lbCategory.TabIndex = 2;
            this.lbCategory.Text = "Category";
            // 
            // txtImage
            // 
            this.txtImage.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtImage.Location = new System.Drawing.Point(236, 125);
            this.txtImage.Name = "txtImage";
            this.txtImage.Size = new System.Drawing.Size(338, 32);
            this.txtImage.TabIndex = 3;
            // 
            // lbImage
            // 
            this.lbImage.AutoSize = true;
            this.lbImage.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbImage.Location = new System.Drawing.Point(67, 133);
            this.lbImage.Name = "lbImage";
            this.lbImage.Size = new System.Drawing.Size(135, 24);
            this.lbImage.TabIndex = 0;
            this.lbImage.Text = "Image resouce:";
            // 
            // FrmAdminInsertNewProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 711);
            this.Controls.Add(this.PnInformation);
            this.Controls.Add(this.PnHeader);
            this.Name = "FrmAdminInsertNewProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create Product";
            this.PnHeader.ResumeLayout(false);
            this.PnHeader.PerformLayout();
            this.PnInformation.ResumeLayout(false);
            this.PnInformation.PerformLayout();
            this.PnControls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnHeader;
        private System.Windows.Forms.Label LbHeader;
        private System.Windows.Forms.Panel PnInformation;
        private System.Windows.Forms.Panel PnLayout1;
        private System.Windows.Forms.Panel PnControls;
        private System.Windows.Forms.Button BtnInsertANewProduct;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lbProductName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.Label lbCategory;
        private System.Windows.Forms.TextBox txtImage;
        private System.Windows.Forms.Label lbImage;
        private System.Windows.Forms.ComboBox CbCategory;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label lbStatus;
        private FontAwesome.Sharp.IconButton btnSelectIngredient;
        private System.Windows.Forms.Label label1;
    }
}