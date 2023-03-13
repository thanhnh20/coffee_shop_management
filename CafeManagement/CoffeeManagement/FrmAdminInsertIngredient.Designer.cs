namespace CoffeeManagement
{
    partial class FrmAdminInsertIngredient
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
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.lbStatus = new System.Windows.Forms.Label();
            this.PnLayout1 = new System.Windows.Forms.Panel();
            this.PnControls = new System.Windows.Forms.Panel();
            this.BtnInsertIngredient = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.lbPrice = new System.Windows.Forms.Label();
            this.txtIngredientName = new System.Windows.Forms.TextBox();
            this.lbIngredientName = new System.Windows.Forms.Label();
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
            this.PnHeader.TabIndex = 2;
            // 
            // LbHeader
            // 
            this.LbHeader.AutoSize = true;
            this.LbHeader.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbHeader.ForeColor = System.Drawing.Color.Orange;
            this.LbHeader.Location = new System.Drawing.Point(151, 20);
            this.LbHeader.Name = "LbHeader";
            this.LbHeader.Size = new System.Drawing.Size(370, 45);
            this.LbHeader.TabIndex = 0;
            this.LbHeader.Text = "Insert A New Ingredient";
            // 
            // PnInformation
            // 
            this.PnInformation.Controls.Add(this.cbStatus);
            this.PnInformation.Controls.Add(this.lbStatus);
            this.PnInformation.Controls.Add(this.PnLayout1);
            this.PnInformation.Controls.Add(this.PnControls);
            this.PnInformation.Controls.Add(this.txtUnit);
            this.PnInformation.Controls.Add(this.lbPrice);
            this.PnInformation.Controls.Add(this.txtIngredientName);
            this.PnInformation.Controls.Add(this.lbIngredientName);
            this.PnInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnInformation.Location = new System.Drawing.Point(0, 77);
            this.PnInformation.Name = "PnInformation";
            this.PnInformation.Size = new System.Drawing.Size(650, 329);
            this.PnInformation.TabIndex = 4;
            // 
            // cbStatus
            // 
            this.cbStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbStatus.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(236, 136);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(338, 32);
            this.cbStatus.TabIndex = 20;
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbStatus.Location = new System.Drawing.Point(67, 144);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(62, 24);
            this.lbStatus.TabIndex = 19;
            this.lbStatus.Text = "Status";
            // 
            // PnLayout1
            // 
            this.PnLayout1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(113)))), ((int)(((byte)(36)))));
            this.PnLayout1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnLayout1.Location = new System.Drawing.Point(0, 210);
            this.PnLayout1.Name = "PnLayout1";
            this.PnLayout1.Size = new System.Drawing.Size(650, 1);
            this.PnLayout1.TabIndex = 11;
            // 
            // PnControls
            // 
            this.PnControls.Controls.Add(this.BtnInsertIngredient);
            this.PnControls.Controls.Add(this.BtnCancel);
            this.PnControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnControls.Location = new System.Drawing.Point(0, 211);
            this.PnControls.Name = "PnControls";
            this.PnControls.Size = new System.Drawing.Size(650, 118);
            this.PnControls.TabIndex = 10;
            // 
            // BtnInsertIngredient
            // 
            this.BtnInsertIngredient.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnInsertIngredient.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnInsertIngredient.Location = new System.Drawing.Point(366, 40);
            this.BtnInsertIngredient.Name = "BtnInsertIngredient";
            this.BtnInsertIngredient.Size = new System.Drawing.Size(162, 39);
            this.BtnInsertIngredient.TabIndex = 5;
            this.BtnInsertIngredient.Text = "Insert";
            this.BtnInsertIngredient.UseVisualStyleBackColor = true;
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
            // txtUnit
            // 
            this.txtUnit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUnit.Location = new System.Drawing.Point(236, 76);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.PasswordChar = '*';
            this.txtUnit.Size = new System.Drawing.Size(338, 32);
            this.txtUnit.TabIndex = 2;
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbPrice.Location = new System.Drawing.Point(67, 84);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(51, 24);
            this.lbPrice.TabIndex = 8;
            this.lbPrice.Text = "Unit:";
            // 
            // txtIngredientName
            // 
            this.txtIngredientName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtIngredientName.Location = new System.Drawing.Point(236, 23);
            this.txtIngredientName.Name = "txtIngredientName";
            this.txtIngredientName.Size = new System.Drawing.Size(338, 32);
            this.txtIngredientName.TabIndex = 1;
            // 
            // lbIngredientName
            // 
            this.lbIngredientName.AutoSize = true;
            this.lbIngredientName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbIngredientName.Location = new System.Drawing.Point(67, 31);
            this.lbIngredientName.Name = "lbIngredientName";
            this.lbIngredientName.Size = new System.Drawing.Size(160, 24);
            this.lbIngredientName.TabIndex = 6;
            this.lbIngredientName.Text = "Ingredient Name: ";
            // 
            // FrmAdminInsertIngredient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 406);
            this.Controls.Add(this.PnInformation);
            this.Controls.Add(this.PnHeader);
            this.Name = "FrmAdminInsertIngredient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create Ingredient";
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
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Panel PnLayout1;
        private System.Windows.Forms.Panel PnControls;
        private System.Windows.Forms.Button BtnInsertIngredient;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.TextBox txtIngredientName;
        private System.Windows.Forms.Label lbIngredientName;
    }
}