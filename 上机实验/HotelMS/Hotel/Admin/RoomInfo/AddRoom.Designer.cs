namespace Maticsoft.Hotel
{
    partial class AddRoom
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
            this.labFloorNum = new System.Windows.Forms.Label();
            this.nudFloorNum = new System.Windows.Forms.NumericUpDown();
            this.labRoomID = new System.Windows.Forms.Label();
            this.nudRoomID = new System.Windows.Forms.NumericUpDown();
            this.labRoomType = new System.Windows.Forms.Label();
            this.combRoomType = new System.Windows.Forms.ComboBox();
            this.btConfirm = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudFloorNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRoomID)).BeginInit();
            this.SuspendLayout();
            // 
            // labFloorNum
            // 
            this.labFloorNum.AutoSize = true;
            this.labFloorNum.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labFloorNum.Location = new System.Drawing.Point(58, 56);
            this.labFloorNum.Name = "labFloorNum";
            this.labFloorNum.Size = new System.Drawing.Size(72, 16);
            this.labFloorNum.TabIndex = 0;
            this.labFloorNum.Text = "楼层号：";
            // 
            // nudFloorNum
            // 
            this.nudFloorNum.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nudFloorNum.Location = new System.Drawing.Point(136, 54);
            this.nudFloorNum.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudFloorNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudFloorNum.Name = "nudFloorNum";
            this.nudFloorNum.Size = new System.Drawing.Size(120, 26);
            this.nudFloorNum.TabIndex = 0;
            this.nudFloorNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labRoomID
            // 
            this.labRoomID.AutoSize = true;
            this.labRoomID.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labRoomID.Location = new System.Drawing.Point(58, 118);
            this.labRoomID.Name = "labRoomID";
            this.labRoomID.Size = new System.Drawing.Size(72, 16);
            this.labRoomID.TabIndex = 0;
            this.labRoomID.Text = "房间号：";
            // 
            // nudRoomID
            // 
            this.nudRoomID.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nudRoomID.Location = new System.Drawing.Point(136, 116);
            this.nudRoomID.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nudRoomID.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudRoomID.Name = "nudRoomID";
            this.nudRoomID.Size = new System.Drawing.Size(120, 26);
            this.nudRoomID.TabIndex = 1;
            this.nudRoomID.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labRoomType
            // 
            this.labRoomType.AutoSize = true;
            this.labRoomType.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labRoomType.Location = new System.Drawing.Point(42, 176);
            this.labRoomType.Name = "labRoomType";
            this.labRoomType.Size = new System.Drawing.Size(88, 16);
            this.labRoomType.TabIndex = 2;
            this.labRoomType.Text = "房间类型：";
            // 
            // combRoomType
            // 
            this.combRoomType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combRoomType.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.combRoomType.FormattingEnabled = true;
            this.combRoomType.Location = new System.Drawing.Point(136, 173);
            this.combRoomType.Name = "combRoomType";
            this.combRoomType.Size = new System.Drawing.Size(120, 27);
            this.combRoomType.TabIndex = 3;
            this.combRoomType.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.CombRoomType);
            // 
            // btConfirm
            // 
            this.btConfirm.Location = new System.Drawing.Point(55, 235);
            this.btConfirm.Name = "btConfirm";
            this.btConfirm.Size = new System.Drawing.Size(75, 23);
            this.btConfirm.TabIndex = 4;
            this.btConfirm.Text = "确认";
            this.btConfirm.UseVisualStyleBackColor = true;
            this.btConfirm.Click += new System.EventHandler(this.btConfirm_Click);
            // 
            // btCancel
            // 
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(181, 235);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 4;
            this.btCancel.Text = "取消";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // AddRoom
            // 
            this.AcceptButton = this.btConfirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btCancel;
            this.ClientSize = new System.Drawing.Size(325, 299);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btConfirm);
            this.Controls.Add(this.combRoomType);
            this.Controls.Add(this.labRoomType);
            this.Controls.Add(this.nudRoomID);
            this.Controls.Add(this.labRoomID);
            this.Controls.Add(this.nudFloorNum);
            this.Controls.Add(this.labFloorNum);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AddRoom";
            this.Text = "AddRoom";
            this.Load += new System.EventHandler(this.AddRoom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudFloorNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRoomID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labFloorNum;
        private System.Windows.Forms.NumericUpDown nudFloorNum;
        private System.Windows.Forms.Label labRoomID;
        private System.Windows.Forms.NumericUpDown nudRoomID;
        private System.Windows.Forms.Label labRoomType;
        private System.Windows.Forms.ComboBox combRoomType;
        private System.Windows.Forms.Button btConfirm;
        private System.Windows.Forms.Button btCancel;
    }
}