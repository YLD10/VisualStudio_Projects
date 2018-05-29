namespace Maticsoft.Hotel
{
    partial class AlterManager
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
            this.btCancel = new System.Windows.Forms.Button();
            this.btConfirm = new System.Windows.Forms.Button();
            this.nudAge = new System.Windows.Forms.NumericUpDown();
            this.cbSex = new System.Windows.Forms.ComboBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.labPhoto = new System.Windows.Forms.Label();
            this.labAge = new System.Windows.Forms.Label();
            this.labSex = new System.Windows.Forms.Label();
            this.labName = new System.Windows.Forms.Label();
            this.labID = new System.Windows.Forms.Label();
            this.pbPhoto = new System.Windows.Forms.PictureBox();
            this.btScan = new System.Windows.Forms.Button();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.nudAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // btCancel
            // 
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(290, 218);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 23;
            this.btCancel.Text = "取消";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btConfirm
            // 
            this.btConfirm.Location = new System.Drawing.Point(108, 218);
            this.btConfirm.Name = "btConfirm";
            this.btConfirm.Size = new System.Drawing.Size(75, 23);
            this.btConfirm.TabIndex = 22;
            this.btConfirm.Text = "确定";
            this.btConfirm.UseVisualStyleBackColor = true;
            this.btConfirm.Click += new System.EventHandler(this.btConfirm_Click);
            // 
            // nudAge
            // 
            this.nudAge.Location = new System.Drawing.Point(162, 159);
            this.nudAge.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudAge.Minimum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.nudAge.Name = "nudAge";
            this.nudAge.Size = new System.Drawing.Size(120, 21);
            this.nudAge.TabIndex = 20;
            this.nudAge.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // cbSex
            // 
            this.cbSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSex.FormattingEnabled = true;
            this.cbSex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.cbSex.Location = new System.Drawing.Point(162, 116);
            this.cbSex.Name = "cbSex";
            this.cbSex.Size = new System.Drawing.Size(121, 20);
            this.cbSex.TabIndex = 19;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(162, 74);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(120, 21);
            this.tbName.TabIndex = 18;
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(162, 31);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(120, 21);
            this.tbID.TabIndex = 17;
            this.tbID.TextChanged += new System.EventHandler(this.tbID_TextChanged_1);
            // 
            // labPhoto
            // 
            this.labPhoto.AutoSize = true;
            this.labPhoto.Location = new System.Drawing.Point(324, 31);
            this.labPhoto.Name = "labPhoto";
            this.labPhoto.Size = new System.Drawing.Size(41, 12);
            this.labPhoto.TabIndex = 16;
            this.labPhoto.Text = "照片：";
            this.labPhoto.Click += new System.EventHandler(this.labPhoto_Click);
            // 
            // labAge
            // 
            this.labAge.AutoSize = true;
            this.labAge.Location = new System.Drawing.Point(66, 161);
            this.labAge.Name = "labAge";
            this.labAge.Size = new System.Drawing.Size(41, 12);
            this.labAge.TabIndex = 15;
            this.labAge.Text = "年龄：";
            // 
            // labSex
            // 
            this.labSex.AutoSize = true;
            this.labSex.Location = new System.Drawing.Point(66, 116);
            this.labSex.Name = "labSex";
            this.labSex.Size = new System.Drawing.Size(41, 12);
            this.labSex.TabIndex = 14;
            this.labSex.Text = "性别：";
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Location = new System.Drawing.Point(66, 77);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(41, 12);
            this.labName.TabIndex = 13;
            this.labName.Text = "姓名：";
            // 
            // labID
            // 
            this.labID.AutoSize = true;
            this.labID.Location = new System.Drawing.Point(62, 34);
            this.labID.Name = "labID";
            this.labID.Size = new System.Drawing.Size(65, 12);
            this.labID.TabIndex = 12;
            this.labID.Text = "前台工号：";
            // 
            // pbPhoto
            // 
            this.pbPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPhoto.Location = new System.Drawing.Point(395, 31);
            this.pbPhoto.Name = "pbPhoto";
            this.pbPhoto.Size = new System.Drawing.Size(100, 115);
            this.pbPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPhoto.TabIndex = 21;
            this.pbPhoto.TabStop = false;
            // 
            // btScan
            // 
            this.btScan.Location = new System.Drawing.Point(467, 156);
            this.btScan.Name = "btScan";
            this.btScan.Size = new System.Drawing.Size(51, 23);
            this.btScan.TabIndex = 24;
            this.btScan.Text = "浏览";
            this.btScan.UseVisualStyleBackColor = true;
            this.btScan.Click += new System.EventHandler(this.btScan_Click);
            // 
            // tbPath
            // 
            this.tbPath.Location = new System.Drawing.Point(349, 158);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(100, 21);
            this.tbPath.TabIndex = 25;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // AlterManager
            // 
            this.AcceptButton = this.btConfirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btCancel;
            this.ClientSize = new System.Drawing.Size(530, 264);
            this.Controls.Add(this.tbPath);
            this.Controls.Add(this.btScan);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btConfirm);
            this.Controls.Add(this.pbPhoto);
            this.Controls.Add(this.nudAge);
            this.Controls.Add(this.cbSex);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.labPhoto);
            this.Controls.Add(this.labAge);
            this.Controls.Add(this.labSex);
            this.Controls.Add(this.labName);
            this.Controls.Add(this.labID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AlterManager";
            this.Text = "AlterManager";
            this.Load += new System.EventHandler(this.AlterManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btConfirm;
        private System.Windows.Forms.PictureBox pbPhoto;
        private System.Windows.Forms.NumericUpDown nudAge;
        private System.Windows.Forms.ComboBox cbSex;
        private System.Windows.Forms.TextBox tbName;
        public System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label labPhoto;
        private System.Windows.Forms.Label labAge;
        private System.Windows.Forms.Label labSex;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label labID;
        private System.Windows.Forms.Button btScan;
        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}