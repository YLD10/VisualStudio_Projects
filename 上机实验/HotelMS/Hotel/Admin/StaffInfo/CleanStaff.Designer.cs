namespace Maticsoft.Hotel
{
    partial class CleanStaff
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
            this.dgvClean = new System.Windows.Forms.DataGridView();
            this.btConfirm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClean)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClean
            // 
            this.dgvClean.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvClean.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClean.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClean.Location = new System.Drawing.Point(12, 45);
            this.dgvClean.Name = "dgvClean";
            this.dgvClean.ReadOnly = true;
            this.dgvClean.RowTemplate.Height = 23;
            this.dgvClean.Size = new System.Drawing.Size(652, 260);
            this.dgvClean.TabIndex = 0;
            // 
            // btConfirm
            // 
            this.btConfirm.Location = new System.Drawing.Point(286, 330);
            this.btConfirm.Name = "btConfirm";
            this.btConfirm.Size = new System.Drawing.Size(75, 23);
            this.btConfirm.TabIndex = 1;
            this.btConfirm.Text = "查看";
            this.btConfirm.UseVisualStyleBackColor = true;
            this.btConfirm.Click += new System.EventHandler(this.btConfirm_Click);
            // 
            // CleanStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 378);
            this.Controls.Add(this.btConfirm);
            this.Controls.Add(this.dgvClean);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "CleanStaff";
            this.Text = "CleanStaff";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClean)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClean;
        private System.Windows.Forms.Button btConfirm;
    }
}