namespace Maticsoft.Hotel
{
    partial class DeleteStaff
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
            this.tbStaffID = new System.Windows.Forms.TextBox();
            this.btConfirm = new System.Windows.Forms.Button();
            this.btcancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labStaffID
            // 
            this.labStaffID.AutoSize = true;
            this.labStaffID.Location = new System.Drawing.Point(53, 50);
            this.labStaffID.Name = "labStaffID";
            this.labStaffID.Size = new System.Drawing.Size(65, 12);
            this.labStaffID.TabIndex = 0;
            this.labStaffID.Text = "员工工号：";
            // 
            // tbStaffID
            // 
            this.tbStaffID.Location = new System.Drawing.Point(134, 47);
            this.tbStaffID.Name = "tbStaffID";
            this.tbStaffID.Size = new System.Drawing.Size(100, 21);
            this.tbStaffID.TabIndex = 1;
            // 
            // btConfirm
            // 
            this.btConfirm.Location = new System.Drawing.Point(38, 175);
            this.btConfirm.Name = "btConfirm";
            this.btConfirm.Size = new System.Drawing.Size(75, 23);
            this.btConfirm.TabIndex = 2;
            this.btConfirm.Text = "确定";
            this.btConfirm.UseVisualStyleBackColor = true;
            this.btConfirm.Click += new System.EventHandler(this.btConfirm_Click);
            // 
            // btcancel
            // 
            this.btcancel.Location = new System.Drawing.Point(174, 175);
            this.btcancel.Name = "btcancel";
            this.btcancel.Size = new System.Drawing.Size(75, 23);
            this.btcancel.TabIndex = 3;
            this.btcancel.Text = "取消";
            this.btcancel.UseVisualStyleBackColor = true;
            this.btcancel.Click += new System.EventHandler(this.btcancel_Click);
            // 
            // DeleteStaff
            // 
            this.AcceptButton = this.btConfirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btcancel;
            this.ClientSize = new System.Drawing.Size(290, 242);
            this.Controls.Add(this.btcancel);
            this.Controls.Add(this.btConfirm);
            this.Controls.Add(this.tbStaffID);
            this.Controls.Add(this.labStaffID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "DeleteStaff";
            this.Text = "DeleteStaff";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labStaffID;
        private System.Windows.Forms.Button btConfirm;
        private System.Windows.Forms.Button btcancel;
        public System.Windows.Forms.TextBox tbStaffID;
    }
}