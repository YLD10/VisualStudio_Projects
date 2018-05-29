namespace Maticsoft.Hotel
{
    partial class AddAdmin
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
            this.labAdminID = new System.Windows.Forms.Label();
            this.labAdminName = new System.Windows.Forms.Label();
            this.labAdminPassword = new System.Windows.Forms.Label();
            this.labAdminConfirmPasswd = new System.Windows.Forms.Label();
            this.tbAdminID = new System.Windows.Forms.TextBox();
            this.tbAdminName = new System.Windows.Forms.TextBox();
            this.tbAdminPassword = new System.Windows.Forms.TextBox();
            this.tbAdminConfirmPasswd = new System.Windows.Forms.TextBox();
            this.btAdminConfirm = new System.Windows.Forms.Button();
            this.btAdminCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labAdminID
            // 
            this.labAdminID.AutoSize = true;
            this.labAdminID.Location = new System.Drawing.Point(32, 31);
            this.labAdminID.Name = "labAdminID";
            this.labAdminID.Size = new System.Drawing.Size(59, 12);
            this.labAdminID.TabIndex = 0;
            this.labAdminID.Text = " 用户名：";
            // 
            // labAdminName
            // 
            this.labAdminName.AutoSize = true;
            this.labAdminName.Location = new System.Drawing.Point(32, 86);
            this.labAdminName.Name = "labAdminName";
            this.labAdminName.Size = new System.Drawing.Size(53, 12);
            this.labAdminName.TabIndex = 1;
            this.labAdminName.Text = "昵  称：";
            // 
            // labAdminPassword
            // 
            this.labAdminPassword.AutoSize = true;
            this.labAdminPassword.Location = new System.Drawing.Point(32, 138);
            this.labAdminPassword.Name = "labAdminPassword";
            this.labAdminPassword.Size = new System.Drawing.Size(59, 12);
            this.labAdminPassword.TabIndex = 2;
            this.labAdminPassword.Text = "密   码：";
            // 
            // labAdminConfirmPasswd
            // 
            this.labAdminConfirmPasswd.AutoSize = true;
            this.labAdminConfirmPasswd.Location = new System.Drawing.Point(30, 193);
            this.labAdminConfirmPasswd.Name = "labAdminConfirmPasswd";
            this.labAdminConfirmPasswd.Size = new System.Drawing.Size(65, 12);
            this.labAdminConfirmPasswd.TabIndex = 3;
            this.labAdminConfirmPasswd.Text = "确认密码：";
            // 
            // tbAdminID
            // 
            this.tbAdminID.Location = new System.Drawing.Point(110, 28);
            this.tbAdminID.Name = "tbAdminID";
            this.tbAdminID.Size = new System.Drawing.Size(100, 21);
            this.tbAdminID.TabIndex = 4;
            // 
            // tbAdminName
            // 
            this.tbAdminName.Location = new System.Drawing.Point(110, 83);
            this.tbAdminName.Name = "tbAdminName";
            this.tbAdminName.Size = new System.Drawing.Size(100, 21);
            this.tbAdminName.TabIndex = 5;
            // 
            // tbAdminPassword
            // 
            this.tbAdminPassword.Location = new System.Drawing.Point(110, 135);
            this.tbAdminPassword.Name = "tbAdminPassword";
            this.tbAdminPassword.PasswordChar = '*';
            this.tbAdminPassword.Size = new System.Drawing.Size(100, 21);
            this.tbAdminPassword.TabIndex = 6;
            // 
            // tbAdminConfirmPasswd
            // 
            this.tbAdminConfirmPasswd.Location = new System.Drawing.Point(110, 190);
            this.tbAdminConfirmPasswd.Name = "tbAdminConfirmPasswd";
            this.tbAdminConfirmPasswd.PasswordChar = '*';
            this.tbAdminConfirmPasswd.Size = new System.Drawing.Size(100, 21);
            this.tbAdminConfirmPasswd.TabIndex = 7;
            // 
            // btAdminConfirm
            // 
            this.btAdminConfirm.Location = new System.Drawing.Point(32, 251);
            this.btAdminConfirm.Name = "btAdminConfirm";
            this.btAdminConfirm.Size = new System.Drawing.Size(75, 23);
            this.btAdminConfirm.TabIndex = 8;
            this.btAdminConfirm.Text = "确定";
            this.btAdminConfirm.UseVisualStyleBackColor = true;
            this.btAdminConfirm.Click += new System.EventHandler(this.btAdminConfirm_Click);
            // 
            // btAdminCancel
            // 
            this.btAdminCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btAdminCancel.Location = new System.Drawing.Point(154, 251);
            this.btAdminCancel.Name = "btAdminCancel";
            this.btAdminCancel.Size = new System.Drawing.Size(75, 23);
            this.btAdminCancel.TabIndex = 9;
            this.btAdminCancel.Text = "取消";
            this.btAdminCancel.UseVisualStyleBackColor = true;
            this.btAdminCancel.Click += new System.EventHandler(this.btAdminCancel_Click);
            // 
            // AddAdmin
            // 
            this.AcceptButton = this.btAdminConfirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btAdminCancel;
            this.ClientSize = new System.Drawing.Size(294, 301);
            this.Controls.Add(this.btAdminCancel);
            this.Controls.Add(this.btAdminConfirm);
            this.Controls.Add(this.tbAdminConfirmPasswd);
            this.Controls.Add(this.tbAdminPassword);
            this.Controls.Add(this.tbAdminName);
            this.Controls.Add(this.tbAdminID);
            this.Controls.Add(this.labAdminConfirmPasswd);
            this.Controls.Add(this.labAdminPassword);
            this.Controls.Add(this.labAdminName);
            this.Controls.Add(this.labAdminID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddAdmin";
            this.Text = "AddAdmin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labAdminID;
        private System.Windows.Forms.Label labAdminName;
        private System.Windows.Forms.Label labAdminPassword;
        private System.Windows.Forms.Label labAdminConfirmPasswd;
        private System.Windows.Forms.TextBox tbAdminID;
        private System.Windows.Forms.TextBox tbAdminName;
        private System.Windows.Forms.TextBox tbAdminPassword;
        private System.Windows.Forms.TextBox tbAdminConfirmPasswd;
        private System.Windows.Forms.Button btAdminConfirm;
        private System.Windows.Forms.Button btAdminCancel;
    }
}