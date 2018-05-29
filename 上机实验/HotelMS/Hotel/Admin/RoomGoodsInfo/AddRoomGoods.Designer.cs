namespace Maticsoft.Hotel
{
    partial class AddRoomGoods
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
            this.labID = new System.Windows.Forms.Label();
            this.labName = new System.Windows.Forms.Label();
            this.labPrice = new System.Windows.Forms.Label();
            this.labRoomType = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbRoomType = new System.Windows.Forms.TextBox();
            this.btConfirm = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labID
            // 
            this.labID.AutoSize = true;
            this.labID.Location = new System.Drawing.Point(46, 37);
            this.labID.Name = "labID";
            this.labID.Size = new System.Drawing.Size(41, 12);
            this.labID.TabIndex = 0;
            this.labID.Text = "编号：";
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Location = new System.Drawing.Point(46, 87);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(41, 12);
            this.labName.TabIndex = 1;
            this.labName.Text = "名称：";
            // 
            // labPrice
            // 
            this.labPrice.AutoSize = true;
            this.labPrice.Location = new System.Drawing.Point(46, 135);
            this.labPrice.Name = "labPrice";
            this.labPrice.Size = new System.Drawing.Size(41, 12);
            this.labPrice.TabIndex = 2;
            this.labPrice.Text = "价格：";
            // 
            // labRoomType
            // 
            this.labRoomType.AutoSize = true;
            this.labRoomType.Location = new System.Drawing.Point(46, 179);
            this.labRoomType.Name = "labRoomType";
            this.labRoomType.Size = new System.Drawing.Size(41, 12);
            this.labRoomType.TabIndex = 3;
            this.labRoomType.Text = "房型：";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(128, 34);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(100, 21);
            this.tbID.TabIndex = 4;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(128, 84);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 21);
            this.tbName.TabIndex = 5;
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(128, 132);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(100, 21);
            this.tbPrice.TabIndex = 6;
            // 
            // tbRoomType
            // 
            this.tbRoomType.Location = new System.Drawing.Point(128, 176);
            this.tbRoomType.Name = "tbRoomType";
            this.tbRoomType.Size = new System.Drawing.Size(100, 21);
            this.tbRoomType.TabIndex = 7;
            this.tbRoomType.TextChanged += new System.EventHandler(this.tbRoomType_TextChanged);
            // 
            // btConfirm
            // 
            this.btConfirm.Location = new System.Drawing.Point(44, 228);
            this.btConfirm.Name = "btConfirm";
            this.btConfirm.Size = new System.Drawing.Size(75, 23);
            this.btConfirm.TabIndex = 8;
            this.btConfirm.Text = "确定";
            this.btConfirm.UseVisualStyleBackColor = true;
            this.btConfirm.Click += new System.EventHandler(this.btConfirm_Click);
            // 
            // btCancel
            // 
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(181, 228);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 9;
            this.btCancel.Text = "取消";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // AddRoomGoods
            // 
            this.AcceptButton = this.btConfirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btCancel;
            this.ClientSize = new System.Drawing.Size(270, 301);
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
            this.Name = "AddRoomGoods";
            this.Text = "AddRoomGoods";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labID;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label labPrice;
        private System.Windows.Forms.Label labRoomType;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbRoomType;
        private System.Windows.Forms.Button btConfirm;
        private System.Windows.Forms.Button btCancel;
    }
}