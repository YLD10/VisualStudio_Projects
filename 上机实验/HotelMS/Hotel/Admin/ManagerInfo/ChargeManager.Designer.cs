namespace Maticsoft.Hotel
{
    partial class ChargeManager
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
            this.btConfirm = new System.Windows.Forms.Button();
            this.dgvCharge = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCharge)).BeginInit();
            this.SuspendLayout();
            // 
            // btConfirm
            // 
            this.btConfirm.Location = new System.Drawing.Point(278, 311);
            this.btConfirm.Name = "btConfirm";
            this.btConfirm.Size = new System.Drawing.Size(75, 23);
            this.btConfirm.TabIndex = 0;
            this.btConfirm.Text = "查看";
            this.btConfirm.UseVisualStyleBackColor = true;
            this.btConfirm.Click += new System.EventHandler(this.btConfirm_Click);
            // 
            // dgvCharge
            // 
            this.dgvCharge.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCharge.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCharge.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCharge.Location = new System.Drawing.Point(39, 36);
            this.dgvCharge.Name = "dgvCharge";
            this.dgvCharge.ReadOnly = true;
            this.dgvCharge.RowTemplate.Height = 23;
            this.dgvCharge.Size = new System.Drawing.Size(552, 232);
            this.dgvCharge.TabIndex = 1;
            // 
            // ChargeManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 369);
            this.Controls.Add(this.dgvCharge);
            this.Controls.Add(this.btConfirm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ChargeManager";
            this.Text = "ChargeManager";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCharge)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btConfirm;
        private System.Windows.Forms.DataGridView dgvCharge;
    }
}