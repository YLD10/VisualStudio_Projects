namespace Lab6
{
    partial class Form_Lab6_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Lab6_Login));
            this.pbTitleLogin = new System.Windows.Forms.PictureBox();
            this.labTitleLogin = new System.Windows.Forms.Label();
            this.labUserNameLogin = new System.Windows.Forms.Label();
            this.labPasswdLogin = new System.Windows.Forms.Label();
            this.btConfirmLogin = new System.Windows.Forms.Button();
            this.btCancelLogin = new System.Windows.Forms.Button();
            this.tbUserNameLogin = new System.Windows.Forms.TextBox();
            this.tbPasswdLogin = new System.Windows.Forms.TextBox();
            this.pbUserNameLogin = new System.Windows.Forms.PictureBox();
            this.pbPasswdLogin = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbTitleLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserNameLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPasswdLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // pbTitleLogin
            // 
            this.pbTitleLogin.Image = ((System.Drawing.Image)(resources.GetObject("pbTitleLogin.Image")));
            this.pbTitleLogin.Location = new System.Drawing.Point(138, 43);
            this.pbTitleLogin.Name = "pbTitleLogin";
            this.pbTitleLogin.Size = new System.Drawing.Size(60, 60);
            this.pbTitleLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTitleLogin.TabIndex = 0;
            this.pbTitleLogin.TabStop = false;
            // 
            // labTitleLogin
            // 
            this.labTitleLogin.AutoSize = true;
            this.labTitleLogin.Font = new System.Drawing.Font("黑体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labTitleLogin.Location = new System.Drawing.Point(204, 65);
            this.labTitleLogin.Name = "labTitleLogin";
            this.labTitleLogin.Size = new System.Drawing.Size(110, 24);
            this.labTitleLogin.TabIndex = 1;
            this.labTitleLogin.Text = "个人理财";
            // 
            // labUserNameLogin
            // 
            this.labUserNameLogin.AutoSize = true;
            this.labUserNameLogin.Location = new System.Drawing.Point(153, 162);
            this.labUserNameLogin.Name = "labUserNameLogin";
            this.labUserNameLogin.Size = new System.Drawing.Size(53, 12);
            this.labUserNameLogin.TabIndex = 1;
            this.labUserNameLogin.Text = "用户名：";
            // 
            // labPasswdLogin
            // 
            this.labPasswdLogin.AutoSize = true;
            this.labPasswdLogin.Location = new System.Drawing.Point(153, 221);
            this.labPasswdLogin.Name = "labPasswdLogin";
            this.labPasswdLogin.Size = new System.Drawing.Size(53, 12);
            this.labPasswdLogin.TabIndex = 1;
            this.labPasswdLogin.Text = "密  码：";
            // 
            // btConfirmLogin
            // 
            this.btConfirmLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btConfirmLogin.Location = new System.Drawing.Point(115, 294);
            this.btConfirmLogin.Name = "btConfirmLogin";
            this.btConfirmLogin.Size = new System.Drawing.Size(75, 23);
            this.btConfirmLogin.TabIndex = 3;
            this.btConfirmLogin.Text = "登录(&L)";
            this.btConfirmLogin.UseVisualStyleBackColor = true;
            this.btConfirmLogin.Click += new System.EventHandler(this.btConfirmLogin_Click);
            // 
            // btCancelLogin
            // 
            this.btCancelLogin.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancelLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btCancelLogin.Location = new System.Drawing.Point(237, 294);
            this.btCancelLogin.Name = "btCancelLogin";
            this.btCancelLogin.Size = new System.Drawing.Size(75, 23);
            this.btCancelLogin.TabIndex = 4;
            this.btCancelLogin.Text = "取消(&C)";
            this.btCancelLogin.UseVisualStyleBackColor = true;
            this.btCancelLogin.Click += new System.EventHandler(this.btCancelLogin_Click);
            // 
            // tbUserNameLogin
            // 
            this.tbUserNameLogin.Location = new System.Drawing.Point(212, 159);
            this.tbUserNameLogin.Name = "tbUserNameLogin";
            this.tbUserNameLogin.Size = new System.Drawing.Size(100, 21);
            this.tbUserNameLogin.TabIndex = 1;
            // 
            // tbPasswdLogin
            // 
            this.tbPasswdLogin.Location = new System.Drawing.Point(212, 218);
            this.tbPasswdLogin.Name = "tbPasswdLogin";
            this.tbPasswdLogin.PasswordChar = '*';
            this.tbPasswdLogin.Size = new System.Drawing.Size(100, 21);
            this.tbPasswdLogin.TabIndex = 2;
            // 
            // pbUserNameLogin
            // 
            this.pbUserNameLogin.Image = ((System.Drawing.Image)(resources.GetObject("pbUserNameLogin.Image")));
            this.pbUserNameLogin.Location = new System.Drawing.Point(122, 155);
            this.pbUserNameLogin.Name = "pbUserNameLogin";
            this.pbUserNameLogin.Size = new System.Drawing.Size(25, 25);
            this.pbUserNameLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUserNameLogin.TabIndex = 0;
            this.pbUserNameLogin.TabStop = false;
            // 
            // pbPasswdLogin
            // 
            this.pbPasswdLogin.Image = ((System.Drawing.Image)(resources.GetObject("pbPasswdLogin.Image")));
            this.pbPasswdLogin.Location = new System.Drawing.Point(122, 208);
            this.pbPasswdLogin.Name = "pbPasswdLogin";
            this.pbPasswdLogin.Size = new System.Drawing.Size(25, 25);
            this.pbPasswdLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPasswdLogin.TabIndex = 0;
            this.pbPasswdLogin.TabStop = false;
            // 
            // Form_Lab6_Login
            // 
            this.AcceptButton = this.btConfirmLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btCancelLogin;
            this.ClientSize = new System.Drawing.Size(433, 360);
            this.Controls.Add(this.tbPasswdLogin);
            this.Controls.Add(this.tbUserNameLogin);
            this.Controls.Add(this.btCancelLogin);
            this.Controls.Add(this.btConfirmLogin);
            this.Controls.Add(this.labPasswdLogin);
            this.Controls.Add(this.labUserNameLogin);
            this.Controls.Add(this.labTitleLogin);
            this.Controls.Add(this.pbPasswdLogin);
            this.Controls.Add(this.pbUserNameLogin);
            this.Controls.Add(this.pbTitleLogin);
            this.MaximizeBox = false;
            this.Name = "Form_Lab6_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户登录";
            ((System.ComponentModel.ISupportInitialize)(this.pbTitleLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserNameLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPasswdLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbTitleLogin;
        private System.Windows.Forms.Label labTitleLogin;
        private System.Windows.Forms.Label labUserNameLogin;
        private System.Windows.Forms.Label labPasswdLogin;
        private System.Windows.Forms.Button btConfirmLogin;
        private System.Windows.Forms.Button btCancelLogin;
        private System.Windows.Forms.TextBox tbUserNameLogin;
        private System.Windows.Forms.TextBox tbPasswdLogin;
        private System.Windows.Forms.PictureBox pbUserNameLogin;
        private System.Windows.Forms.PictureBox pbPasswdLogin;
    }
}

