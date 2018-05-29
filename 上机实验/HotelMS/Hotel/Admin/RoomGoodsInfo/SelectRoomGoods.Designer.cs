namespace Maticsoft.Hotel
{
    partial class SelectRoomGoods
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
            this.btDelete = new System.Windows.Forms.Button();
            this.btAlter = new System.Windows.Forms.Button();
            this.labSelect = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(98, 220);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 7;
            this.btCancel.Text = "取消";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(98, 151);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(75, 23);
            this.btDelete.TabIndex = 6;
            this.btDelete.Text = "删除";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btAlter
            // 
            this.btAlter.Location = new System.Drawing.Point(98, 91);
            this.btAlter.Name = "btAlter";
            this.btAlter.Size = new System.Drawing.Size(75, 23);
            this.btAlter.TabIndex = 5;
            this.btAlter.Text = "修改";
            this.btAlter.UseVisualStyleBackColor = true;
            this.btAlter.Click += new System.EventHandler(this.btAlter_Click);
            // 
            // labSelect
            // 
            this.labSelect.AutoSize = true;
            this.labSelect.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labSelect.Location = new System.Drawing.Point(73, 20);
            this.labSelect.Name = "labSelect";
            this.labSelect.Size = new System.Drawing.Size(138, 22);
            this.labSelect.TabIndex = 4;
            this.labSelect.Text = "请问您的选择是？";
            // 
            // SelectRoomGoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btAlter);
            this.Controls.Add(this.labSelect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SelectRoomGoods";
            this.Text = "SelectRoomGoods";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btAlter;
        private System.Windows.Forms.Label labSelect;
    }
}