namespace Lab6
{
    partial class Form_Lab6_AboutBox_Us
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Lab6_AboutBox_Us));
            this.pbAbout = new System.Windows.Forms.PictureBox();
            this.btConfirmAbout = new System.Windows.Forms.Button();
            this.labTitleAbout = new System.Windows.Forms.Label();
            this.labVersionAbout = new System.Windows.Forms.Label();
            this.labOwnerAbout = new System.Windows.Forms.Label();
            this.labSupportAbout = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbAbout)).BeginInit();
            this.SuspendLayout();
            // 
            // pbAbout
            // 
            this.pbAbout.Image = global::Lab6.Properties.Resources.aboutJPG;
            this.pbAbout.Location = new System.Drawing.Point(80, 78);
            this.pbAbout.Name = "pbAbout";
            this.pbAbout.Size = new System.Drawing.Size(100, 120);
            this.pbAbout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAbout.TabIndex = 0;
            this.pbAbout.TabStop = false;
            // 
            // btConfirmAbout
            // 
            this.btConfirmAbout.Location = new System.Drawing.Point(231, 216);
            this.btConfirmAbout.Name = "btConfirmAbout";
            this.btConfirmAbout.Size = new System.Drawing.Size(75, 23);
            this.btConfirmAbout.TabIndex = 1;
            this.btConfirmAbout.Text = "确认(&Y)";
            this.btConfirmAbout.UseVisualStyleBackColor = true;
            this.btConfirmAbout.Click += new System.EventHandler(this.btConfirmAbout_Click);
            // 
            // labTitleAbout
            // 
            this.labTitleAbout.AutoSize = true;
            this.labTitleAbout.Font = new System.Drawing.Font("黑体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labTitleAbout.Location = new System.Drawing.Point(128, 21);
            this.labTitleAbout.Name = "labTitleAbout";
            this.labTitleAbout.Size = new System.Drawing.Size(160, 24);
            this.labTitleAbout.TabIndex = 2;
            this.labTitleAbout.Text = "个人理财软件";
            // 
            // labVersionAbout
            // 
            this.labVersionAbout.AutoSize = true;
            this.labVersionAbout.Location = new System.Drawing.Point(211, 87);
            this.labVersionAbout.Name = "labVersionAbout";
            this.labVersionAbout.Size = new System.Drawing.Size(95, 12);
            this.labVersionAbout.TabIndex = 2;
            this.labVersionAbout.Text = "版    本：  1.0";
            // 
            // labOwnerAbout
            // 
            this.labOwnerAbout.AutoSize = true;
            this.labOwnerAbout.Location = new System.Drawing.Point(211, 129);
            this.labOwnerAbout.Name = "labOwnerAbout";
            this.labOwnerAbout.Size = new System.Drawing.Size(131, 12);
            this.labOwnerAbout.TabIndex = 2;
            this.labOwnerAbout.Text = "版权所有：  2012-2017";
            // 
            // labSupportAbout
            // 
            this.labSupportAbout.AutoSize = true;
            this.labSupportAbout.Location = new System.Drawing.Point(211, 172);
            this.labSupportAbout.Name = "labSupportAbout";
            this.labSupportAbout.Size = new System.Drawing.Size(149, 12);
            this.labSupportAbout.TabIndex = 2;
            this.labSupportAbout.Text = "技术支持：  028-82734386";
            // 
            // Form_Lab6_AboutBox_Us
            // 
            this.AcceptButton = this.btConfirmAbout;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 261);
            this.Controls.Add(this.labSupportAbout);
            this.Controls.Add(this.labOwnerAbout);
            this.Controls.Add(this.labVersionAbout);
            this.Controls.Add(this.labTitleAbout);
            this.Controls.Add(this.btConfirmAbout);
            this.Controls.Add(this.pbAbout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Lab6_AboutBox_Us";
            this.Padding = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "关于我们";
            ((System.ComponentModel.ISupportInitialize)(this.pbAbout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbAbout;
        private System.Windows.Forms.Button btConfirmAbout;
        private System.Windows.Forms.Label labTitleAbout;
        private System.Windows.Forms.Label labVersionAbout;
        private System.Windows.Forms.Label labOwnerAbout;
        private System.Windows.Forms.Label labSupportAbout;

    }
}
