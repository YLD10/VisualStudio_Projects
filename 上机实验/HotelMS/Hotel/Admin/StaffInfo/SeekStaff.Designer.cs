namespace Maticsoft.Hotel
{
    partial class SeekStaff
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
            this.label5 = new System.Windows.Forms.Label();
            this.tbStaffID = new System.Windows.Forms.TextBox();
            this.tbStaffName = new System.Windows.Forms.TextBox();
            this.tbStaffSex = new System.Windows.Forms.TextBox();
            this.tbStaffAge = new System.Windows.Forms.TextBox();
            this.pbPhoto = new System.Windows.Forms.PictureBox();
            this.btConfirm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // labStaffID
            // 
            this.labStaffID.AutoSize = true;
            this.labStaffID.Location = new System.Drawing.Point(33, 37);
            this.labStaffID.Name = "labStaffID";
            this.labStaffID.Size = new System.Drawing.Size(65, 12);
            this.labStaffID.TabIndex = 0;
            this.labStaffID.Text = "员工工号：";
            // 
            // labStaffName
            // 
            this.labStaffName.AutoSize = true;
            this.labStaffName.Location = new System.Drawing.Point(33, 76);
            this.labStaffName.Name = "labStaffName";
            this.labStaffName.Size = new System.Drawing.Size(41, 12);
            this.labStaffName.TabIndex = 1;
            this.labStaffName.Text = "姓名：";
            // 
            // labStaffSex
            // 
            this.labStaffSex.AutoSize = true;
            this.labStaffSex.Location = new System.Drawing.Point(33, 116);
            this.labStaffSex.Name = "labStaffSex";
            this.labStaffSex.Size = new System.Drawing.Size(41, 12);
            this.labStaffSex.TabIndex = 2;
            this.labStaffSex.Text = "性别：";
            // 
            // labStaffAge
            // 
            this.labStaffAge.AutoSize = true;
            this.labStaffAge.Location = new System.Drawing.Point(35, 162);
            this.labStaffAge.Name = "labStaffAge";
            this.labStaffAge.Size = new System.Drawing.Size(41, 12);
            this.labStaffAge.TabIndex = 3;
            this.labStaffAge.Text = "年龄：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(276, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "照片：";
            // 
            // tbStaffID
            // 
            this.tbStaffID.Location = new System.Drawing.Point(150, 34);
            this.tbStaffID.Name = "tbStaffID";
            this.tbStaffID.ReadOnly = true;
            this.tbStaffID.Size = new System.Drawing.Size(100, 21);
            this.tbStaffID.TabIndex = 5;
            // 
            // tbStaffName
            // 
            this.tbStaffName.Location = new System.Drawing.Point(150, 73);
            this.tbStaffName.Name = "tbStaffName";
            this.tbStaffName.ReadOnly = true;
            this.tbStaffName.Size = new System.Drawing.Size(100, 21);
            this.tbStaffName.TabIndex = 6;
            // 
            // tbStaffSex
            // 
            this.tbStaffSex.Location = new System.Drawing.Point(150, 113);
            this.tbStaffSex.Name = "tbStaffSex";
            this.tbStaffSex.ReadOnly = true;
            this.tbStaffSex.Size = new System.Drawing.Size(100, 21);
            this.tbStaffSex.TabIndex = 7;
            // 
            // tbStaffAge
            // 
            this.tbStaffAge.Location = new System.Drawing.Point(150, 159);
            this.tbStaffAge.Name = "tbStaffAge";
            this.tbStaffAge.ReadOnly = true;
            this.tbStaffAge.Size = new System.Drawing.Size(100, 21);
            this.tbStaffAge.TabIndex = 8;
            // 
            // pbPhoto
            // 
            this.pbPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPhoto.Location = new System.Drawing.Point(335, 34);
            this.pbPhoto.Name = "pbPhoto";
            this.pbPhoto.Size = new System.Drawing.Size(100, 140);
            this.pbPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPhoto.TabIndex = 9;
            this.pbPhoto.TabStop = false;
            // 
            // btConfirm
            // 
            this.btConfirm.Location = new System.Drawing.Point(205, 204);
            this.btConfirm.Name = "btConfirm";
            this.btConfirm.Size = new System.Drawing.Size(75, 23);
            this.btConfirm.TabIndex = 10;
            this.btConfirm.Text = "确定";
            this.btConfirm.UseVisualStyleBackColor = true;
            this.btConfirm.Click += new System.EventHandler(this.btConfirm_Click);
            // 
            // SeekStaff
            // 
            this.AcceptButton = this.btConfirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 258);
            this.Controls.Add(this.btConfirm);
            this.Controls.Add(this.pbPhoto);
            this.Controls.Add(this.tbStaffAge);
            this.Controls.Add(this.tbStaffSex);
            this.Controls.Add(this.tbStaffName);
            this.Controls.Add(this.tbStaffID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labStaffAge);
            this.Controls.Add(this.labStaffSex);
            this.Controls.Add(this.labStaffName);
            this.Controls.Add(this.labStaffID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SeekStaff";
            this.Text = "SeekStaff";
            this.Load += new System.EventHandler(this.SeekStaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labStaffID;
        private System.Windows.Forms.Label labStaffName;
        private System.Windows.Forms.Label labStaffSex;
        private System.Windows.Forms.Label labStaffAge;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btConfirm;
        public System.Windows.Forms.TextBox tbStaffID;
        public System.Windows.Forms.TextBox tbStaffName;
        public System.Windows.Forms.TextBox tbStaffSex;
        public System.Windows.Forms.TextBox tbStaffAge;
        public System.Windows.Forms.PictureBox pbPhoto;
    }
}