namespace Form_SC
{
    partial class CouTea
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
            this.dgvTC = new System.Windows.Forms.DataGridView();
            this.btDeleteTeacher = new System.Windows.Forms.Button();
            this.btAddTeacher = new System.Windows.Forms.Button();
            this.labCouName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTC)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTC
            // 
            this.dgvTC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvTC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTC.Location = new System.Drawing.Point(12, 96);
            this.dgvTC.Name = "dgvTC";
            this.dgvTC.RowTemplate.Height = 23;
            this.dgvTC.Size = new System.Drawing.Size(703, 326);
            this.dgvTC.TabIndex = 2;
            this.dgvTC.TabStop = false;
            this.dgvTC.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTC_CellClick);
            // 
            // btDeleteTeacher
            // 
            this.btDeleteTeacher.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btDeleteTeacher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btDeleteTeacher.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btDeleteTeacher.Location = new System.Drawing.Point(428, 42);
            this.btDeleteTeacher.Name = "btDeleteTeacher";
            this.btDeleteTeacher.Size = new System.Drawing.Size(89, 23);
            this.btDeleteTeacher.TabIndex = 1;
            this.btDeleteTeacher.Text = "删除任课老师";
            this.btDeleteTeacher.UseVisualStyleBackColor = true;
            this.btDeleteTeacher.Click += new System.EventHandler(this.btDeleteTeacher_Click);
            // 
            // btAddTeacher
            // 
            this.btAddTeacher.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btAddTeacher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAddTeacher.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btAddTeacher.Location = new System.Drawing.Point(174, 42);
            this.btAddTeacher.Name = "btAddTeacher";
            this.btAddTeacher.Size = new System.Drawing.Size(91, 23);
            this.btAddTeacher.TabIndex = 0;
            this.btAddTeacher.Text = "添加任课老师";
            this.btAddTeacher.UseVisualStyleBackColor = true;
            this.btAddTeacher.Click += new System.EventHandler(this.btAddTeacher_Click);
            // 
            // labCouName
            // 
            this.labCouName.AutoSize = true;
            this.labCouName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labCouName.Location = new System.Drawing.Point(12, 72);
            this.labCouName.Name = "labCouName";
            this.labCouName.Size = new System.Drawing.Size(58, 21);
            this.labCouName.TabIndex = 3;
            this.labCouName.Text = "课程名";
            // 
            // CouTea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 434);
            this.Controls.Add(this.labCouName);
            this.Controls.Add(this.btDeleteTeacher);
            this.Controls.Add(this.btAddTeacher);
            this.Controls.Add(this.dgvTC);
            this.Name = "CouTea";
            this.Text = "CouTea";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CouTea_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTC;
        private System.Windows.Forms.Button btDeleteTeacher;
        private System.Windows.Forms.Button btAddTeacher;
        private System.Windows.Forms.Label labCouName;
    }
}