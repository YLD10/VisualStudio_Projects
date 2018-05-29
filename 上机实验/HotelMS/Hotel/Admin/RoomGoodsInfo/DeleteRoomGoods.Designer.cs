namespace Maticsoft.Hotel
{
    partial class DeleteRoomGoods
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
            this.tbID = new System.Windows.Forms.TextBox();
            this.labRoomType = new System.Windows.Forms.Label();
            this.labID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btCancel
            // 
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(173, 173);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 19;
            this.btCancel.Text = "取消";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btConfirm
            // 
            this.btConfirm.Location = new System.Drawing.Point(40, 173);
            this.btConfirm.Name = "btConfirm";
            this.btConfirm.Size = new System.Drawing.Size(75, 23);
            this.btConfirm.TabIndex = 18;
            this.btConfirm.Text = "确定";
            this.btConfirm.UseVisualStyleBackColor = true;
            this.btConfirm.Click += new System.EventHandler(this.btConfirm_Click);
            // 
            // tbRoomType
            // 
            this.tbRoomType.Location = new System.Drawing.Point(120, 98);
            this.tbRoomType.Name = "tbRoomType";
            this.tbRoomType.Size = new System.Drawing.Size(100, 21);
            this.tbRoomType.TabIndex = 17;
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
            this.labRoomType.Location = new System.Drawing.Point(38, 101);
            this.labRoomType.Name = "labRoomType";
            this.labRoomType.Size = new System.Drawing.Size(41, 12);
            this.labRoomType.TabIndex = 13;
            this.labRoomType.Text = "房型：";
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
            // DeleteRoomGoods
            // 
            this.AcceptButton = this.btConfirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btCancel;
            this.ClientSize = new System.Drawing.Size(284, 231);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btConfirm);
            this.Controls.Add(this.tbRoomType);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.labRoomType);
            this.Controls.Add(this.labID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "DeleteRoomGoods";
            this.Text = "DeleteRoomGoods";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btConfirm;
        private System.Windows.Forms.Label labRoomType;
        private System.Windows.Forms.Label labID;
        public System.Windows.Forms.TextBox tbRoomType;
        public System.Windows.Forms.TextBox tbID;
    }
}