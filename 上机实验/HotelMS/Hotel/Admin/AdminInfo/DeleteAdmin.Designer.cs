namespace Maticsoft.Hotel
{
    partial class DeleteAdmin
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
            this.labAdminPasswd = new System.Windows.Forms.Label();
            this.tbAdminID = new System.Windows.Forms.TextBox();
            this.tbAdminPasswd = new System.Windows.Forms.TextBox();
            this.btAdminConfirm = new System.Windows.Forms.Button();
            this.btAdminCancle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labAdminID
            // 
            this.labAdminID.AutoSize = true;
            this.labAdminID.Location = new System.Drawing.Point(51, 45);
            this.labAdminID.Name = "labAdminID";
            this.labAdminID.Size = new System.Drawing.Size(53, 12);
            this.labAdminID.TabIndex = 0;
            this.labAdminID.Text = "用户名：";
            // 
            // labAdminPasswd
            // 
            this.labAdminPasswd.AutoSize = true;
            this.labAdminPasswd.Location = new System.Drawing.Point(51, 108);
            this.labAdminPasswd.Name = "labAdminPasswd";
            this.labAdminPasswd.Size = new System.Drawing.Size(41, 12);
            this.labAdminPasswd.TabIndex = 1;
            this.labAdminPasswd.Text = "密码：";
            // 
            // tbAdminID
            // 
            this.tbAdminID.Location = new System.Drawing.Point(130, 42);
            this.tbAdminID.Name = "tbAdminID";
            this.tbAdminID.Size = new System.Drawing.Size(100, 21);
            this.tbAdminID.TabIndex = 2;
            // 
            // tbAdminPasswd
            // 
            this.tbAdminPasswd.Location = new System.Drawing.Point(130, 105);
            this.tbAdminPasswd.Name = "tbAdminPasswd";
            this.tbAdminPasswd.PasswordChar = '*';
            this.tbAdminPasswd.Size = new System.Drawing.Size(100, 21);
            this.tbAdminPasswd.TabIndex = 3;
            // 
            // btAdminConfirm
            // 
            this.btAdminConfirm.Location = new System.Drawing.Point(29, 186);
            this.btAdminConfirm.Name = "btAdminConfirm";
            this.btAdminConfirm.Size = new System.Drawing.Size(75, 23);
            this.btAdminConfirm.TabIndex = 4;
            this.btAdminConfirm.Text = "确定";
            this.btAdminConfirm.UseVisualStyleBackColor = true;
            this.btAdminConfirm.Click += new System.EventHandler(this.btAdminConfirm_Click);
            // 
            // btAdminCancle
            // 
            this.btAdminCancle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btAdminCancle.Location = new System.Drawing.Point(179, 186);
            this.btAdminCancle.Name = "btAdminCancle";
            this.btAdminCancle.Size = new System.Drawing.Size(75, 23);
            this.btAdminCancle.TabIndex = 5;
            this.btAdminCancle.Text = "取消";
            this.btAdminCancle.UseVisualStyleBackColor = true;
            this.btAdminCancle.Click += new System.EventHandler(this.btAdminCancle_Click);
            // 
            // DeleteAdmin
            // 
            this.AcceptButton = this.btAdminConfirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btAdminCancle;
            this.ClientSize = new System.Drawing.Size(311, 254);
            this.Controls.Add(this.btAdminCancle);
            this.Controls.Add(this.btAdminConfirm);
            this.Controls.Add(this.tbAdminPasswd);
            this.Controls.Add(this.tbAdminID);
            this.Controls.Add(this.labAdminPasswd);
            this.Controls.Add(this.labAdminID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "DeleteAdmin";
            this.Text = "DeleteAdmin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labAdminID;
        private System.Windows.Forms.Label labAdminPasswd;
        private System.Windows.Forms.Button btAdminConfirm;
        private System.Windows.Forms.Button btAdminCancle;
        public System.Windows.Forms.TextBox tbAdminID;
        public System.Windows.Forms.TextBox tbAdminPasswd;
    }
}