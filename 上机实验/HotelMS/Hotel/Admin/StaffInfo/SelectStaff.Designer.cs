namespace Maticsoft.Hotel
{
    partial class SelectStaff
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
            this.labSelect = new System.Windows.Forms.Label();
            this.btAlter = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labSelect
            // 
            this.labSelect.AutoSize = true;
            this.labSelect.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labSelect.Location = new System.Drawing.Point(72, 35);
            this.labSelect.Name = "labSelect";
            this.labSelect.Size = new System.Drawing.Size(138, 22);
            this.labSelect.TabIndex = 0;
            this.labSelect.Text = "请问您的选择是？";
            // 
            // btAlter
            // 
            this.btAlter.Location = new System.Drawing.Point(97, 106);
            this.btAlter.Name = "btAlter";
            this.btAlter.Size = new System.Drawing.Size(75, 23);
            this.btAlter.TabIndex = 1;
            this.btAlter.Text = "修改";
            this.btAlter.UseVisualStyleBackColor = true;
            this.btAlter.Click += new System.EventHandler(this.btAlter_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(97, 166);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(75, 23);
            this.btDelete.TabIndex = 2;
            this.btDelete.Text = "删除";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(97, 235);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 3;
            this.btCancel.Text = "取消";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // SelectStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 304);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btAlter);
            this.Controls.Add(this.labSelect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SelectStaff";
            this.Text = "SelectStaff";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labSelect;
        private System.Windows.Forms.Button btAlter;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btCancel;
    }
}