namespace Form_SC
{
    partial class UpdateStudent
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
            this.rbStuSex0 = new System.Windows.Forms.RadioButton();
            this.rbStuSex1 = new System.Windows.Forms.RadioButton();
            this.btCancel = new System.Windows.Forms.Button();
            this.btConfirm = new System.Windows.Forms.Button();
            this.tbConfirmPasswd = new System.Windows.Forms.TextBox();
            this.tbStuClass = new System.Windows.Forms.TextBox();
            this.tbStuCollege = new System.Windows.Forms.TextBox();
            this.tbStuName = new System.Windows.Forms.TextBox();
            this.tbPasswd = new System.Windows.Forms.TextBox();
            this.tbStuMajor = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.labConfirmPasswd = new System.Windows.Forms.Label();
            this.labPasswd = new System.Windows.Forms.Label();
            this.labStuClass = new System.Windows.Forms.Label();
            this.labStuMajor = new System.Windows.Forms.Label();
            this.labStuSex = new System.Windows.Forms.Label();
            this.labStuCollege = new System.Windows.Forms.Label();
            this.labStuName = new System.Windows.Forms.Label();
            this.labID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rbStuSex0
            // 
            this.rbStuSex0.AutoSize = true;
            this.rbStuSex0.Location = new System.Drawing.Point(202, 107);
            this.rbStuSex0.Name = "rbStuSex0";
            this.rbStuSex0.Size = new System.Drawing.Size(35, 16);
            this.rbStuSex0.TabIndex = 28;
            this.rbStuSex0.TabStop = true;
            this.rbStuSex0.Text = "女";
            this.rbStuSex0.UseVisualStyleBackColor = true;
            // 
            // rbStuSex1
            // 
            this.rbStuSex1.AutoSize = true;
            this.rbStuSex1.Location = new System.Drawing.Point(137, 107);
            this.rbStuSex1.Name = "rbStuSex1";
            this.rbStuSex1.Size = new System.Drawing.Size(35, 16);
            this.rbStuSex1.TabIndex = 29;
            this.rbStuSex1.TabStop = true;
            this.rbStuSex1.Text = "男";
            this.rbStuSex1.UseVisualStyleBackColor = true;
            // 
            // btCancel
            // 
            this.btCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(202, 352);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 9;
            this.btCancel.Text = "取消";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btConfirm
            // 
            this.btConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btConfirm.Location = new System.Drawing.Point(64, 352);
            this.btConfirm.Name = "btConfirm";
            this.btConfirm.Size = new System.Drawing.Size(75, 23);
            this.btConfirm.TabIndex = 8;
            this.btConfirm.Text = "确认";
            this.btConfirm.UseVisualStyleBackColor = true;
            this.btConfirm.Click += new System.EventHandler(this.btConfirm_Click);
            // 
            // tbConfirmPasswd
            // 
            this.tbConfirmPasswd.Location = new System.Drawing.Point(125, 302);
            this.tbConfirmPasswd.Name = "tbConfirmPasswd";
            this.tbConfirmPasswd.PasswordChar = '*';
            this.tbConfirmPasswd.Size = new System.Drawing.Size(130, 21);
            this.tbConfirmPasswd.TabIndex = 7;
            // 
            // tbStuClass
            // 
            this.tbStuClass.Location = new System.Drawing.Point(125, 221);
            this.tbStuClass.Name = "tbStuClass";
            this.tbStuClass.Size = new System.Drawing.Size(130, 21);
            this.tbStuClass.TabIndex = 5;
            // 
            // tbStuCollege
            // 
            this.tbStuCollege.Location = new System.Drawing.Point(125, 139);
            this.tbStuCollege.Name = "tbStuCollege";
            this.tbStuCollege.Size = new System.Drawing.Size(130, 21);
            this.tbStuCollege.TabIndex = 3;
            // 
            // tbStuName
            // 
            this.tbStuName.Location = new System.Drawing.Point(125, 67);
            this.tbStuName.Name = "tbStuName";
            this.tbStuName.Size = new System.Drawing.Size(130, 21);
            this.tbStuName.TabIndex = 2;
            // 
            // tbPasswd
            // 
            this.tbPasswd.Location = new System.Drawing.Point(125, 261);
            this.tbPasswd.Name = "tbPasswd";
            this.tbPasswd.PasswordChar = '*';
            this.tbPasswd.Size = new System.Drawing.Size(130, 21);
            this.tbPasswd.TabIndex = 6;
            // 
            // tbStuMajor
            // 
            this.tbStuMajor.Location = new System.Drawing.Point(125, 180);
            this.tbStuMajor.Name = "tbStuMajor";
            this.tbStuMajor.Size = new System.Drawing.Size(130, 21);
            this.tbStuMajor.TabIndex = 4;
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(125, 26);
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(130, 21);
            this.tbID.TabIndex = 1;
            // 
            // labConfirmPasswd
            // 
            this.labConfirmPasswd.AutoSize = true;
            this.labConfirmPasswd.Location = new System.Drawing.Point(54, 305);
            this.labConfirmPasswd.Name = "labConfirmPasswd";
            this.labConfirmPasswd.Size = new System.Drawing.Size(65, 12);
            this.labConfirmPasswd.TabIndex = 0;
            this.labConfirmPasswd.Text = "确认密码：";
            // 
            // labPasswd
            // 
            this.labPasswd.AutoSize = true;
            this.labPasswd.Location = new System.Drawing.Point(78, 264);
            this.labPasswd.Name = "labPasswd";
            this.labPasswd.Size = new System.Drawing.Size(41, 12);
            this.labPasswd.TabIndex = 0;
            this.labPasswd.Text = "密码：";
            // 
            // labStuClass
            // 
            this.labStuClass.AutoSize = true;
            this.labStuClass.Location = new System.Drawing.Point(78, 224);
            this.labStuClass.Name = "labStuClass";
            this.labStuClass.Size = new System.Drawing.Size(41, 12);
            this.labStuClass.TabIndex = 0;
            this.labStuClass.Text = "班级：";
            // 
            // labStuMajor
            // 
            this.labStuMajor.AutoSize = true;
            this.labStuMajor.Location = new System.Drawing.Point(78, 183);
            this.labStuMajor.Name = "labStuMajor";
            this.labStuMajor.Size = new System.Drawing.Size(41, 12);
            this.labStuMajor.TabIndex = 0;
            this.labStuMajor.Text = "专业：";
            // 
            // labStuSex
            // 
            this.labStuSex.AutoSize = true;
            this.labStuSex.Location = new System.Drawing.Point(78, 109);
            this.labStuSex.Name = "labStuSex";
            this.labStuSex.Size = new System.Drawing.Size(41, 12);
            this.labStuSex.TabIndex = 0;
            this.labStuSex.Text = "性别：";
            // 
            // labStuCollege
            // 
            this.labStuCollege.AutoSize = true;
            this.labStuCollege.Location = new System.Drawing.Point(78, 142);
            this.labStuCollege.Name = "labStuCollege";
            this.labStuCollege.Size = new System.Drawing.Size(41, 12);
            this.labStuCollege.TabIndex = 0;
            this.labStuCollege.Text = "学院：";
            // 
            // labStuName
            // 
            this.labStuName.AutoSize = true;
            this.labStuName.Location = new System.Drawing.Point(78, 70);
            this.labStuName.Name = "labStuName";
            this.labStuName.Size = new System.Drawing.Size(41, 12);
            this.labStuName.TabIndex = 0;
            this.labStuName.Text = "姓名：";
            // 
            // labID
            // 
            this.labID.AutoSize = true;
            this.labID.Location = new System.Drawing.Point(78, 29);
            this.labID.Name = "labID";
            this.labID.Size = new System.Drawing.Size(41, 12);
            this.labID.TabIndex = 0;
            this.labID.Text = "学号：";
            // 
            // UpdateStudent
            // 
            this.AcceptButton = this.btConfirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btCancel;
            this.ClientSize = new System.Drawing.Size(343, 401);
            this.Controls.Add(this.rbStuSex0);
            this.Controls.Add(this.rbStuSex1);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btConfirm);
            this.Controls.Add(this.tbConfirmPasswd);
            this.Controls.Add(this.tbStuClass);
            this.Controls.Add(this.tbStuCollege);
            this.Controls.Add(this.tbStuName);
            this.Controls.Add(this.tbPasswd);
            this.Controls.Add(this.tbStuMajor);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.labConfirmPasswd);
            this.Controls.Add(this.labPasswd);
            this.Controls.Add(this.labStuClass);
            this.Controls.Add(this.labStuMajor);
            this.Controls.Add(this.labStuSex);
            this.Controls.Add(this.labStuCollege);
            this.Controls.Add(this.labStuName);
            this.Controls.Add(this.labID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "UpdateStudent";
            this.Text = "UpdateStudent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbStuSex0;
        private System.Windows.Forms.RadioButton rbStuSex1;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btConfirm;
        private System.Windows.Forms.TextBox tbConfirmPasswd;
        private System.Windows.Forms.TextBox tbStuClass;
        private System.Windows.Forms.TextBox tbStuCollege;
        private System.Windows.Forms.TextBox tbStuName;
        private System.Windows.Forms.TextBox tbPasswd;
        private System.Windows.Forms.TextBox tbStuMajor;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label labConfirmPasswd;
        private System.Windows.Forms.Label labPasswd;
        private System.Windows.Forms.Label labStuClass;
        private System.Windows.Forms.Label labStuMajor;
        private System.Windows.Forms.Label labStuSex;
        private System.Windows.Forms.Label labStuCollege;
        private System.Windows.Forms.Label labStuName;
        private System.Windows.Forms.Label labID;
    }
}