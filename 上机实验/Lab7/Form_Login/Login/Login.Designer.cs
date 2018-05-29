namespace Form_SC
{
    partial class Login
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.labUserName = new System.Windows.Forms.Label();
            this.labPasswd = new System.Windows.Forms.Label();
            this.labUserType = new System.Windows.Forms.Label();
            this.btLogin = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.tbPasswd = new System.Windows.Forms.TextBox();
            this.combUserType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labUserName
            // 
            this.labUserName.AutoSize = true;
            this.labUserName.Location = new System.Drawing.Point(54, 52);
            this.labUserName.Name = "labUserName";
            this.labUserName.Size = new System.Drawing.Size(65, 12);
            this.labUserName.TabIndex = 0;
            this.labUserName.Text = "用 户 名：";
            // 
            // labPasswd
            // 
            this.labPasswd.AutoSize = true;
            this.labPasswd.Location = new System.Drawing.Point(54, 97);
            this.labPasswd.Name = "labPasswd";
            this.labPasswd.Size = new System.Drawing.Size(65, 12);
            this.labPasswd.TabIndex = 0;
            this.labPasswd.Text = "密    码：";
            // 
            // labUserType
            // 
            this.labUserType.AutoSize = true;
            this.labUserType.Location = new System.Drawing.Point(54, 146);
            this.labUserType.Name = "labUserType";
            this.labUserType.Size = new System.Drawing.Size(65, 12);
            this.labUserType.TabIndex = 0;
            this.labUserType.Text = "用户类型：";
            // 
            // btLogin
            // 
            this.btLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btLogin.Location = new System.Drawing.Point(44, 210);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(75, 23);
            this.btLogin.TabIndex = 4;
            this.btLogin.Text = "登录";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // btCancel
            // 
            this.btCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(184, 210);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 5;
            this.btCancel.Text = "取消";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(125, 49);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(121, 21);
            this.tbUserName.TabIndex = 1;
            // 
            // tbPasswd
            // 
            this.tbPasswd.Location = new System.Drawing.Point(125, 94);
            this.tbPasswd.Name = "tbPasswd";
            this.tbPasswd.PasswordChar = '*';
            this.tbPasswd.Size = new System.Drawing.Size(121, 21);
            this.tbPasswd.TabIndex = 2;
            // 
            // combUserType
            // 
            this.combUserType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.combUserType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combUserType.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.combUserType.FormattingEnabled = true;
            this.combUserType.ItemHeight = 18;
            this.combUserType.Items.AddRange(new object[] {
            "管理员",
            "学生",
            "教师"});
            this.combUserType.Location = new System.Drawing.Point(125, 137);
            this.combUserType.Name = "combUserType";
            this.combUserType.Size = new System.Drawing.Size(121, 24);
            this.combUserType.TabIndex = 3;
            this.combUserType.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.CombUserType_DrawItem);
            // 
            // Login
            // 
            this.AcceptButton = this.btLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btCancel;
            this.ClientSize = new System.Drawing.Size(310, 278);
            this.Controls.Add(this.combUserType);
            this.Controls.Add(this.tbPasswd);
            this.Controls.Add(this.tbUserName);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.labUserType);
            this.Controls.Add(this.labPasswd);
            this.Controls.Add(this.labUserName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labUserName;
        private System.Windows.Forms.Label labPasswd;
        private System.Windows.Forms.Label labUserType;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.TextBox tbPasswd;
        private System.Windows.Forms.ComboBox combUserType;
    }
}

