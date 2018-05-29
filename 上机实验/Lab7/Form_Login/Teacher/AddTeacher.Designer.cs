namespace Form_SC
{
    partial class AddTeacher
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
            this.rbTeaSex0 = new System.Windows.Forms.RadioButton();
            this.rbTeaSex1 = new System.Windows.Forms.RadioButton();
            this.tbTeaTitle = new System.Windows.Forms.TextBox();
            this.tbTeaName = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.labTeaSex = new System.Windows.Forms.Label();
            this.labTeaTitle = new System.Windows.Forms.Label();
            this.labTeaName = new System.Windows.Forms.Label();
            this.labID = new System.Windows.Forms.Label();
            this.btCancel = new System.Windows.Forms.Button();
            this.btConfirm = new System.Windows.Forms.Button();
            this.tbConfirmPasswd = new System.Windows.Forms.TextBox();
            this.tbPasswd = new System.Windows.Forms.TextBox();
            this.labConfirmPasswd = new System.Windows.Forms.Label();
            this.labPasswd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rbTeaSex0
            // 
            this.rbTeaSex0.AutoSize = true;
            this.rbTeaSex0.Location = new System.Drawing.Point(186, 130);
            this.rbTeaSex0.Name = "rbTeaSex0";
            this.rbTeaSex0.Size = new System.Drawing.Size(35, 16);
            this.rbTeaSex0.TabIndex = 18;
            this.rbTeaSex0.TabStop = true;
            this.rbTeaSex0.Text = "女";
            this.rbTeaSex0.UseVisualStyleBackColor = true;
            // 
            // rbTeaSex1
            // 
            this.rbTeaSex1.AutoSize = true;
            this.rbTeaSex1.Location = new System.Drawing.Point(121, 130);
            this.rbTeaSex1.Name = "rbTeaSex1";
            this.rbTeaSex1.Size = new System.Drawing.Size(35, 16);
            this.rbTeaSex1.TabIndex = 19;
            this.rbTeaSex1.TabStop = true;
            this.rbTeaSex1.Text = "男";
            this.rbTeaSex1.UseVisualStyleBackColor = true;
            // 
            // tbTeaTitle
            // 
            this.tbTeaTitle.Location = new System.Drawing.Point(109, 162);
            this.tbTeaTitle.Name = "tbTeaTitle";
            this.tbTeaTitle.Size = new System.Drawing.Size(130, 21);
            this.tbTeaTitle.TabIndex = 3;
            // 
            // tbTeaName
            // 
            this.tbTeaName.Location = new System.Drawing.Point(109, 90);
            this.tbTeaName.Name = "tbTeaName";
            this.tbTeaName.Size = new System.Drawing.Size(130, 21);
            this.tbTeaName.TabIndex = 2;
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(109, 49);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(130, 21);
            this.tbID.TabIndex = 1;
            // 
            // labTeaSex
            // 
            this.labTeaSex.AutoSize = true;
            this.labTeaSex.Location = new System.Drawing.Point(50, 132);
            this.labTeaSex.Name = "labTeaSex";
            this.labTeaSex.Size = new System.Drawing.Size(53, 12);
            this.labTeaSex.TabIndex = 0;
            this.labTeaSex.Text = "性  别：";
            // 
            // labTeaTitle
            // 
            this.labTeaTitle.AutoSize = true;
            this.labTeaTitle.Location = new System.Drawing.Point(50, 165);
            this.labTeaTitle.Name = "labTeaTitle";
            this.labTeaTitle.Size = new System.Drawing.Size(53, 12);
            this.labTeaTitle.TabIndex = 0;
            this.labTeaTitle.Text = "职  称：";
            // 
            // labTeaName
            // 
            this.labTeaName.AutoSize = true;
            this.labTeaName.Location = new System.Drawing.Point(50, 93);
            this.labTeaName.Name = "labTeaName";
            this.labTeaName.Size = new System.Drawing.Size(53, 12);
            this.labTeaName.TabIndex = 0;
            this.labTeaName.Text = "姓  名：";
            // 
            // labID
            // 
            this.labID.AutoSize = true;
            this.labID.Location = new System.Drawing.Point(50, 52);
            this.labID.Name = "labID";
            this.labID.Size = new System.Drawing.Size(53, 12);
            this.labID.TabIndex = 0;
            this.labID.Text = "教工号：";
            // 
            // btCancel
            // 
            this.btCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(190, 294);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 7;
            this.btCancel.Text = "取消";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btConfirm
            // 
            this.btConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btConfirm.Location = new System.Drawing.Point(52, 294);
            this.btConfirm.Name = "btConfirm";
            this.btConfirm.Size = new System.Drawing.Size(75, 23);
            this.btConfirm.TabIndex = 6;
            this.btConfirm.Text = "确认";
            this.btConfirm.UseVisualStyleBackColor = true;
            this.btConfirm.Click += new System.EventHandler(this.btConfirm_Click);
            // 
            // tbConfirmPasswd
            // 
            this.tbConfirmPasswd.Location = new System.Drawing.Point(109, 242);
            this.tbConfirmPasswd.Name = "tbConfirmPasswd";
            this.tbConfirmPasswd.PasswordChar = '*';
            this.tbConfirmPasswd.Size = new System.Drawing.Size(130, 21);
            this.tbConfirmPasswd.TabIndex = 5;
            // 
            // tbPasswd
            // 
            this.tbPasswd.Location = new System.Drawing.Point(109, 201);
            this.tbPasswd.Name = "tbPasswd";
            this.tbPasswd.PasswordChar = '*';
            this.tbPasswd.Size = new System.Drawing.Size(130, 21);
            this.tbPasswd.TabIndex = 4;
            // 
            // labConfirmPasswd
            // 
            this.labConfirmPasswd.AutoSize = true;
            this.labConfirmPasswd.Location = new System.Drawing.Point(38, 245);
            this.labConfirmPasswd.Name = "labConfirmPasswd";
            this.labConfirmPasswd.Size = new System.Drawing.Size(65, 12);
            this.labConfirmPasswd.TabIndex = 20;
            this.labConfirmPasswd.Text = "确认密码：";
            // 
            // labPasswd
            // 
            this.labPasswd.AutoSize = true;
            this.labPasswd.Location = new System.Drawing.Point(50, 204);
            this.labPasswd.Name = "labPasswd";
            this.labPasswd.Size = new System.Drawing.Size(53, 12);
            this.labPasswd.TabIndex = 21;
            this.labPasswd.Text = "密  码：";
            // 
            // AddTeacher
            // 
            this.AcceptButton = this.btConfirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btCancel;
            this.ClientSize = new System.Drawing.Size(311, 360);
            this.Controls.Add(this.tbConfirmPasswd);
            this.Controls.Add(this.tbPasswd);
            this.Controls.Add(this.labConfirmPasswd);
            this.Controls.Add(this.labPasswd);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btConfirm);
            this.Controls.Add(this.rbTeaSex0);
            this.Controls.Add(this.rbTeaSex1);
            this.Controls.Add(this.tbTeaTitle);
            this.Controls.Add(this.tbTeaName);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.labTeaSex);
            this.Controls.Add(this.labTeaTitle);
            this.Controls.Add(this.labTeaName);
            this.Controls.Add(this.labID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AddTeacher";
            this.Text = "AddTeacher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbTeaSex0;
        private System.Windows.Forms.RadioButton rbTeaSex1;
        private System.Windows.Forms.TextBox tbTeaTitle;
        private System.Windows.Forms.TextBox tbTeaName;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label labTeaSex;
        private System.Windows.Forms.Label labTeaTitle;
        private System.Windows.Forms.Label labTeaName;
        private System.Windows.Forms.Label labID;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btConfirm;
        private System.Windows.Forms.TextBox tbConfirmPasswd;
        private System.Windows.Forms.TextBox tbPasswd;
        private System.Windows.Forms.Label labConfirmPasswd;
        private System.Windows.Forms.Label labPasswd;
    }
}