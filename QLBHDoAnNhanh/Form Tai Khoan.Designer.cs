namespace QLQCAFE
{
    partial class Form2
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.panel28 = new System.Windows.Forms.Panel();
            this.btnShowAccount = new System.Windows.Forms.Button();
            this.btnEditAccount = new System.Windows.Forms.Button();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.panel23 = new System.Windows.Forms.Panel();
            this.btnResetPassword = new System.Windows.Forms.Button();
            this.panel25 = new System.Windows.Forms.Panel();
            this.cbAccountType = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel26 = new System.Windows.Forms.Panel();
            this.txbDisplayName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel27 = new System.Windows.Forms.Panel();
            this.txbUserName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.panel28.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            this.panel23.SuspendLayout();
            this.panel25.SuspendLayout();
            this.panel26.SuspendLayout();
            this.panel27.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel28
            // 
            this.panel28.Controls.Add(this.btnShowAccount);
            this.panel28.Controls.Add(this.btnEditAccount);
            this.panel28.Controls.Add(this.btnDeleteAccount);
            this.panel28.Controls.Add(this.btnAddAccount);
            this.panel28.Location = new System.Drawing.Point(3, 227);
            this.panel28.Name = "panel28";
            this.panel28.Size = new System.Drawing.Size(315, 52);
            this.panel28.TabIndex = 6;
            // 
            // btnShowAccount
            // 
            this.btnShowAccount.Location = new System.Drawing.Point(246, 3);
            this.btnShowAccount.Name = "btnShowAccount";
            this.btnShowAccount.Size = new System.Drawing.Size(69, 46);
            this.btnShowAccount.TabIndex = 3;
            this.btnShowAccount.Text = "Xem";
            this.btnShowAccount.UseVisualStyleBackColor = true;
            // 
            // btnEditAccount
            // 
            this.btnEditAccount.Location = new System.Drawing.Point(165, 3);
            this.btnEditAccount.Name = "btnEditAccount";
            this.btnEditAccount.Size = new System.Drawing.Size(75, 46);
            this.btnEditAccount.TabIndex = 2;
            this.btnEditAccount.Text = "Sửa";
            this.btnEditAccount.UseVisualStyleBackColor = true;
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.Location = new System.Drawing.Point(84, 3);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(75, 46);
            this.btnDeleteAccount.TabIndex = 1;
            this.btnDeleteAccount.Text = "Xóa";
            this.btnDeleteAccount.UseVisualStyleBackColor = true;
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.Location = new System.Drawing.Point(3, 3);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(75, 46);
            this.btnAddAccount.TabIndex = 0;
            this.btnAddAccount.Text = "Thêm";
            this.btnAddAccount.UseVisualStyleBackColor = true;
            // 
            // radGridView1
            // 
            this.radGridView1.Location = new System.Drawing.Point(12, 70);
            // 
            // 
            // 
            this.radGridView1.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.Size = new System.Drawing.Size(343, 340);
            this.radGridView1.TabIndex = 7;
            // 
            // panel23
            // 
            this.panel23.Controls.Add(this.btnResetPassword);
            this.panel23.Controls.Add(this.panel25);
            this.panel23.Controls.Add(this.panel28);
            this.panel23.Controls.Add(this.panel26);
            this.panel23.Controls.Add(this.panel27);
            this.panel23.Location = new System.Drawing.Point(361, 70);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(333, 346);
            this.panel23.TabIndex = 8;
            // 
            // btnResetPassword
            // 
            this.btnResetPassword.Location = new System.Drawing.Point(130, 153);
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.Size = new System.Drawing.Size(75, 46);
            this.btnResetPassword.TabIndex = 4;
            this.btnResetPassword.Text = "Đặt lại mật khẩu";
            this.btnResetPassword.UseVisualStyleBackColor = true;
            // 
            // panel25
            // 
            this.panel25.Controls.Add(this.cbAccountType);
            this.panel25.Controls.Add(this.label11);
            this.panel25.Location = new System.Drawing.Point(3, 103);
            this.panel25.Name = "panel25";
            this.panel25.Size = new System.Drawing.Size(315, 44);
            this.panel25.TabIndex = 3;
            // 
            // cbAccountType
            // 
            this.cbAccountType.FormattingEnabled = true;
            this.cbAccountType.Location = new System.Drawing.Point(127, 9);
            this.cbAccountType.Name = "cbAccountType";
            this.cbAccountType.Size = new System.Drawing.Size(149, 21);
            this.cbAccountType.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label11.Location = new System.Drawing.Point(3, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 19);
            this.label11.TabIndex = 0;
            this.label11.Text = "Loại tài khoản";
            // 
            // panel26
            // 
            this.panel26.Controls.Add(this.txbDisplayName);
            this.panel26.Controls.Add(this.label12);
            this.panel26.Location = new System.Drawing.Point(3, 53);
            this.panel26.Name = "panel26";
            this.panel26.Size = new System.Drawing.Size(315, 44);
            this.panel26.TabIndex = 2;
            // 
            // txbDisplayName
            // 
            this.txbDisplayName.Location = new System.Drawing.Point(127, 8);
            this.txbDisplayName.Name = "txbDisplayName";
            this.txbDisplayName.Size = new System.Drawing.Size(149, 20);
            this.txbDisplayName.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label12.Location = new System.Drawing.Point(3, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 19);
            this.label12.TabIndex = 0;
            this.label12.Text = "Tên hiển thị:";
            // 
            // panel27
            // 
            this.panel27.Controls.Add(this.txbUserName);
            this.panel27.Controls.Add(this.label13);
            this.panel27.Location = new System.Drawing.Point(3, 3);
            this.panel27.Name = "panel27";
            this.panel27.Size = new System.Drawing.Size(315, 44);
            this.panel27.TabIndex = 1;
            // 
            // txbUserName
            // 
            this.txbUserName.Location = new System.Drawing.Point(127, 8);
            this.txbUserName.Name = "txbUserName";
            this.txbUserName.ReadOnly = true;
            this.txbUserName.Size = new System.Drawing.Size(149, 20);
            this.txbUserName.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label13.Location = new System.Drawing.Point(3, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(118, 19);
            this.label13.TabIndex = 0;
            this.label13.Text = "Tên tài khoản:";
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.ForeColor = System.Drawing.Color.Red;
            this.radLabel1.Location = new System.Drawing.Point(232, 12);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(239, 37);
            this.radLabel1.TabIndex = 9;
            this.radLabel1.Text = "Thông tin tài khoản";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 424);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.panel23);
            this.Controls.Add(this.radGridView1);
            this.Name = "Form2";
            this.Text = "Form Tài Khoản";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel28.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            this.panel23.ResumeLayout(false);
            this.panel25.ResumeLayout(false);
            this.panel25.PerformLayout();
            this.panel26.ResumeLayout(false);
            this.panel26.PerformLayout();
            this.panel27.ResumeLayout(false);
            this.panel27.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel28;
        private System.Windows.Forms.Button btnShowAccount;
        private System.Windows.Forms.Button btnEditAccount;
        private System.Windows.Forms.Button btnDeleteAccount;
        private System.Windows.Forms.Button btnAddAccount;
        private Telerik.WinControls.UI.RadGridView radGridView1;
        private System.Windows.Forms.Panel panel23;
        private System.Windows.Forms.Button btnResetPassword;
        private System.Windows.Forms.Panel panel25;
        private System.Windows.Forms.ComboBox cbAccountType;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel26;
        private System.Windows.Forms.TextBox txbDisplayName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel27;
        private System.Windows.Forms.TextBox txbUserName;
        private System.Windows.Forms.Label label13;
        private Telerik.WinControls.UI.RadLabel radLabel1;
    }
}