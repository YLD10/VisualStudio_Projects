namespace Form_SC
{
    partial class AddSelCou
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
            this.labStuName = new System.Windows.Forms.Label();
            this.btConfirm = new System.Windows.Forms.Button();
            this.dgvTC = new System.Windows.Forms.DataGridView();
            this.btCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTC)).BeginInit();
            this.SuspendLayout();
            // 
            // labStuName
            // 
            this.labStuName.AutoSize = true;
            this.labStuName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labStuName.Location = new System.Drawing.Point(12, 11);
            this.labStuName.Name = "labStuName";
            this.labStuName.Size = new System.Drawing.Size(118, 21);
            this.labStuName.TabIndex = 3;
            this.labStuName.Text = "学生姓名>选课";
            // 
            // btConfirm
            // 
            this.btConfirm.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btConfirm.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btConfirm.Location = new System.Drawing.Point(190, 386);
            this.btConfirm.Name = "btConfirm";
            this.btConfirm.Size = new System.Drawing.Size(91, 23);
            this.btConfirm.TabIndex = 0;
            this.btConfirm.Text = "确认";
            this.btConfirm.UseVisualStyleBackColor = true;
            this.btConfirm.Click += new System.EventHandler(this.btConfirm_Click);
            // 
            // dgvTC
            // 
            this.dgvTC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvTC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTC.Location = new System.Drawing.Point(12, 35);
            this.dgvTC.Name = "dgvTC";
            this.dgvTC.RowTemplate.Height = 23;
            this.dgvTC.Size = new System.Drawing.Size(703, 326);
            this.dgvTC.TabIndex = 2;
            this.dgvTC.TabStop = false;
            this.dgvTC.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTC_CellClick);
            // 
            // btCancel
            // 
            this.btCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btCancel.Location = new System.Drawing.Point(443, 386);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(91, 23);
            this.btCancel.TabIndex = 1;
            this.btCancel.Text = "取消";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // AddSelCou
            // 
            this.AcceptButton = this.btConfirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btCancel;
            this.ClientSize = new System.Drawing.Size(727, 434);
            this.Controls.Add(this.labStuName);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btConfirm);
            this.Controls.Add(this.dgvTC);
            this.Name = "AddSelCou";
            this.Text = "AddSelCou";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddSelCou_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labStuName;
        private System.Windows.Forms.Button btConfirm;
        private System.Windows.Forms.DataGridView dgvTC;
        private System.Windows.Forms.Button btCancel;
    }
}