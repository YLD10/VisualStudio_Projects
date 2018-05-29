namespace Form_SC
{
    partial class UpdateStuScore
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
            this.tbStuClass = new System.Windows.Forms.TextBox();
            this.tbStuCollege = new System.Windows.Forms.TextBox();
            this.tbStuName = new System.Windows.Forms.TextBox();
            this.tbStuMajor = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.labStuClass = new System.Windows.Forms.Label();
            this.labStuMajor = new System.Windows.Forms.Label();
            this.labStuCollege = new System.Windows.Forms.Label();
            this.labStuName = new System.Windows.Forms.Label();
            this.labID = new System.Windows.Forms.Label();
            this.labScore = new System.Windows.Forms.Label();
            this.tbScore = new System.Windows.Forms.TextBox();
            this.btCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btConfirm
            // 
            this.btConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btConfirm.Location = new System.Drawing.Point(65, 333);
            this.btConfirm.Name = "btConfirm";
            this.btConfirm.Size = new System.Drawing.Size(75, 23);
            this.btConfirm.TabIndex = 1;
            this.btConfirm.Text = "确认";
            this.btConfirm.UseVisualStyleBackColor = true;
            this.btConfirm.Click += new System.EventHandler(this.btConfirm_Click);
            // 
            // tbStuClass
            // 
            this.tbStuClass.Location = new System.Drawing.Point(124, 228);
            this.tbStuClass.Name = "tbStuClass";
            this.tbStuClass.ReadOnly = true;
            this.tbStuClass.Size = new System.Drawing.Size(130, 21);
            this.tbStuClass.TabIndex = 36;
            // 
            // tbStuCollege
            // 
            this.tbStuCollege.Location = new System.Drawing.Point(124, 129);
            this.tbStuCollege.Name = "tbStuCollege";
            this.tbStuCollege.ReadOnly = true;
            this.tbStuCollege.Size = new System.Drawing.Size(130, 21);
            this.tbStuCollege.TabIndex = 33;
            // 
            // tbStuName
            // 
            this.tbStuName.Location = new System.Drawing.Point(124, 82);
            this.tbStuName.Name = "tbStuName";
            this.tbStuName.ReadOnly = true;
            this.tbStuName.Size = new System.Drawing.Size(130, 21);
            this.tbStuName.TabIndex = 32;
            // 
            // tbStuMajor
            // 
            this.tbStuMajor.Location = new System.Drawing.Point(124, 178);
            this.tbStuMajor.Name = "tbStuMajor";
            this.tbStuMajor.ReadOnly = true;
            this.tbStuMajor.Size = new System.Drawing.Size(130, 21);
            this.tbStuMajor.TabIndex = 35;
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(124, 33);
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(130, 21);
            this.tbID.TabIndex = 31;
            // 
            // labStuClass
            // 
            this.labStuClass.AutoSize = true;
            this.labStuClass.Location = new System.Drawing.Point(77, 231);
            this.labStuClass.Name = "labStuClass";
            this.labStuClass.Size = new System.Drawing.Size(41, 12);
            this.labStuClass.TabIndex = 25;
            this.labStuClass.Text = "班级：";
            // 
            // labStuMajor
            // 
            this.labStuMajor.AutoSize = true;
            this.labStuMajor.Location = new System.Drawing.Point(77, 181);
            this.labStuMajor.Name = "labStuMajor";
            this.labStuMajor.Size = new System.Drawing.Size(41, 12);
            this.labStuMajor.TabIndex = 26;
            this.labStuMajor.Text = "专业：";
            // 
            // labStuCollege
            // 
            this.labStuCollege.AutoSize = true;
            this.labStuCollege.Location = new System.Drawing.Point(77, 132);
            this.labStuCollege.Name = "labStuCollege";
            this.labStuCollege.Size = new System.Drawing.Size(41, 12);
            this.labStuCollege.TabIndex = 30;
            this.labStuCollege.Text = "学院：";
            // 
            // labStuName
            // 
            this.labStuName.AutoSize = true;
            this.labStuName.Location = new System.Drawing.Point(77, 85);
            this.labStuName.Name = "labStuName";
            this.labStuName.Size = new System.Drawing.Size(41, 12);
            this.labStuName.TabIndex = 28;
            this.labStuName.Text = "姓名：";
            // 
            // labID
            // 
            this.labID.AutoSize = true;
            this.labID.Location = new System.Drawing.Point(77, 36);
            this.labID.Name = "labID";
            this.labID.Size = new System.Drawing.Size(41, 12);
            this.labID.TabIndex = 27;
            this.labID.Text = "学号：";
            // 
            // labScore
            // 
            this.labScore.AutoSize = true;
            this.labScore.Location = new System.Drawing.Point(77, 280);
            this.labScore.Name = "labScore";
            this.labScore.Size = new System.Drawing.Size(41, 12);
            this.labScore.TabIndex = 25;
            this.labScore.Text = "成绩：";
            // 
            // tbScore
            // 
            this.tbScore.Location = new System.Drawing.Point(124, 277);
            this.tbScore.Name = "tbScore";
            this.tbScore.Size = new System.Drawing.Size(130, 21);
            this.tbScore.TabIndex = 0;
            // 
            // btCancel
            // 
            this.btCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(201, 333);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 2;
            this.btCancel.Text = "取消";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // UpdateStuScore
            // 
            this.AcceptButton = this.btConfirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btCancel;
            this.ClientSize = new System.Drawing.Size(346, 394);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btConfirm);
            this.Controls.Add(this.tbScore);
            this.Controls.Add(this.tbStuClass);
            this.Controls.Add(this.tbStuCollege);
            this.Controls.Add(this.tbStuName);
            this.Controls.Add(this.tbStuMajor);
            this.Controls.Add(this.labScore);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.labStuClass);
            this.Controls.Add(this.labStuMajor);
            this.Controls.Add(this.labStuCollege);
            this.Controls.Add(this.labStuName);
            this.Controls.Add(this.labID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "UpdateStuScore";
            this.Text = "UpdateStuScore";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btConfirm;
        private System.Windows.Forms.TextBox tbStuClass;
        private System.Windows.Forms.TextBox tbStuCollege;
        private System.Windows.Forms.TextBox tbStuName;
        private System.Windows.Forms.TextBox tbStuMajor;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label labStuClass;
        private System.Windows.Forms.Label labStuMajor;
        private System.Windows.Forms.Label labStuCollege;
        private System.Windows.Forms.Label labStuName;
        private System.Windows.Forms.Label labID;
        private System.Windows.Forms.Label labScore;
        private System.Windows.Forms.TextBox tbScore;
        private System.Windows.Forms.Button btCancel;
    }
}