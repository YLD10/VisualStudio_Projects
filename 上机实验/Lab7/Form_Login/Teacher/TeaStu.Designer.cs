namespace Form_SC
{
    partial class TeaStu
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
            this.btUpdateScore = new System.Windows.Forms.Button();
            this.dgvTS = new System.Windows.Forms.DataGridView();
            this.labCouName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTS)).BeginInit();
            this.SuspendLayout();
            // 
            // btUpdateScore
            // 
            this.btUpdateScore.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btUpdateScore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btUpdateScore.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btUpdateScore.Location = new System.Drawing.Point(309, 40);
            this.btUpdateScore.Name = "btUpdateScore";
            this.btUpdateScore.Size = new System.Drawing.Size(91, 23);
            this.btUpdateScore.TabIndex = 0;
            this.btUpdateScore.Text = "修改学生成绩";
            this.btUpdateScore.UseVisualStyleBackColor = true;
            this.btUpdateScore.Click += new System.EventHandler(this.btUpdateScore_Click);
            // 
            // dgvTS
            // 
            this.dgvTS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvTS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTS.Location = new System.Drawing.Point(12, 96);
            this.dgvTS.Name = "dgvTS";
            this.dgvTS.RowTemplate.Height = 23;
            this.dgvTS.Size = new System.Drawing.Size(703, 326);
            this.dgvTS.TabIndex = 1;
            this.dgvTS.TabStop = false;
            this.dgvTS.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTS_CellClick);
            // 
            // labCouName
            // 
            this.labCouName.AutoSize = true;
            this.labCouName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labCouName.Location = new System.Drawing.Point(12, 72);
            this.labCouName.Name = "labCouName";
            this.labCouName.Size = new System.Drawing.Size(134, 21);
            this.labCouName.TabIndex = 2;
            this.labCouName.Text = "教师姓名>课程名";
            // 
            // TeaStu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 434);
            this.Controls.Add(this.labCouName);
            this.Controls.Add(this.btUpdateScore);
            this.Controls.Add(this.dgvTS);
            this.Name = "TeaStu";
            this.Text = "TeaStu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TeaStu_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btUpdateScore;
        private System.Windows.Forms.DataGridView dgvTS;
        private System.Windows.Forms.Label labCouName;
    }
}