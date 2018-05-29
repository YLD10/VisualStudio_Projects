namespace Maticsoft.Hotel
{
    partial class AlterAdmin
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
            this.labAdminProPasswd = new System.Windows.Forms.Label();
            this.labAdminName = new System.Windows.Forms.Label();
            this.labAdminNewPasswd = new System.Windows.Forms.Label();
            this.tbAdminID = new System.Windows.Forms.TextBox();
            this.tbAdminProPasswd = new System.Windows.Forms.TextBox();
            this.tbAdminName = new System.Windows.Forms.TextBox();
            this.tbAdminNewPasswd = new System.Windows.Forms.TextBox();
            this.btAdminConfirm = new System.Windows.Forms.Button();
            this.btAdminCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labAdminID
            // 
            this.labAdminID.AutoSize = true;
            this.labAdminID.Location = new System.Drawing.Point(36, 32);
            this.labAdminID.Name = "labAdminID";
            this.labAdminID.Size = new System.Drawing.Size(53, 12);
            this.labAdminID.TabIndex = 0;
            this.labAdminID.Text = "用户名：";
            // 
            // labAdminProPasswd
            // 
            this.labAdminProPasswd.AutoSize = true;
            this.labAdminProPasswd.Location = new System.Drawing.Point(36, 74);
            this.labAdminProPasswd.Name = "labAdminProPasswd";
            this.labAdminProPasswd.Size = new System.Drawing.Size(53, 12);
            this.labAdminProPasswd.TabIndex = 1;
            this.labAdminProPasswd.Text = "原密码：";
            // 
            // labAdminName
            // 
            this.labAdminName.AutoSize = true;
            this.labAdminName.Location = new System.Drawing.Point(36, 112);
            this.labAdminName.Name = "labAdminName";
            this.labAdminName.Size = new System.Drawing.Size(41, 12);
            this.labAdminName.TabIndex = 2;
            this.labAdminName.Text = "昵称：";
            // 
            // labAdminNewPasswd
            // 
            this.labAdminNewPasswd.AutoSize = true;
            this.labAdminNewPasswd.Location = new System.Drawing.Point(36, 151);
            this.labAdminNewPasswd.Name = "labAdminNewPasswd";
            this.labAdminNewPasswd.Size = new System.Drawing.Size(53, 12);
            this.labAdminNewPasswd.TabIndex = 3;
            this.labAdminNewPasswd.Text = "新密码：";
            // 
            // tbAdminID
            // 
            this.tbAdminID.Location = new System.Drawing.Point(126, 29);
            this.tbAdminID.Name = "tbAdminID";
            this.tbAdminID.Size = new System.Drawing.Size(100, 21);
            this.tbAdminID.TabIndex = 5;
            // 
            // tbAdminProPasswd
            // 
            this.tbAdminProPasswd.Location = new System.Drawing.Point(126, 71);
            this.tbAdminProPasswd.Name = "tbAdminProPasswd";
            this.tbAdminProPasswd.PasswordChar = '*';
            this.tbAdminProPasswd.Size = new System.Drawing.Size(100, 21);
            this.tbAdminProPasswd.TabIndex = 6;
            // 
            // tbAdminName
            // 
            this.tbAdminName.Location = new System.Drawing.Point(126, 109);
            this.tbAdminName.Name = "tbAdminName";
            this.tbAdminName.Size = new System.Drawing.Size(100, 21);
            this.tbAdminName.TabIndex = 7;
            // 
            // tbAdminNewPasswd
            // 
            this.tbAdminNewPasswd.Location = new System.Drawing.Point(126, 148);
            this.tbAdminNewPasswd.Name = "tbAdminNewPasswd";
            this.tbAdminNewPasswd.PasswordChar = '*';
            this.tbAdminNewPasswd.Size = new System.Drawing.Size(100, 21);
            this.tbAdminNewPasswd.TabIndex = 8;
            // 
            // btAdminConfirm
            // 
            this.btAdminConfirm.Location = new System.Drawing.Point(38, 198);
            this.btAdminConfirm.Name = "btAdminConfirm";
            this.btAdminConfirm.Size = new System.Drawing.Size(75, 23);
            this.btAdminConfirm.TabIndex = 10;
            this.btAdminConfirm.Text = "确定";
            this.btAdminConfirm.UseVisualStyleBackColor = true;
            this.btAdminConfirm.Click += new System.EventHandler(this.btAdminConfirm_Click);
            // 
            // btAdminCancel
            // 
            this.btAdminCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btAdminCancel.Location = new System.Drawing.Point(151, 198);
            this.btAdminCancel.Name = "btAdminCancel";
            this.btAdminCancel.Size = new System.Drawing.Size(75, 23);
            this.btAdminCancel.TabIndex = 11;
            this.btAdminCancel.Text = "取消";
            this.btAdminCancel.UseVisualStyleBackColor = true;
            this.btAdminCancel.Click += new System.EventHandler(this.btAdminCancel_Click);
            // 
            // AlterAdmin
            // 
            this.AcceptButton = this.btAdminConfirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btAdminCancel;
            this.ClientSize = new System.Drawing.Size(273, 283);
            this.Controls.Add(this.btAdminCancel);
            this.Controls.Add(this.btAdminConfirm);
            this.Controls.Add(this.tbAdminNewPasswd);
            this.Controls.Add(this.tbAdminName);
            this.Controls.Add(this.tbAdminProPasswd);
            this.Controls.Add(this.tbAdminID);
            this.Controls.Add(this.labAdminNewPasswd);
            this.Controls.Add(this.labAdminName);
            this.Controls.Add(this.labAdminProPasswd);
            this.Controls.Add(this.labAdminID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AlterAdmin";
            this.Text = "AlterAdmin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labAdminID;
        private System.Windows.Forms.Label labAdminProPasswd;
        private System.Windows.Forms.Label labAdminName;
        private System.Windows.Forms.Label labAdminNewPasswd;
        private System.Windows.Forms.TextBox tbAdminName;
        private System.Windows.Forms.TextBox tbAdminNewPasswd;
        private System.Windows.Forms.Button btAdminConfirm;
        private System.Windows.Forms.Button btAdminCancel;
        public System.Windows.Forms.TextBox tbAdminID;
        public System.Windows.Forms.TextBox tbAdminProPasswd;
    }
}