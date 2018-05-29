namespace Maticsoft.Hotel
{
    partial class AlterRoomGoods
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
            this.btConfirm = new System.Windows.Forms.Button();
            this.tbRoomType = new System.Windows.Forms.TextBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.labRoomType = new System.Windows.Forms.Label();
            this.labPrice = new System.Windows.Forms.Label();
            this.labName = new System.Windows.Forms.Label();
            this.labID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btCancel
            // 
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(173, 217);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 19;
            this.btCancel.Text = "取消";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btConfirm
            // 
            this.btConfirm.Location = new System.Drawing.Point(36, 217);
            this.btConfirm.Name = "btConfirm";
            this.btConfirm.Size = new System.Drawing.Size(75, 23);
            this.btConfirm.TabIndex = 18;
            this.btConfirm.Text = "确定";
            this.btConfirm.UseVisualStyleBackColor = true;
            this.btConfirm.Click += new System.EventHandler(this.btConfirm_Click);
            // 
            // tbRoomType
            // 
            this.tbRoomType.Location = new System.Drawing.Point(120, 165);
            this.tbRoomType.Name = "tbRoomType";
            this.tbRoomType.Size = new System.Drawing.Size(100, 21);
            this.tbRoomType.TabIndex = 17;
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(120, 121);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(100, 21);
            this.tbPrice.TabIndex = 16;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(120, 73);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 21);
            this.tbName.TabIndex = 15;
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(120, 23);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(100, 21);
            this.tbID.TabIndex = 14;
            // 
            // labRoomType
            // 
            this.labRoomType.AutoSize = true;
            this.labRoomType.Location = new System.Drawing.Point(38, 168);
            this.labRoomType.Name = "labRoomType";
            this.labRoomType.Size = new System.Drawing.Size(41, 12);
            this.labRoomType.TabIndex = 13;
            this.labRoomType.Text = "房型：";
            // 
            // labPrice
            // 
            this.labPrice.AutoSize = true;
            this.labPrice.Location = new System.Drawing.Point(38, 124);
            this.labPrice.Name = "labPrice";
            this.labPrice.Size = new System.Drawing.Size(41, 12);
            this.labPrice.TabIndex = 12;
            this.labPrice.Text = "价格：";
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Location = new System.Drawing.Point(38, 76);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(41, 12);
            this.labName.TabIndex = 11;
            this.labName.Text = "名称：";
            // 
            // labID
            // 
            this.labID.AutoSize = true;
            this.labID.Location = new System.Drawing.Point(38, 26);
            this.labID.Name = "labID";
            this.labID.Size = new System.Drawing.Size(41, 12);
            this.labID.TabIndex = 10;
            this.labID.Text = "编号：";
            // 
            // AlterRoomGoods
            // 
            this.AcceptButton = this.btConfirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btCancel;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btConfirm);
            this.Controls.Add(this.tbRoomType);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.labRoomType);
            this.Controls.Add(this.labPrice);
            this.Controls.Add(this.labName);
            this.Controls.Add(this.labID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AlterRoomGoods";
            this.Text = "AlterRoomGoods";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btConfirm;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label labRoomType;
        private System.Windows.Forms.Label labPrice;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label labID;
        public System.Windows.Forms.TextBox tbRoomType;
        public System.Windows.Forms.TextBox tbID;
    }
}