namespace CoffeeManagement
{
    partial class FrmAdminDashboard
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
            this.PnDashBoard = new System.Windows.Forms.Panel();
            this.btnLogout = new FontAwesome.Sharp.IconButton();
            this.btnStorage = new FontAwesome.Sharp.IconButton();
            this.btnAccount = new FontAwesome.Sharp.IconButton();
            this.btnProduct = new FontAwesome.Sharp.IconButton();
            this.btnInvoiceHistory = new FontAwesome.Sharp.IconButton();
            this.PnLogo = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.PicLogo = new System.Windows.Forms.PictureBox();
            this.PnHeader = new System.Windows.Forms.Panel();
            this.PicIconControlHeader = new FontAwesome.Sharp.IconPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LbWelcomeHeader = new System.Windows.Forms.Label();
            this.LbControlHeader = new System.Windows.Forms.Label();
            this.PnChildForm = new System.Windows.Forms.Panel();
            this.PnDashBoard.SuspendLayout();
            this.PnLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).BeginInit();
            this.PnHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicIconControlHeader)).BeginInit();
            this.SuspendLayout();
            // 
            // PnDashBoard
            // 
            this.PnDashBoard.BackColor = System.Drawing.Color.LemonChiffon;
            this.PnDashBoard.Controls.Add(this.btnLogout);
            this.PnDashBoard.Controls.Add(this.btnStorage);
            this.PnDashBoard.Controls.Add(this.btnAccount);
            this.PnDashBoard.Controls.Add(this.btnProduct);
            this.PnDashBoard.Controls.Add(this.btnInvoiceHistory);
            this.PnDashBoard.Controls.Add(this.PnLogo);
            this.PnDashBoard.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnDashBoard.Location = new System.Drawing.Point(0, 0);
            this.PnDashBoard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PnDashBoard.Name = "PnDashBoard";
            this.PnDashBoard.Size = new System.Drawing.Size(219, 525);
            this.PnDashBoard.TabIndex = 4;
            // 
            // btnLogout
            // 
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogout.ForeColor = System.Drawing.Color.Black;
            this.btnLogout.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnLogout.IconColor = System.Drawing.Color.Black;
            this.btnLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 308);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(9, 0, 18, 0);
            this.btnLogout.Size = new System.Drawing.Size(219, 49);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Log out";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnStorage
            // 
            this.btnStorage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStorage.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStorage.FlatAppearance.BorderSize = 0;
            this.btnStorage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStorage.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnStorage.ForeColor = System.Drawing.Color.Black;
            this.btnStorage.IconChar = FontAwesome.Sharp.IconChar.Store;
            this.btnStorage.IconColor = System.Drawing.Color.Black;
            this.btnStorage.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnStorage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStorage.Location = new System.Drawing.Point(0, 259);
            this.btnStorage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStorage.Name = "btnStorage";
            this.btnStorage.Padding = new System.Windows.Forms.Padding(9, 0, 18, 0);
            this.btnStorage.Size = new System.Drawing.Size(219, 49);
            this.btnStorage.TabIndex = 6;
            this.btnStorage.Text = "Storage";
            this.btnStorage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStorage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStorage.UseVisualStyleBackColor = true;
            this.btnStorage.Click += new System.EventHandler(this.btnStorage_Click);
            // 
            // btnAccount
            // 
            this.btnAccount.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAccount.FlatAppearance.BorderSize = 0;
            this.btnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccount.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAccount.ForeColor = System.Drawing.Color.Black;
            this.btnAccount.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btnAccount.IconColor = System.Drawing.Color.Black;
            this.btnAccount.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccount.Location = new System.Drawing.Point(0, 210);
            this.btnAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Padding = new System.Windows.Forms.Padding(9, 0, 18, 0);
            this.btnAccount.Size = new System.Drawing.Size(219, 49);
            this.btnAccount.TabIndex = 4;
            this.btnAccount.Text = "Account";
            this.btnAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAccount.UseVisualStyleBackColor = false;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProduct.FlatAppearance.BorderSize = 0;
            this.btnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduct.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnProduct.ForeColor = System.Drawing.Color.Black;
            this.btnProduct.IconChar = FontAwesome.Sharp.IconChar.MugHot;
            this.btnProduct.IconColor = System.Drawing.Color.Black;
            this.btnProduct.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduct.Location = new System.Drawing.Point(0, 161);
            this.btnProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Padding = new System.Windows.Forms.Padding(9, 0, 18, 0);
            this.btnProduct.Size = new System.Drawing.Size(219, 49);
            this.btnProduct.TabIndex = 3;
            this.btnProduct.Text = "Product";
            this.btnProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProduct.UseVisualStyleBackColor = false;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnInvoiceHistory
            // 
            this.btnInvoiceHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInvoiceHistory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInvoiceHistory.FlatAppearance.BorderSize = 0;
            this.btnInvoiceHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInvoiceHistory.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnInvoiceHistory.ForeColor = System.Drawing.Color.Black;
            this.btnInvoiceHistory.IconChar = FontAwesome.Sharp.IconChar.History;
            this.btnInvoiceHistory.IconColor = System.Drawing.Color.Black;
            this.btnInvoiceHistory.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInvoiceHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInvoiceHistory.Location = new System.Drawing.Point(0, 112);
            this.btnInvoiceHistory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInvoiceHistory.Name = "btnInvoiceHistory";
            this.btnInvoiceHistory.Padding = new System.Windows.Forms.Padding(9, 0, 18, 0);
            this.btnInvoiceHistory.Size = new System.Drawing.Size(219, 49);
            this.btnInvoiceHistory.TabIndex = 2;
            this.btnInvoiceHistory.Text = "Invoice History";
            this.btnInvoiceHistory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInvoiceHistory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInvoiceHistory.UseVisualStyleBackColor = true;
            this.btnInvoiceHistory.Click += new System.EventHandler(this.btnInvoiceHistory_Click);
            // 
            // PnLogo
            // 
            this.PnLogo.BackColor = System.Drawing.Color.Khaki;
            this.PnLogo.Controls.Add(this.label2);
            this.PnLogo.Controls.Add(this.PicLogo);
            this.PnLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnLogo.Location = new System.Drawing.Point(0, 0);
            this.PnLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PnLogo.Name = "PnLogo";
            this.PnLogo.Size = new System.Drawing.Size(219, 112);
            this.PnLogo.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(71, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 74);
            this.label2.TabIndex = 1;
            this.label2.Text = "Camasy Cafe \r\n   Manager";
            // 
            // PicLogo
            // 
            this.PicLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicLogo.Image = global::CoffeeManagement.Properties.Resources.cafe_11;
            this.PicLogo.InitialImage = null;
            this.PicLogo.Location = new System.Drawing.Point(3, 33);
            this.PicLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PicLogo.Name = "PicLogo";
            this.PicLogo.Size = new System.Drawing.Size(72, 54);
            this.PicLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicLogo.TabIndex = 0;
            this.PicLogo.TabStop = false;
            // 
            // PnHeader
            // 
            this.PnHeader.BackColor = System.Drawing.Color.LightSlateGray;
            this.PnHeader.Controls.Add(this.PicIconControlHeader);
            this.PnHeader.Controls.Add(this.label1);
            this.PnHeader.Controls.Add(this.LbWelcomeHeader);
            this.PnHeader.Controls.Add(this.LbControlHeader);
            this.PnHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnHeader.Location = new System.Drawing.Point(219, 0);
            this.PnHeader.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PnHeader.Name = "PnHeader";
            this.PnHeader.Size = new System.Drawing.Size(931, 44);
            this.PnHeader.TabIndex = 5;
            // 
            // PicIconControlHeader
            // 
            this.PicIconControlHeader.BackColor = System.Drawing.Color.LightSlateGray;
            this.PicIconControlHeader.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PicIconControlHeader.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.PicIconControlHeader.IconColor = System.Drawing.SystemColors.ControlText;
            this.PicIconControlHeader.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.PicIconControlHeader.IconSize = 30;
            this.PicIconControlHeader.Location = new System.Drawing.Point(16, 12);
            this.PicIconControlHeader.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PicIconControlHeader.Name = "PicIconControlHeader";
            this.PicIconControlHeader.Size = new System.Drawing.Size(35, 30);
            this.PicIconControlHeader.TabIndex = 5;
            this.PicIconControlHeader.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(850, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "ADMIN";
            // 
            // LbWelcomeHeader
            // 
            this.LbWelcomeHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LbWelcomeHeader.AutoSize = true;
            this.LbWelcomeHeader.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbWelcomeHeader.Location = new System.Drawing.Point(1630, 14);
            this.LbWelcomeHeader.Name = "LbWelcomeHeader";
            this.LbWelcomeHeader.Size = new System.Drawing.Size(142, 19);
            this.LbWelcomeHeader.TabIndex = 3;
            this.LbWelcomeHeader.Text = "Welcome, Full Name";
            // 
            // LbControlHeader
            // 
            this.LbControlHeader.AutoSize = true;
            this.LbControlHeader.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbControlHeader.Location = new System.Drawing.Point(57, 16);
            this.LbControlHeader.Name = "LbControlHeader";
            this.LbControlHeader.Size = new System.Drawing.Size(47, 19);
            this.LbControlHeader.TabIndex = 1;
            this.LbControlHeader.Text = "Home";
            // 
            // PnChildForm
            // 
            this.PnChildForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PnChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnChildForm.Location = new System.Drawing.Point(219, 44);
            this.PnChildForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PnChildForm.Name = "PnChildForm";
            this.PnChildForm.Size = new System.Drawing.Size(931, 481);
            this.PnChildForm.TabIndex = 6;
            // 
            // FrmAdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 525);
            this.Controls.Add(this.PnChildForm);
            this.Controls.Add(this.PnHeader);
            this.Controls.Add(this.PnDashBoard);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmAdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Home";
            this.PnDashBoard.ResumeLayout(false);
            this.PnLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).EndInit();
            this.PnHeader.ResumeLayout(false);
            this.PnHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicIconControlHeader)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnDashBoard;
        private System.Windows.Forms.Panel PnHeader;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconPictureBox PicIconControlHeader;
        private FontAwesome.Sharp.IconButton btnInvoiceHistory;
        private System.Windows.Forms.Label LbWelcomeHeader;
        private System.Windows.Forms.Label LbControlHeader;
        private System.Windows.Forms.Panel PnChildForm;
        private FontAwesome.Sharp.IconButton btnLogout;
        private FontAwesome.Sharp.IconButton btnStorage;
        private FontAwesome.Sharp.IconButton btnAccount;
        private FontAwesome.Sharp.IconButton btnProduct;
        private System.Windows.Forms.Panel PnLogo;
        private System.Windows.Forms.PictureBox PicLogo;
        private System.Windows.Forms.Label label2;
    }
}