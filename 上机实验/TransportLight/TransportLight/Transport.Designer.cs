namespace TransportLight
{
    partial class Transport
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transport));
            this.labUp = new System.Windows.Forms.Label();
            this.labDown = new System.Windows.Forms.Label();
            this.labRight = new System.Windows.Forms.Label();
            this.labLeft = new System.Windows.Forms.Label();
            this.pbLeft = new System.Windows.Forms.PictureBox();
            this.pbUp = new System.Windows.Forms.PictureBox();
            this.pbRight = new System.Windows.Forms.PictureBox();
            this.pbDown = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btAction = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDown)).BeginInit();
            this.SuspendLayout();
            // 
            // labUp
            // 
            this.labUp.AutoSize = true;
            this.labUp.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labUp.Location = new System.Drawing.Point(327, 151);
            this.labUp.Name = "labUp";
            this.labUp.Size = new System.Drawing.Size(21, 14);
            this.labUp.TabIndex = 0;
            this.labUp.Text = "00";
            // 
            // labDown
            // 
            this.labDown.AutoSize = true;
            this.labDown.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labDown.Location = new System.Drawing.Point(327, 360);
            this.labDown.Name = "labDown";
            this.labDown.Size = new System.Drawing.Size(21, 14);
            this.labDown.TabIndex = 0;
            this.labDown.Text = "00";
            // 
            // labRight
            // 
            this.labRight.AutoSize = true;
            this.labRight.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labRight.Location = new System.Drawing.Point(515, 274);
            this.labRight.Name = "labRight";
            this.labRight.Size = new System.Drawing.Size(21, 14);
            this.labRight.TabIndex = 0;
            this.labRight.Text = "00";
            // 
            // labLeft
            // 
            this.labLeft.AutoSize = true;
            this.labLeft.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labLeft.Location = new System.Drawing.Point(210, 274);
            this.labLeft.Name = "labLeft";
            this.labLeft.Size = new System.Drawing.Size(21, 14);
            this.labLeft.TabIndex = 0;
            this.labLeft.Text = "00";
            // 
            // pbLeft
            // 
            this.pbLeft.Image = ((System.Drawing.Image)(resources.GetObject("pbLeft.Image")));
            this.pbLeft.Location = new System.Drawing.Point(197, 220);
            this.pbLeft.Name = "pbLeft";
            this.pbLeft.Size = new System.Drawing.Size(42, 39);
            this.pbLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbLeft.TabIndex = 1;
            this.pbLeft.TabStop = false;
            // 
            // pbUp
            // 
            this.pbUp.Image = ((System.Drawing.Image)(resources.GetObject("pbUp.Image")));
            this.pbUp.Location = new System.Drawing.Point(374, 136);
            this.pbUp.Name = "pbUp";
            this.pbUp.Size = new System.Drawing.Size(42, 39);
            this.pbUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbUp.TabIndex = 1;
            this.pbUp.TabStop = false;
            // 
            // pbRight
            // 
            this.pbRight.Image = ((System.Drawing.Image)(resources.GetObject("pbRight.Image")));
            this.pbRight.Location = new System.Drawing.Point(499, 220);
            this.pbRight.Name = "pbRight";
            this.pbRight.Size = new System.Drawing.Size(42, 39);
            this.pbRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbRight.TabIndex = 1;
            this.pbRight.TabStop = false;
            // 
            // pbDown
            // 
            this.pbDown.Image = ((System.Drawing.Image)(resources.GetObject("pbDown.Image")));
            this.pbDown.Location = new System.Drawing.Point(374, 345);
            this.pbDown.Name = "pbDown";
            this.pbDown.Size = new System.Drawing.Size(42, 39);
            this.pbDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbDown.TabIndex = 1;
            this.pbDown.TabStop = false;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // btAction
            // 
            this.btAction.Location = new System.Drawing.Point(137, 90);
            this.btAction.Name = "btAction";
            this.btAction.Size = new System.Drawing.Size(75, 23);
            this.btAction.TabIndex = 2;
            this.btAction.Text = "Start";
            this.btAction.UseVisualStyleBackColor = true;
            this.btAction.Click += new System.EventHandler(this.btAction_Click);
            // 
            // Transport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(740, 541);
            this.Controls.Add(this.btAction);
            this.Controls.Add(this.pbDown);
            this.Controls.Add(this.pbRight);
            this.Controls.Add(this.pbUp);
            this.Controls.Add(this.pbLeft);
            this.Controls.Add(this.labDown);
            this.Controls.Add(this.labLeft);
            this.Controls.Add(this.labRight);
            this.Controls.Add(this.labUp);
            this.Name = "Transport";
            this.Text = "Form";
            ((System.ComponentModel.ISupportInitialize)(this.pbLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labUp;
        private System.Windows.Forms.Label labDown;
        private System.Windows.Forms.Label labRight;
        private System.Windows.Forms.Label labLeft;
        private System.Windows.Forms.PictureBox pbLeft;
        private System.Windows.Forms.PictureBox pbUp;
        private System.Windows.Forms.PictureBox pbRight;
        private System.Windows.Forms.PictureBox pbDown;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button btAction;

    }
}

