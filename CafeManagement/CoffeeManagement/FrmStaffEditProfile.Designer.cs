namespace CoffeeManagement
{
    partial class FrmStaffEditProfile
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
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.PnHeader = new System.Windows.Forms.Panel();
            this.LbHeader = new System.Windows.Forms.Label();
            this.PnLayoutBottom = new System.Windows.Forms.Panel();
            this.PnControls = new System.Windows.Forms.Panel();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.MtxtDateOfBirth = new System.Windows.Forms.MaskedTextBox();
            this.TxtAddress = new System.Windows.Forms.TextBox();
            this.TxtTaxCode = new System.Windows.Forms.TextBox();
            this.TxtPhoneNumber = new System.Windows.Forms.TextBox();
            this.TxtStaffID = new System.Windows.Forms.TextBox();
            this.TxtFullName = new System.Windows.Forms.TextBox();
            this.LbAddress = new System.Windows.Forms.Label();
            this.LbTaxCode = new System.Windows.Forms.Label();
            this.LbSalary = new System.Windows.Forms.Label();
            this.LbDateOfBirth = new System.Windows.Forms.Label();
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
            this.PnInformation.Controls.Add(this.txtSalary);
            this.PnInformation.Controls.Add(this.PnHeader);
            this.PnInformation.Controls.Add(this.PnLayoutBottom);
            this.PnInformation.Controls.Add(this.PnControls);
            this.PnInformation.Controls.Add(this.MtxtDateOfBirth);
            this.PnInformation.Controls.Add(this.TxtAddress);
            this.PnInformation.Controls.Add(this.TxtTaxCode);
            this.PnInformation.Controls.Add(this.TxtPhoneNumber);
            this.PnInformation.Controls.Add(this.TxtStaffID);
            this.PnInformation.Controls.Add(this.TxtFullName);
            this.PnInformation.Controls.Add(this.LbAddress);
            this.PnInformation.Controls.Add(this.LbTaxCode);
            this.PnInformation.Controls.Add(this.LbSalary);
            this.PnInformation.Controls.Add(this.LbDateOfBirth);
            this.PnInformation.Controls.Add(this.LbPhonenumber);
            this.PnInformation.Controls.Add(this.LbFullName);
            this.PnInformation.Controls.Add(this.LbStaffID);
            this.PnInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnInformation.Location = new System.Drawing.Point(0, 0);
            this.PnInformation.Name = "PnInformation";
            this.PnInformation.Size = new System.Drawing.Size(505, 589);
            this.PnInformation.TabIndex = 4;
            // 
            // txtSalary
            // 
            this.txtSalary.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSalary.Location = new System.Drawing.Point(184, 288);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.PasswordChar = '*';
            this.txtSalary.Size = new System.Drawing.Size(284, 32);
            this.txtSalary.TabIndex = 14;
            // 
            // PnHeader
            // 
            this.PnHeader.Controls.Add(this.LbHeader);
            this.PnHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnHeader.Location = new System.Drawing.Point(0, 0);
            this.PnHeader.Name = "PnHeader";
            this.PnHeader.Size = new System.Drawing.Size(505, 78);
            this.PnHeader.TabIndex = 22;
            // 
            // LbHeader
            // 
            this.LbHeader.AutoSize = true;
            this.LbHeader.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LbHeader.ForeColor = System.Drawing.Color.Orange;
            this.LbHeader.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LbHeader.Location = new System.Drawing.Point(158, 19);
            this.LbHeader.Name = "LbHeader";
            this.LbHeader.Size = new System.Drawing.Size(200, 45);
            this.LbHeader.TabIndex = 1;
            this.LbHeader.Text = "Staff Profile";
            // 
            // PnLayoutBottom
            // 
            this.PnLayoutBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(113)))), ((int)(((byte)(36)))));
            this.PnLayoutBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnLayoutBottom.Location = new System.Drawing.Point(0, 512);
            this.PnLayoutBottom.Name = "PnLayoutBottom";
            this.PnLayoutBottom.Size = new System.Drawing.Size(505, 1);
            this.PnLayoutBottom.TabIndex = 21;
            // 
            // PnControls
            // 
            this.PnControls.Controls.Add(this.BtnUpdate);
            this.PnControls.Controls.Add(this.BtnCancel);
            this.PnControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnControls.Location = new System.Drawing.Point(0, 513);
            this.PnControls.Name = "PnControls";
            this.PnControls.Size = new System.Drawing.Size(505, 76);
            this.PnControls.TabIndex = 20;
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUpdate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnUpdate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnUpdate.Location = new System.Drawing.Point(302, 15);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(162, 39);
            this.BtnUpdate.TabIndex = 1;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnCancel.Location = new System.Drawing.Point(59, 15);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(162, 39);
            this.BtnCancel.TabIndex = 0;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // MtxtDateOfBirth
            // 
            this.MtxtDateOfBirth.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MtxtDateOfBirth.Location = new System.Drawing.Point(184, 330);
            this.MtxtDateOfBirth.Mask = "00/00/0000";
            this.MtxtDateOfBirth.Name = "MtxtDateOfBirth";
            this.MtxtDateOfBirth.Size = new System.Drawing.Size(183, 32);
            this.MtxtDateOfBirth.TabIndex = 17;
            this.MtxtDateOfBirth.ValidatingType = typeof(System.DateTime);
            // 
            // TxtAddress
            // 
            this.TxtAddress.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtAddress.Location = new System.Drawing.Point(184, 385);
            this.TxtAddress.Multiline = true;
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.Size = new System.Drawing.Size(284, 100);
            this.TxtAddress.TabIndex = 15;
            // 
            // TxtTaxCode
            // 
            this.TxtTaxCode.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtTaxCode.Location = new System.Drawing.Point(184, 243);
            this.TxtTaxCode.Name = "TxtTaxCode";
            this.TxtTaxCode.PasswordChar = '*';
            this.TxtTaxCode.Size = new System.Drawing.Size(284, 32);
            this.TxtTaxCode.TabIndex = 13;
            // 
            // TxtPhoneNumber
            // 
            this.TxtPhoneNumber.Enabled = false;
            this.TxtPhoneNumber.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtPhoneNumber.Location = new System.Drawing.Point(184, 196);
            this.TxtPhoneNumber.Name = "TxtPhoneNumber";
            this.TxtPhoneNumber.Size = new System.Drawing.Size(284, 32);
            this.TxtPhoneNumber.TabIndex = 12;
            // 
            // TxtStaffID
            // 
            this.TxtStaffID.Enabled = false;
            this.TxtStaffID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtStaffID.Location = new System.Drawing.Point(184, 146);
            this.TxtStaffID.Name = "TxtStaffID";
            this.TxtStaffID.Size = new System.Drawing.Size(202, 32);
            this.TxtStaffID.TabIndex = 11;
            // 
            // TxtFullName
            // 
            this.TxtFullName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtFullName.Location = new System.Drawing.Point(184, 98);
            this.TxtFullName.Name = "TxtFullName";
            this.TxtFullName.Size = new System.Drawing.Size(284, 32);
            this.TxtFullName.TabIndex = 10;
            // 
            // LbAddress
            // 
            this.LbAddress.AutoSize = true;
            this.LbAddress.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbAddress.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LbAddress.Location = new System.Drawing.Point(12, 385);
            this.LbAddress.Name = "LbAddress";
            this.LbAddress.Size = new System.Drawing.Size(87, 24);
            this.LbAddress.TabIndex = 9;
            this.LbAddress.Text = "Address: ";
            // 
            // LbTaxCode
            // 
            this.LbTaxCode.AutoSize = true;
            this.LbTaxCode.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbTaxCode.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LbTaxCode.Location = new System.Drawing.Point(12, 251);
            this.LbTaxCode.Name = "LbTaxCode";
            this.LbTaxCode.Size = new System.Drawing.Size(95, 24);
            this.LbTaxCode.TabIndex = 6;
            this.LbTaxCode.Text = "Tax Code: ";
            // 
            // LbSalary
            // 
            this.LbSalary.AutoSize = true;
            this.LbSalary.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbSalary.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LbSalary.Location = new System.Drawing.Point(12, 296);
            this.LbSalary.Name = "LbSalary";
            this.LbSalary.Size = new System.Drawing.Size(65, 24);
            this.LbSalary.TabIndex = 5;
            this.LbSalary.Text = "Salary:";
            // 
            // LbDateOfBirth
            // 
            this.LbDateOfBirth.AutoSize = true;
            this.LbDateOfBirth.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbDateOfBirth.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LbDateOfBirth.Location = new System.Drawing.Point(12, 338);
            this.LbDateOfBirth.Name = "LbDateOfBirth";
            this.LbDateOfBirth.Size = new System.Drawing.Size(127, 24);
            this.LbDateOfBirth.TabIndex = 4;
            this.LbDateOfBirth.Text = "Date of Birth: ";
            // 
            // LbPhonenumber
            // 
            this.LbPhonenumber.AutoSize = true;
            this.LbPhonenumber.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbPhonenumber.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LbPhonenumber.Location = new System.Drawing.Point(12, 204);
            this.LbPhonenumber.Name = "LbPhonenumber";
            this.LbPhonenumber.Size = new System.Drawing.Size(146, 24);
            this.LbPhonenumber.TabIndex = 3;
            this.LbPhonenumber.Text = "Phone Number: ";
            // 
            // LbFullName
            // 
            this.LbFullName.AutoSize = true;
            this.LbFullName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbFullName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LbFullName.Location = new System.Drawing.Point(12, 106);
            this.LbFullName.Name = "LbFullName";
            this.LbFullName.Size = new System.Drawing.Size(104, 24);
            this.LbFullName.TabIndex = 0;
            this.LbFullName.Text = "Full Name: ";
            // 
            // LbStaffID
            // 
            this.LbStaffID.AutoSize = true;
            this.LbStaffID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbStaffID.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LbStaffID.Location = new System.Drawing.Point(12, 154);
            this.LbStaffID.Name = "LbStaffID";
            this.LbStaffID.Size = new System.Drawing.Size(92, 24);
            this.LbStaffID.TabIndex = 2;
            this.LbStaffID.Text = "Staff\'s ID: ";
            // 
            // FrmStaffEditProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 589);
            this.Controls.Add(this.PnInformation);
            this.Name = "FrmStaffEditProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Staff Profile";
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
        private System.Windows.Forms.MaskedTextBox MtxtDateOfBirth;
        private System.Windows.Forms.TextBox TxtAddress;
        private System.Windows.Forms.TextBox TxtTaxCode;
        private System.Windows.Forms.TextBox TxtPhoneNumber;
        private System.Windows.Forms.TextBox TxtStaffID;
        private System.Windows.Forms.TextBox TxtFullName;
        private System.Windows.Forms.Label LbAddress;
        private System.Windows.Forms.Label LbTaxCode;
        private System.Windows.Forms.Label LbSalary;
        private System.Windows.Forms.Label LbDateOfBirth;
        private System.Windows.Forms.Label LbPhonenumber;
        private System.Windows.Forms.Label LbFullName;
        private System.Windows.Forms.Label LbStaffID;
        private System.Windows.Forms.TextBox txtSalary;
    }
}