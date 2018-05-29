namespace Form_SC
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
            this.labUserName = new System.Windows.Forms.Label();
            this.labPasswd = new System.Windows.Forms.Label();
            this.labConfirmPasswd = new System.Windows.Forms.Label();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.tbPasswd = new System.Windows.Forms.TextBox();
            this.tbConfirmPasswd = new System.Windows.Forms.TextBox();
            this.btConfirm = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labUserName
            // 
            this.labUserName.AutoSize = true;
            this.labUserName.Location = new System.Drawing.Point(85, 53);
            this.labUserName.Name = "labUserName";
            this.labUserName.Size = new System.Drawing.Size(65, 12);
            this.labUserName.TabIndex = 0;
            this.labUserName.Text = "用 户 名：";
            // 
            // labPasswd
            // 
            this.labPasswd.AutoSize = true;
            this.labPasswd.Location = new System.Drawing.Point(85, 113);
            this.labPasswd.Name = "labPasswd";
            this.labPasswd.Size = new System.Drawing.Size(65, 12);
            this.labPasswd.TabIndex = 0;
            this.labPasswd.Text = "密    码：";
            // 
            // labConfirmPasswd
            // 
            this.labConfirmPasswd.AutoSize = true;
            this.labConfirmPasswd.Location = new System.Drawing.Point(85, 170);
            this.labConfirmPasswd.Name = "labConfirmPasswd";
            this.labConfirmPasswd.Size = new System.Drawing.Size(65, 12);
            this.labConfirmPasswd.TabIndex = 0;
            this.labConfirmPasswd.Text = "确认密码：";
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(156, 50);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(100, 21);
            this.tbUserName.TabIndex = 1;
            // 
            // tbPasswd
            // 
            this.tbPasswd.Location = new System.Drawing.Point(156, 110);
            this.tbPasswd.Name = "tbPasswd";
            this.tbPasswd.PasswordChar = '*';
            this.tbPasswd.Size = new System.Drawing.Size(100, 21);
            this.tbPasswd.TabIndex = 2;
            // 
            // tbConfirmPasswd
            // 
            this.tbConfirmPasswd.Location = new System.Drawing.Point(156, 167);
            this.tbConfirmPasswd.Name = "tbConfirmPasswd";
            this.tbConfirmPasswd.PasswordChar = '*';
            this.tbConfirmPasswd.Size = new System.Drawing.Size(100, 21);
            this.tbConfirmPasswd.TabIndex = 3;
            // 
            // btConfirm
            // 
            this.btConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btConfirm.Location = new System.Drawing.Point(75, 226);
            this.btConfirm.Name = "btConfirm";
            this.btConfirm.Size = new System.Drawing.Size(75, 23);
            this.btConfirm.TabIndex = 4;
            this.btConfirm.Text = "确认";
            this.btConfirm.UseVisualStyleBackColor = true;
            this.btConfirm.Click += new System.EventHandler(this.btConfirm_Click);
            // 
            // btCancel
            // 
            this.btCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(199, 226);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 5;
            this.btCancel.Text = "取消";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // AddAdmin
            // 
            this.AcceptButton = this.btConfirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btCancel;
            this.ClientSize = new System.Drawing.Size(346, 283);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btConfirm);
            this.Controls.Add(this.tbConfirmPasswd);
            this.Controls.Add(this.tbPasswd);
            this.Controls.Add(this.tbUserName);
            this.Controls.Add(this.labConfirmPasswd);
            this.Controls.Add(this.labPasswd);
            this.Controls.Add(this.labUserName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AddAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddAdmin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labUserName;
        private System.Windows.Forms.Label labPasswd;
        private System.Windows.Forms.Label labConfirmPasswd;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.TextBox tbPasswd;
        private System.Windows.Forms.TextBox tbConfirmPasswd;
        private System.Windows.Forms.Button btConfirm;
        private System.Windows.Forms.Button btCancel;
    }
}