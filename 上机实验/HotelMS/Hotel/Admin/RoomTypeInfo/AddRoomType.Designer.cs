namespace Maticsoft.Hotel
{
    partial class AddRoomType
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
            this.labRoomType = new System.Windows.Forms.Label();
            this.tbRoomType = new System.Windows.Forms.TextBox();
            this.labPrice = new System.Windows.Forms.Label();
            this.nudPrice = new System.Windows.Forms.NumericUpDown();
            this.btConfirm = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // labRoomType
            // 
            this.labRoomType.AutoSize = true;
            this.labRoomType.Location = new System.Drawing.Point(56, 62);
            this.labRoomType.Name = "labRoomType";
            this.labRoomType.Size = new System.Drawing.Size(65, 12);
            this.labRoomType.TabIndex = 100;
            this.labRoomType.Text = "房间类型：";
            // 
            // tbRoomType
            // 
            this.tbRoomType.Location = new System.Drawing.Point(119, 59);
            this.tbRoomType.Name = "tbRoomType";
            this.tbRoomType.Size = new System.Drawing.Size(100, 21);
            this.tbRoomType.TabIndex = 0;
            // 
            // labPrice
            // 
            this.labPrice.AutoSize = true;
            this.labPrice.Location = new System.Drawing.Point(57, 121);
            this.labPrice.Name = "labPrice";
            this.labPrice.Size = new System.Drawing.Size(59, 12);
            this.labPrice.TabIndex = 100;
            this.labPrice.Text = "价   格：";
            // 
            // nudPrice
            // 
            this.nudPrice.Location = new System.Drawing.Point(122, 119);
            this.nudPrice.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudPrice.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPrice.Name = "nudPrice";
            this.nudPrice.Size = new System.Drawing.Size(97, 21);
            this.nudPrice.TabIndex = 1;
            this.nudPrice.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btConfirm
            // 
            this.btConfirm.Location = new System.Drawing.Point(46, 196);
            this.btConfirm.Name = "btConfirm";
            this.btConfirm.Size = new System.Drawing.Size(75, 23);
            this.btConfirm.TabIndex = 2;
            this.btConfirm.Text = "确定";
            this.btConfirm.UseVisualStyleBackColor = true;
            this.btConfirm.Click += new System.EventHandler(this.btConfirm_Click);
            // 
            // btCancel
            // 
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(164, 196);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 3;
            this.btCancel.Text = "取消";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // AddRoomType
            // 
            this.AcceptButton = this.btConfirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btCancel;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btConfirm);
            this.Controls.Add(this.nudPrice);
            this.Controls.Add(this.labPrice);
            this.Controls.Add(this.tbRoomType);
            this.Controls.Add(this.labRoomType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddRoomType";
            this.Text = "AddRoomType";
            this.Load += new System.EventHandler(this.AddRoomType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labRoomType;
        private System.Windows.Forms.TextBox tbRoomType;
        private System.Windows.Forms.Label labPrice;
        private System.Windows.Forms.NumericUpDown nudPrice;
        private System.Windows.Forms.Button btConfirm;
        private System.Windows.Forms.Button btCancel;
    }
}