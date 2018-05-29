namespace Maticsoft.Hotel
{
    partial class AddStaff
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
            this.labStaffID = new System.Windows.Forms.Label();
            this.labStaffName = new System.Windows.Forms.Label();
            this.labStaffSex = new System.Windows.Forms.Label();
            this.labStaffAge = new System.Windows.Forms.Label();
            this.AddStaffPhoto = new System.Windows.Forms.Label();
            this.tbStaffID = new System.Windows.Forms.TextBox();
            this.tbStaffName = new System.Windows.Forms.TextBox();
            this.cbStaffSex = new System.Windows.Forms.ComboBox();
            this.nupStaffAge = new System.Windows.Forms.NumericUpDown();
            this.pbPhoto = new System.Windows.Forms.PictureBox();
            this.btConfirm = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btScan = new System.Windows.Forms.Button();
            this.tbPath = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nupStaffAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // labStaffID
            // 
            this.labStaffID.AutoSize = true;
            this.labStaffID.Location = new System.Drawing.Point(38, 36);
            this.labStaffID.Name = "labStaffID";
            this.labStaffID.Size = new System.Drawing.Size(65, 12);
            this.labStaffID.TabIndex = 0;
            this.labStaffID.Text = "员工工号：";
            // 
            // labStaffName
            // 
            this.labStaffName.AutoSize = true;
            this.labStaffName.Location = new System.Drawing.Point(38, 76);
            this.labStaffName.Name = "labStaffName";
            this.labStaffName.Size = new System.Drawing.Size(41, 12);
            this.labStaffName.TabIndex = 1;
            this.labStaffName.Text = "姓名：";
            // 
            // labStaffSex
            // 
            this.labStaffSex.AutoSize = true;
            this.labStaffSex.Location = new System.Drawing.Point(38, 114);
            this.labStaffSex.Name = "labStaffSex";
            this.labStaffSex.Size = new System.Drawing.Size(41, 12);
            this.labStaffSex.TabIndex = 2;
            this.labStaffSex.Text = "性别：";
            // 
            // labStaffAge
            // 
            this.labStaffAge.AutoSize = true;
            this.labStaffAge.Location = new System.Drawing.Point(38, 154);
            this.labStaffAge.Name = "labStaffAge";
            this.labStaffAge.Size = new System.Drawing.Size(41, 12);
            this.labStaffAge.TabIndex = 3;
            this.labStaffAge.Text = "年龄：";
            // 
            // AddStaffPhoto
            // 
            this.AddStaffPhoto.AutoSize = true;
            this.AddStaffPhoto.Location = new System.Drawing.Point(270, 33);
            this.AddStaffPhoto.Name = "AddStaffPhoto";
            this.AddStaffPhoto.Size = new System.Drawing.Size(41, 12);
            this.AddStaffPhoto.TabIndex = 4;
            this.AddStaffPhoto.Text = "照片：";
            // 
            // tbStaffID
            // 
            this.tbStaffID.Location = new System.Drawing.Point(131, 33);
            this.tbStaffID.Name = "tbStaffID";
            this.tbStaffID.Size = new System.Drawing.Size(121, 21);
            this.tbStaffID.TabIndex = 5;
            // 
            // tbStaffName
            // 
            this.tbStaffName.Location = new System.Drawing.Point(131, 73);
            this.tbStaffName.Name = "tbStaffName";
            this.tbStaffName.Size = new System.Drawing.Size(121, 21);
            this.tbStaffName.TabIndex = 6;
            // 
            // cbStaffSex
            // 
            this.cbStaffSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStaffSex.FormattingEnabled = true;
            this.cbStaffSex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.cbStaffSex.Location = new System.Drawing.Point(131, 111);
            this.cbStaffSex.Name = "cbStaffSex";
            this.cbStaffSex.Size = new System.Drawing.Size(121, 20);
            this.cbStaffSex.TabIndex = 7;
            // 
            // nupStaffAge
            // 
            this.nupStaffAge.Location = new System.Drawing.Point(132, 152);
            this.nupStaffAge.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nupStaffAge.Minimum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.nupStaffAge.Name = "nupStaffAge";
            this.nupStaffAge.Size = new System.Drawing.Size(120, 21);
            this.nupStaffAge.TabIndex = 8;
            this.nupStaffAge.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // pbPhoto
            // 
            this.pbPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPhoto.Location = new System.Drawing.Point(331, 36);
            this.pbPhoto.Name = "pbPhoto";
            this.pbPhoto.Size = new System.Drawing.Size(100, 121);
            this.pbPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPhoto.TabIndex = 9;
            this.pbPhoto.TabStop = false;
            // 
            // btConfirm
            // 
            this.btConfirm.Location = new System.Drawing.Point(94, 204);
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
            this.btCancel.Location = new System.Drawing.Point(284, 204);
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
            this.btScan.Location = new System.Drawing.Point(418, 164);
            this.btScan.Name = "btScan";
            this.btScan.Size = new System.Drawing.Size(42, 23);
            this.btScan.TabIndex = 12;
            this.btScan.Text = "浏览";
            this.btScan.UseVisualStyleBackColor = true;
            this.btScan.Click += new System.EventHandler(this.btScan_Click);
            // 
            // tbPath
            // 
            this.tbPath.Location = new System.Drawing.Point(297, 166);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(100, 21);
            this.tbPath.TabIndex = 13;
            // 
            // AddStaff
            // 
            this.AcceptButton = this.btConfirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btCancel;
            this.ClientSize = new System.Drawing.Size(472, 277);
            this.Controls.Add(this.tbPath);
            this.Controls.Add(this.btScan);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btConfirm);
            this.Controls.Add(this.pbPhoto);
            this.Controls.Add(this.nupStaffAge);
            this.Controls.Add(this.cbStaffSex);
            this.Controls.Add(this.tbStaffName);
            this.Controls.Add(this.tbStaffID);
            this.Controls.Add(this.AddStaffPhoto);
            this.Controls.Add(this.labStaffAge);
            this.Controls.Add(this.labStaffSex);
            this.Controls.Add(this.labStaffName);
            this.Controls.Add(this.labStaffID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddStaff";
            this.Text = "AddStaff";
            this.Load += new System.EventHandler(this.AddStaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nupStaffAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labStaffID;
        private System.Windows.Forms.Label labStaffName;
        private System.Windows.Forms.Label labStaffSex;
        private System.Windows.Forms.Label labStaffAge;
        private System.Windows.Forms.Label AddStaffPhoto;
        private System.Windows.Forms.TextBox tbStaffID;
        private System.Windows.Forms.TextBox tbStaffName;
        private System.Windows.Forms.ComboBox cbStaffSex;
        private System.Windows.Forms.NumericUpDown nupStaffAge;
        private System.Windows.Forms.PictureBox pbPhoto;
        private System.Windows.Forms.Button btConfirm;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btScan;
        private System.Windows.Forms.TextBox tbPath;
    }
}