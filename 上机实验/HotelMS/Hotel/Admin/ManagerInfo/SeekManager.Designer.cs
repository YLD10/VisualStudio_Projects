namespace Maticsoft.Hotel
{
    partial class SeekManager
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
            this.btConfirm = new System.Windows.Forms.Button();
            this.pbPhoto = new System.Windows.Forms.PictureBox();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.tbSex = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.labPhoto = new System.Windows.Forms.Label();
            this.labAge = new System.Windows.Forms.Label();
            this.labSex = new System.Windows.Forms.Label();
            this.labName = new System.Windows.Forms.Label();
            this.labID = new System.Windows.Forms.Label();
            this.labPasswd = new System.Windows.Forms.Label();
            this.tbPasswd = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // btConfirm
            // 
            this.btConfirm.Location = new System.Drawing.Point(207, 208);
            this.btConfirm.Name = "btConfirm";
            this.btConfirm.Size = new System.Drawing.Size(75, 23);
            this.btConfirm.TabIndex = 21;
            this.btConfirm.Text = "确定";
            this.btConfirm.UseVisualStyleBackColor = true;
            this.btConfirm.Click += new System.EventHandler(this.btConfirm_Click);
            // 
            // pbPhoto
            // 
            this.pbPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPhoto.Location = new System.Drawing.Point(339, 5);
            this.pbPhoto.Name = "pbPhoto";
            this.pbPhoto.Size = new System.Drawing.Size(117, 140);
            this.pbPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPhoto.TabIndex = 20;
            this.pbPhoto.TabStop = false;
            // 
            // tbAge
            // 
            this.tbAge.Location = new System.Drawing.Point(156, 127);
            this.tbAge.Name = "tbAge";
            this.tbAge.ReadOnly = true;
            this.tbAge.Size = new System.Drawing.Size(100, 21);
            this.tbAge.TabIndex = 19;
            // 
            // tbSex
            // 
            this.tbSex.Location = new System.Drawing.Point(156, 81);
            this.tbSex.Name = "tbSex";
            this.tbSex.ReadOnly = true;
            this.tbSex.Size = new System.Drawing.Size(100, 21);
            this.tbSex.TabIndex = 18;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(156, 41);
            this.tbName.Name = "tbName";
            this.tbName.ReadOnly = true;
            this.tbName.Size = new System.Drawing.Size(100, 21);
            this.tbName.TabIndex = 17;
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(156, 2);
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(100, 21);
            this.tbID.TabIndex = 16;
            // 
            // labPhoto
            // 
            this.labPhoto.AutoSize = true;
            this.labPhoto.Location = new System.Drawing.Point(274, 5);
            this.labPhoto.Name = "labPhoto";
            this.labPhoto.Size = new System.Drawing.Size(41, 12);
            this.labPhoto.TabIndex = 15;
            this.labPhoto.Text = "照片：";
            // 
            // labAge
            // 
            this.labAge.AutoSize = true;
            this.labAge.Location = new System.Drawing.Point(41, 130);
            this.labAge.Name = "labAge";
            this.labAge.Size = new System.Drawing.Size(41, 12);
            this.labAge.TabIndex = 14;
            this.labAge.Text = "年龄：";
            // 
            // labSex
            // 
            this.labSex.AutoSize = true;
            this.labSex.Location = new System.Drawing.Point(39, 84);
            this.labSex.Name = "labSex";
            this.labSex.Size = new System.Drawing.Size(41, 12);
            this.labSex.TabIndex = 13;
            this.labSex.Text = "性别：";
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Location = new System.Drawing.Point(39, 44);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(41, 12);
            this.labName.TabIndex = 12;
            this.labName.Text = "姓名：";
            // 
            // labID
            // 
            this.labID.AutoSize = true;
            this.labID.Location = new System.Drawing.Point(39, 5);
            this.labID.Name = "labID";
            this.labID.Size = new System.Drawing.Size(65, 12);
            this.labID.TabIndex = 11;
            this.labID.Text = "前台工号：";
            // 
            // labPasswd
            // 
            this.labPasswd.AutoSize = true;
            this.labPasswd.Location = new System.Drawing.Point(41, 165);
            this.labPasswd.Name = "labPasswd";
            this.labPasswd.Size = new System.Drawing.Size(41, 12);
            this.labPasswd.TabIndex = 22;
            this.labPasswd.Text = "密码：";
            // 
            // tbPasswd
            // 
            this.tbPasswd.Location = new System.Drawing.Point(156, 162);
            this.tbPasswd.Name = "tbPasswd";
            this.tbPasswd.ReadOnly = true;
            this.tbPasswd.Size = new System.Drawing.Size(100, 21);
            this.tbPasswd.TabIndex = 23;
            // 
            // SeekManager
            // 
            this.AcceptButton = this.btConfirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 244);
            this.Controls.Add(this.tbPasswd);
            this.Controls.Add(this.labPasswd);
            this.Controls.Add(this.btConfirm);
            this.Controls.Add(this.pbPhoto);
            this.Controls.Add(this.tbAge);
            this.Controls.Add(this.tbSex);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.labPhoto);
            this.Controls.Add(this.labAge);
            this.Controls.Add(this.labSex);
            this.Controls.Add(this.labName);
            this.Controls.Add(this.labID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SeekManager";
            this.Text = "SeekManager";
            this.Load += new System.EventHandler(this.SeekManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btConfirm;
        public System.Windows.Forms.TextBox tbAge;
        public System.Windows.Forms.TextBox tbSex;
        public System.Windows.Forms.TextBox tbName;
        public System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label labPhoto;
        private System.Windows.Forms.Label labAge;
        private System.Windows.Forms.Label labSex;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label labID;
        private System.Windows.Forms.Label labPasswd;
        public System.Windows.Forms.TextBox tbPasswd;
        public System.Windows.Forms.PictureBox pbPhoto;
    }
}