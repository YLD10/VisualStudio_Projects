namespace Form_SC
{
    partial class StuCou
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
            this.btDeleteSelCou = new System.Windows.Forms.Button();
            this.btAddSelCou = new System.Windows.Forms.Button();
            this.dgvSC = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSC)).BeginInit();
            this.SuspendLayout();
            // 
            // labStuName
            // 
            this.labStuName.AutoSize = true;
            this.labStuName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labStuName.Location = new System.Drawing.Point(12, 72);
            this.labStuName.Name = "labStuName";
            this.labStuName.Size = new System.Drawing.Size(74, 21);
            this.labStuName.TabIndex = 7;
            this.labStuName.Text = "学生姓名";
            // 
            // btDeleteSelCou
            // 
            this.btDeleteSelCou.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btDeleteSelCou.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btDeleteSelCou.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btDeleteSelCou.Location = new System.Drawing.Point(428, 42);
            this.btDeleteSelCou.Name = "btDeleteSelCou";
            this.btDeleteSelCou.Size = new System.Drawing.Size(89, 23);
            this.btDeleteSelCou.TabIndex = 1;
            this.btDeleteSelCou.Text = "删除选课记录";
            this.btDeleteSelCou.UseVisualStyleBackColor = true;
            this.btDeleteSelCou.Click += new System.EventHandler(this.btDeleteSelCou_Click);
            // 
            // btAddSelCou
            // 
            this.btAddSelCou.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btAddSelCou.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAddSelCou.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btAddSelCou.Location = new System.Drawing.Point(174, 42);
            this.btAddSelCou.Name = "btAddSelCou";
            this.btAddSelCou.Size = new System.Drawing.Size(91, 23);
            this.btAddSelCou.TabIndex = 0;
            this.btAddSelCou.Text = "添加选课记录";
            this.btAddSelCou.UseVisualStyleBackColor = true;
            this.btAddSelCou.Click += new System.EventHandler(this.btAddSelCou_Click);
            // 
            // dgvSC
            // 
            this.dgvSC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvSC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSC.Location = new System.Drawing.Point(12, 96);
            this.dgvSC.Name = "dgvSC";
            this.dgvSC.RowTemplate.Height = 23;
            this.dgvSC.Size = new System.Drawing.Size(703, 326);
            this.dgvSC.TabIndex = 2;
            this.dgvSC.TabStop = false;
            this.dgvSC.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSC_CellClick);
            // 
            // StuCou
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 434);
            this.Controls.Add(this.labStuName);
            this.Controls.Add(this.btDeleteSelCou);
            this.Controls.Add(this.btAddSelCou);
            this.Controls.Add(this.dgvSC);
            this.Name = "StuCou";
            this.Text = "StuCou";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StuCou_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labStuName;
        private System.Windows.Forms.Button btDeleteSelCou;
        private System.Windows.Forms.Button btAddSelCou;
        private System.Windows.Forms.DataGridView dgvSC;

    }
}