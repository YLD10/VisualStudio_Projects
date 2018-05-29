namespace Maticsoft.Hotel
{
    partial class SelectAdmin
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
            this.labAdminSelect = new System.Windows.Forms.Label();
            this.btAdminAlter = new System.Windows.Forms.Button();
            this.btAdminDel = new System.Windows.Forms.Button();
            this.btAdminCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labAdminSelect
            // 
            this.labAdminSelect.AutoSize = true;
            this.labAdminSelect.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labAdminSelect.Location = new System.Drawing.Point(50, 29);
            this.labAdminSelect.Name = "labAdminSelect";
            this.labAdminSelect.Size = new System.Drawing.Size(138, 22);
            this.labAdminSelect.TabIndex = 0;
            this.labAdminSelect.Text = "请输入您的选择？";
            // 
            // btAdminAlter
            // 
            this.btAdminAlter.Location = new System.Drawing.Point(79, 87);
            this.btAdminAlter.Name = "btAdminAlter";
            this.btAdminAlter.Size = new System.Drawing.Size(75, 23);
            this.btAdminAlter.TabIndex = 2;
            this.btAdminAlter.Text = "修改";
            this.btAdminAlter.UseVisualStyleBackColor = true;
            this.btAdminAlter.Click += new System.EventHandler(this.btAdminAlter_Click);
            // 
            // btAdminDel
            // 
            this.btAdminDel.Location = new System.Drawing.Point(79, 150);
            this.btAdminDel.Name = "btAdminDel";
            this.btAdminDel.Size = new System.Drawing.Size(75, 23);
            this.btAdminDel.TabIndex = 3;
            this.btAdminDel.Text = "删除";
            this.btAdminDel.UseVisualStyleBackColor = true;
            this.btAdminDel.Click += new System.EventHandler(this.btAdminDel_Click);
            // 
            // btAdminCancel
            // 
            this.btAdminCancel.Location = new System.Drawing.Point(79, 214);
            this.btAdminCancel.Name = "btAdminCancel";
            this.btAdminCancel.Size = new System.Drawing.Size(75, 23);
            this.btAdminCancel.TabIndex = 4;
            this.btAdminCancel.Text = "取消";
            this.btAdminCancel.UseVisualStyleBackColor = true;
            this.btAdminCancel.Click += new System.EventHandler(this.btAdminCancel_Click);
            // 
            // SelectAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btAdminCancel);
            this.Controls.Add(this.btAdminDel);
            this.Controls.Add(this.btAdminAlter);
            this.Controls.Add(this.labAdminSelect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SelectAdmin";
            this.Text = "SelectAdmin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labAdminSelect;
        private System.Windows.Forms.Button btAdminAlter;
        private System.Windows.Forms.Button btAdminDel;
        private System.Windows.Forms.Button btAdminCancel;
    }
}