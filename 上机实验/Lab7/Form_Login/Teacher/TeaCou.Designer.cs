namespace Form_SC
{
    partial class TeaCou
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
            this.btSeeAllStudents = new System.Windows.Forms.Button();
            this.dgvTC = new System.Windows.Forms.DataGridView();
            this.labTeaName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTC)).BeginInit();
            this.SuspendLayout();
            // 
            // btSeeAllStudents
            // 
            this.btSeeAllStudents.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btSeeAllStudents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSeeAllStudents.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btSeeAllStudents.Location = new System.Drawing.Point(309, 40);
            this.btSeeAllStudents.Name = "btSeeAllStudents";
            this.btSeeAllStudents.Size = new System.Drawing.Size(91, 23);
            this.btSeeAllStudents.TabIndex = 0;
            this.btSeeAllStudents.Text = "查看班里学生";
            this.btSeeAllStudents.UseVisualStyleBackColor = true;
            this.btSeeAllStudents.Click += new System.EventHandler(this.btSeeAllStudents_Click);
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
            this.dgvTC.TabIndex = 1;
            this.dgvTC.TabStop = false;
            this.dgvTC.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTC_CellClick);
            // 
            // labTeaName
            // 
            this.labTeaName.AutoSize = true;
            this.labTeaName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labTeaName.Location = new System.Drawing.Point(12, 72);
            this.labTeaName.Name = "labTeaName";
            this.labTeaName.Size = new System.Drawing.Size(74, 21);
            this.labTeaName.TabIndex = 2;
            this.labTeaName.Text = "教师姓名";
            // 
            // TeaCou
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 434);
            this.Controls.Add(this.labTeaName);
            this.Controls.Add(this.btSeeAllStudents);
            this.Controls.Add(this.dgvTC);
            this.Name = "TeaCou";
            this.Text = "TeaCou";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TeaCou_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSeeAllStudents;
        private System.Windows.Forms.DataGridView dgvTC;
        private System.Windows.Forms.Label labTeaName;
    }
}