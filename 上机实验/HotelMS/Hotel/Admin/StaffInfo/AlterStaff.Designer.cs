namespace Maticsoft.Hotel
{
    partial class AlterStaff
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
            this.labID = new System.Windows.Forms.Label();
            this.labName = new System.Windows.Forms.Label();
            this.labSex = new System.Windows.Forms.Label();
            this.labAge = new System.Windows.Forms.Label();
            this.labPhoto = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.cbSex = new System.Windows.Forms.ComboBox();
            this.nudAge = new System.Windows.Forms.NumericUpDown();
            this.pbPhoto = new System.Windows.Forms.PictureBox();
            this.btConfirm = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btScan = new System.Windows.Forms.Button();
            this.tbPath = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // labID
            // 
            this.labID.AutoSize = true;
            this.labID.Location = new System.Drawing.Point(40, 42);
            this.labID.Name = "labID";
            this.labID.Size = new System.Drawing.Size(65, 12);
            this.labID.TabIndex = 0;
            this.labID.Text = "员工工号：";
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Location = new System.Drawing.Point(44, 85);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(41, 12);
            this.labName.TabIndex = 1;
            this.labName.Text = "姓名：";
            this.labName.Click += new System.EventHandler(this.label2_Click);
            // 
            // labSex
            // 
            this.labSex.AutoSize = true;
            this.labSex.Location = new System.Drawing.Point(44, 124);
            this.labSex.Name = "labSex";
            this.labSex.Size = new System.Drawing.Size(41, 12);
            this.labSex.TabIndex = 2;
            this.labSex.Text = "性别：";
            // 
            // labAge
            // 
            this.labAge.AutoSize = true;
            this.labAge.Location = new System.Drawing.Point(44, 169);
            this.labAge.Name = "labAge";
            this.labAge.Size = new System.Drawing.Size(41, 12);
            this.labAge.TabIndex = 3;
            this.labAge.Text = "年龄：";
            // 
            // labPhoto
            // 
            this.labPhoto.AutoSize = true;
            this.labPhoto.Location = new System.Drawing.Point(290, 42);
            this.labPhoto.Name = "labPhoto";
            this.labPhoto.Size = new System.Drawing.Size(41, 12);
            this.labPhoto.TabIndex = 4;
            this.labPhoto.Text = "照片：";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(140, 39);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(120, 21);
            this.tbID.TabIndex = 5;
            this.tbID.TextChanged += new System.EventHandler(this.tbID_TextChanged);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(140, 82);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(120, 21);
            this.tbName.TabIndex = 6;
            // 
            // cbSex
            // 
            this.cbSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSex.FormattingEnabled = true;
            this.cbSex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.cbSex.Location = new System.Drawing.Point(140, 124);
            this.cbSex.Name = "cbSex";
            this.cbSex.Size = new System.Drawing.Size(121, 20);
            this.cbSex.TabIndex = 7;
            // 
            // nudAge
            // 
            this.nudAge.Location = new System.Drawing.Point(140, 167);
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
            this.nudAge.TabIndex = 8;
            this.nudAge.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // pbPhoto
            // 
            this.pbPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPhoto.Location = new System.Drawing.Point(337, 39);
            this.pbPhoto.Name = "pbPhoto";
            this.pbPhoto.Size = new System.Drawing.Size(100, 115);
            this.pbPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPhoto.TabIndex = 9;
            this.pbPhoto.TabStop = false;
            // 
            // btConfirm
            // 
            this.btConfirm.Location = new System.Drawing.Point(90, 222);
            this.btConfirm.Name = "btConfirm";
            this.btConfirm.Size = new System.Drawing.Size(75, 23);
            this.btConfirm.TabIndex = 10;
            this.btConfirm.Text = "确定";
            this.btConfirm.UseVisualStyleBackColor = true;
            this.btConfirm.Click += new System.EventHandler(this.btConfirm_Click);
            // 
            // btCancel
            // 
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(292, 222);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 11;
            this.btCancel.Text = "取消";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btScan
            // 
            this.btScan.Location = new System.Drawing.Point(417, 167);
            this.btScan.Name = "btScan";
            this.btScan.Size = new System.Drawing.Size(42, 23);
            this.btScan.TabIndex = 12;
            this.btScan.Text = "浏览";
            this.btScan.UseVisualStyleBackColor = true;
            this.btScan.Click += new System.EventHandler(this.btScan_Click);
            // 
            // tbPath
            // 
            this.tbPath.Location = new System.Drawing.Point(292, 167);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(100, 21);
            this.tbPath.TabIndex = 13;
            // 
            // AlterStaff
            // 
            this.AcceptButton = this.btConfirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btCancel;
            this.ClientSize = new System.Drawing.Size(471, 279);
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
            this.Name = "AlterStaff";
            this.Text = "AlterStaff";
            this.Load += new System.EventHandler(this.AlterStaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labID;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label labSex;
        private System.Windows.Forms.Label labAge;
        private System.Windows.Forms.Label labPhoto;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.ComboBox cbSex;
        private System.Windows.Forms.NumericUpDown nudAge;
        private System.Windows.Forms.PictureBox pbPhoto;
        private System.Windows.Forms.Button btConfirm;
        private System.Windows.Forms.Button btCancel;
        public System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btScan;
        private System.Windows.Forms.TextBox tbPath;
    }
}