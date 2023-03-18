namespace CoffeeManagement
{
    partial class FrmStaffUpdateCustomer
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
            this.PnInformation = new System.Windows.Forms.Panel();
            this.PnHeader = new System.Windows.Forms.Panel();
            this.LbHeader = new System.Windows.Forms.Label();
            this.PnLayoutBottom = new System.Windows.Forms.Panel();
            this.PnControls = new System.Windows.Forms.Panel();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.TxtAddress = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.LbAddress = new System.Windows.Forms.Label();
            this.LbPhonenumber = new System.Windows.Forms.Label();
            this.LbFullName = new System.Windows.Forms.Label();
            this.LbStaffID = new System.Windows.Forms.Label();
            this.PnInformation.SuspendLayout();
            this.PnHeader.SuspendLayout();
            this.PnControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnInformation
            // 
            this.PnInformation.Controls.Add(this.PnHeader);
            this.PnInformation.Controls.Add(this.PnLayoutBottom);
            this.PnInformation.Controls.Add(this.PnControls);
            this.PnInformation.Controls.Add(this.TxtAddress);
            this.PnInformation.Controls.Add(this.txtEmail);
            this.PnInformation.Controls.Add(this.txtName);
            this.PnInformation.Controls.Add(this.txtPhoneNumber);
            this.PnInformation.Controls.Add(this.LbAddress);
            this.PnInformation.Controls.Add(this.LbPhonenumber);
            this.PnInformation.Controls.Add(this.LbFullName);
            this.PnInformation.Controls.Add(this.LbStaffID);
            this.PnInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnInformation.Location = new System.Drawing.Point(0, 0);
            this.PnInformation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PnInformation.Name = "PnInformation";
            this.PnInformation.Size = new System.Drawing.Size(442, 344);
            this.PnInformation.TabIndex = 5;
            // 
            // PnHeader
            // 
            this.PnHeader.Controls.Add(this.LbHeader);
            this.PnHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnHeader.Location = new System.Drawing.Point(0, 0);
            this.PnHeader.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PnHeader.Name = "PnHeader";
            this.PnHeader.Size = new System.Drawing.Size(442, 58);
            this.PnHeader.TabIndex = 22;
            // 
            // LbHeader
            // 
            this.LbHeader.AutoSize = true;
            this.LbHeader.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LbHeader.ForeColor = System.Drawing.Color.Orange;
            this.LbHeader.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LbHeader.Location = new System.Drawing.Point(61, 9);
            this.LbHeader.Name = "LbHeader";
            this.LbHeader.Size = new System.Drawing.Size(325, 37);
            this.LbHeader.TabIndex = 1;
            this.LbHeader.Text = "Update Customer Profile";
            // 
            // PnLayoutBottom
            // 
            this.PnLayoutBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(113)))), ((int)(((byte)(36)))));
            this.PnLayoutBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnLayoutBottom.Location = new System.Drawing.Point(0, 286);
            this.PnLayoutBottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PnLayoutBottom.Name = "PnLayoutBottom";
            this.PnLayoutBottom.Size = new System.Drawing.Size(442, 1);
            this.PnLayoutBottom.TabIndex = 21;
            // 
            // PnControls
            // 
            this.PnControls.Controls.Add(this.BtnUpdate);
            this.PnControls.Controls.Add(this.BtnCancel);
            this.PnControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnControls.Location = new System.Drawing.Point(0, 287);
            this.PnControls.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PnControls.Name = "PnControls";
            this.PnControls.Size = new System.Drawing.Size(442, 57);
            this.PnControls.TabIndex = 20;
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUpdate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnUpdate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnUpdate.Location = new System.Drawing.Point(264, 11);
            this.BtnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(142, 29);
            this.BtnUpdate.TabIndex = 1;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnCancel.Location = new System.Drawing.Point(52, 11);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(142, 29);
            this.BtnCancel.TabIndex = 0;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // TxtAddress
            // 
            this.TxtAddress.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtAddress.Location = new System.Drawing.Point(161, 189);
            this.TxtAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtAddress.Multiline = true;
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.Size = new System.Drawing.Size(249, 76);
            this.TxtAddress.TabIndex = 15;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.Location = new System.Drawing.Point(161, 147);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(249, 27);
            this.txtEmail.TabIndex = 12;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtName.Location = new System.Drawing.Point(161, 110);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(246, 27);
            this.txtName.TabIndex = 11;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Enabled = false;
            this.txtPhoneNumber.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPhoneNumber.Location = new System.Drawing.Point(161, 74);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPhoneNumber.MaxLength = 10;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.ReadOnly = true;
            this.txtPhoneNumber.Size = new System.Drawing.Size(249, 27);
            this.txtPhoneNumber.TabIndex = 10;
            // 
            // LbAddress
            // 
            this.LbAddress.AutoSize = true;
            this.LbAddress.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbAddress.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LbAddress.Location = new System.Drawing.Point(10, 189);
            this.LbAddress.Name = "LbAddress";
            this.LbAddress.Size = new System.Drawing.Size(69, 19);
            this.LbAddress.TabIndex = 9;
            this.LbAddress.Text = "Address: ";
            // 
            // LbPhonenumber
            // 
            this.LbPhonenumber.AutoSize = true;
            this.LbPhonenumber.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbPhonenumber.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LbPhonenumber.Location = new System.Drawing.Point(10, 153);
            this.LbPhonenumber.Name = "LbPhonenumber";
            this.LbPhonenumber.Size = new System.Drawing.Size(49, 19);
            this.LbPhonenumber.TabIndex = 3;
            this.LbPhonenumber.Text = "Email:";
            // 
            // LbFullName
            // 
            this.LbFullName.AutoSize = true;
            this.LbFullName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbFullName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LbFullName.Location = new System.Drawing.Point(10, 80);
            this.LbFullName.Name = "LbFullName";
            this.LbFullName.Size = new System.Drawing.Size(108, 19);
            this.LbFullName.TabIndex = 0;
            this.LbFullName.Text = "Phone Number:";
            // 
            // LbStaffID
            // 
            this.LbStaffID.AutoSize = true;
            this.LbStaffID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbStaffID.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LbStaffID.Location = new System.Drawing.Point(10, 116);
            this.LbStaffID.Name = "LbStaffID";
            this.LbStaffID.Size = new System.Drawing.Size(113, 19);
            this.LbStaffID.TabIndex = 2;
            this.LbStaffID.Text = "Customer Name";
            // 
            // FrmStaffUpdateCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 344);
            this.Controls.Add(this.PnInformation);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmStaffUpdateCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Update Existing Customer";
            this.PnInformation.ResumeLayout(false);
            this.PnInformation.PerformLayout();
            this.PnHeader.ResumeLayout(false);
            this.PnHeader.PerformLayout();
            this.PnControls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnInformation;
        private System.Windows.Forms.Panel PnHeader;
        private System.Windows.Forms.Label LbHeader;
        private System.Windows.Forms.Panel PnLayoutBottom;
        private System.Windows.Forms.Panel PnControls;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.TextBox TxtAddress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label LbAddress;
        private System.Windows.Forms.Label LbPhonenumber;
        private System.Windows.Forms.Label LbFullName;
        private System.Windows.Forms.Label LbStaffID;
        private System.Windows.Forms.TextBox txtEmail;
    }
}