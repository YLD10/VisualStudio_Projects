namespace Maticsoft.Hotel
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.but_ok = new System.Windows.Forms.Button();
            this.but_cancel = new System.Windows.Forms.Button();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel4 = new CCWin.SkinControl.SkinLabel();
            this.checkCode = new CCWin.SkinControl.SkinLabel();
            this.text_userName = new CCWin.SkinControl.SkinTextBox();
            this.text_passwd = new CCWin.SkinControl.SkinTextBox();
            this.text_ensureCode = new CCWin.SkinControl.SkinTextBox();
            this.combox_power = new CCWin.SkinControl.SkinComboBox();
            this.SuspendLayout();
            // 
            // but_ok
            // 
            this.but_ok.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.but_ok.Location = new System.Drawing.Point(250, 400);
            this.but_ok.Name = "but_ok";
            this.but_ok.Size = new System.Drawing.Size(80, 30);
            this.but_ok.TabIndex = 4;
            this.but_ok.Text = "登录";
            this.but_ok.UseVisualStyleBackColor = true;
            this.but_ok.Click += new System.EventHandler(this.but_ok_Click);
            // 
            // but_cancel
            // 
            this.but_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.but_cancel.Location = new System.Drawing.Point(450, 400);
            this.but_cancel.Name = "but_cancel";
            this.but_cancel.Size = new System.Drawing.Size(80, 30);
            this.but_cancel.TabIndex = 5;
            this.but_cancel.Text = "取消";
            this.but_cancel.UseVisualStyleBackColor = true;
            this.but_cancel.Click += new System.EventHandler(this.but_cancel_Click);
            // 
            // skinLabel1
            // 
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(170, 80);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(80, 26);
            this.skinLabel1.TabIndex = 11;
            this.skinLabel1.Text = "用户名：";
            this.skinLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // skinLabel2
            // 
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(170, 160);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(80, 26);
            this.skinLabel2.TabIndex = 12;
            this.skinLabel2.Text = "密   码：";
            this.skinLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // skinLabel3
            // 
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel3.Location = new System.Drawing.Point(170, 240);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(80, 26);
            this.skinLabel3.TabIndex = 13;
            this.skinLabel3.Text = "验证码：";
            this.skinLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // skinLabel4
            // 
            this.skinLabel4.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel4.BorderColor = System.Drawing.Color.White;
            this.skinLabel4.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel4.Location = new System.Drawing.Point(170, 320);
            this.skinLabel4.Name = "skinLabel4";
            this.skinLabel4.Size = new System.Drawing.Size(80, 26);
            this.skinLabel4.TabIndex = 14;
            this.skinLabel4.Text = "用户身份：";
            this.skinLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // checkCode
            // 
            this.checkCode.BackColor = System.Drawing.Color.Transparent;
            this.checkCode.BorderColor = System.Drawing.Color.White;
            this.checkCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.checkCode.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkCode.Location = new System.Drawing.Point(450, 240);
            this.checkCode.Name = "checkCode";
            this.checkCode.Size = new System.Drawing.Size(100, 26);
            this.checkCode.TabIndex = 15;
            this.checkCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkCode.Click += new System.EventHandler(this.checkCode_Click);
            // 
            // text_userName
            // 
            this.text_userName.BackColor = System.Drawing.Color.Transparent;
            this.text_userName.DownBack = null;
            this.text_userName.Icon = null;
            this.text_userName.IconIsButton = false;
            this.text_userName.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.text_userName.IsPasswordChat = '\0';
            this.text_userName.IsSystemPasswordChar = false;
            this.text_userName.Lines = new string[0];
            this.text_userName.Location = new System.Drawing.Point(250, 80);
            this.text_userName.Margin = new System.Windows.Forms.Padding(0);
            this.text_userName.MaxLength = 32767;
            this.text_userName.MinimumSize = new System.Drawing.Size(28, 28);
            this.text_userName.MouseBack = null;
            this.text_userName.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.text_userName.Multiline = false;
            this.text_userName.Name = "text_userName";
            this.text_userName.NormlBack = null;
            this.text_userName.Padding = new System.Windows.Forms.Padding(5);
            this.text_userName.ReadOnly = false;
            this.text_userName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.text_userName.Size = new System.Drawing.Size(280, 28);
            // 
            // 
            // 
            this.text_userName.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_userName.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.text_userName.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.text_userName.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.text_userName.SkinTxt.Name = "BaseText";
            this.text_userName.SkinTxt.Size = new System.Drawing.Size(270, 19);
            this.text_userName.SkinTxt.TabIndex = 0;
            this.text_userName.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.text_userName.SkinTxt.WaterText = "";
            this.text_userName.TabIndex = 0;
            this.text_userName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.text_userName.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.text_userName.WaterText = "";
            this.text_userName.WordWrap = true;
            // 
            // text_passwd
            // 
            this.text_passwd.BackColor = System.Drawing.Color.Transparent;
            this.text_passwd.DownBack = null;
            this.text_passwd.Icon = null;
            this.text_passwd.IconIsButton = false;
            this.text_passwd.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.text_passwd.IsPasswordChat = '·';
            this.text_passwd.IsSystemPasswordChar = false;
            this.text_passwd.Lines = new string[0];
            this.text_passwd.Location = new System.Drawing.Point(250, 160);
            this.text_passwd.Margin = new System.Windows.Forms.Padding(0);
            this.text_passwd.MaxLength = 32767;
            this.text_passwd.MinimumSize = new System.Drawing.Size(28, 28);
            this.text_passwd.MouseBack = null;
            this.text_passwd.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.text_passwd.Multiline = false;
            this.text_passwd.Name = "text_passwd";
            this.text_passwd.NormlBack = null;
            this.text_passwd.Padding = new System.Windows.Forms.Padding(5);
            this.text_passwd.ReadOnly = false;
            this.text_passwd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.text_passwd.Size = new System.Drawing.Size(280, 28);
            // 
            // 
            // 
            this.text_passwd.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_passwd.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.text_passwd.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.text_passwd.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.text_passwd.SkinTxt.Name = "BaseText";
            this.text_passwd.SkinTxt.PasswordChar = '·';
            this.text_passwd.SkinTxt.Size = new System.Drawing.Size(270, 19);
            this.text_passwd.SkinTxt.TabIndex = 0;
            this.text_passwd.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.text_passwd.SkinTxt.WaterText = "";
            this.text_passwd.TabIndex = 1;
            this.text_passwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.text_passwd.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.text_passwd.WaterText = "";
            this.text_passwd.WordWrap = true;
            // 
            // text_ensureCode
            // 
            this.text_ensureCode.BackColor = System.Drawing.Color.Transparent;
            this.text_ensureCode.DownBack = null;
            this.text_ensureCode.Icon = null;
            this.text_ensureCode.IconIsButton = false;
            this.text_ensureCode.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.text_ensureCode.IsPasswordChat = '\0';
            this.text_ensureCode.IsSystemPasswordChar = false;
            this.text_ensureCode.Lines = new string[0];
            this.text_ensureCode.Location = new System.Drawing.Point(250, 240);
            this.text_ensureCode.Margin = new System.Windows.Forms.Padding(0);
            this.text_ensureCode.MaxLength = 32767;
            this.text_ensureCode.MinimumSize = new System.Drawing.Size(28, 28);
            this.text_ensureCode.MouseBack = null;
            this.text_ensureCode.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.text_ensureCode.Multiline = false;
            this.text_ensureCode.Name = "text_ensureCode";
            this.text_ensureCode.NormlBack = null;
            this.text_ensureCode.Padding = new System.Windows.Forms.Padding(5);
            this.text_ensureCode.ReadOnly = false;
            this.text_ensureCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.text_ensureCode.Size = new System.Drawing.Size(180, 28);
            // 
            // 
            // 
            this.text_ensureCode.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_ensureCode.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.text_ensureCode.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.text_ensureCode.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.text_ensureCode.SkinTxt.Name = "BaseText";
            this.text_ensureCode.SkinTxt.Size = new System.Drawing.Size(170, 19);
            this.text_ensureCode.SkinTxt.TabIndex = 0;
            this.text_ensureCode.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.text_ensureCode.SkinTxt.WaterText = "";
            this.text_ensureCode.TabIndex = 2;
            this.text_ensureCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.text_ensureCode.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.text_ensureCode.WaterText = "";
            this.text_ensureCode.WordWrap = true;
            // 
            // combox_power
            // 
            this.combox_power.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combox_power.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combox_power.FormattingEnabled = true;
            this.combox_power.Items.AddRange(new object[] {
            "管理员",
            "前台"});
            this.combox_power.Location = new System.Drawing.Point(250, 320);
            this.combox_power.Name = "combox_power";
            this.combox_power.Size = new System.Drawing.Size(280, 27);
            this.combox_power.TabIndex = 3;
            this.combox_power.WaterText = "";
            // 
            // login
            // 
            this.AcceptButton = this.but_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.but_cancel;
            this.ClientSize = new System.Drawing.Size(764, 441);
            this.Controls.Add(this.combox_power);
            this.Controls.Add(this.text_ensureCode);
            this.Controls.Add(this.text_passwd);
            this.Controls.Add(this.text_userName);
            this.Controls.Add(this.checkCode);
            this.Controls.Add(this.skinLabel4);
            this.Controls.Add(this.skinLabel3);
            this.Controls.Add(this.skinLabel2);
            this.Controls.Add(this.skinLabel1);
            this.Controls.Add(this.but_cancel);
            this.Controls.Add(this.but_ok);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "login";
            this.Opacity = 0.92D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录";
            this.Load += new System.EventHandler(this.login_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button but_ok;
        private System.Windows.Forms.Button but_cancel;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinLabel skinLabel3;
        private CCWin.SkinControl.SkinLabel skinLabel4;
        private CCWin.SkinControl.SkinLabel checkCode;
        private CCWin.SkinControl.SkinTextBox text_userName;
        private CCWin.SkinControl.SkinTextBox text_passwd;
        private CCWin.SkinControl.SkinTextBox text_ensureCode;
        private CCWin.SkinControl.SkinComboBox combox_power;
    }
}