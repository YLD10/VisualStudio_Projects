namespace FormDemo1
{
    partial class Form1
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
            this.btPlus = new System.Windows.Forms.Button();
            this.tBoxPlus = new System.Windows.Forms.TextBox();
            this.btMultiply = new System.Windows.Forms.Button();
            this.tBoxMultiply = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btPlus
            // 
            this.btPlus.Location = new System.Drawing.Point(151, 64);
            this.btPlus.Name = "btPlus";
            this.btPlus.Size = new System.Drawing.Size(75, 23);
            this.btPlus.TabIndex = 0;
            this.btPlus.Text = "+";
            this.btPlus.UseVisualStyleBackColor = true;
            this.btPlus.Click += new System.EventHandler(this.btPuls_Click);
            // 
            // tBoxPlus
            // 
            this.tBoxPlus.Location = new System.Drawing.Point(45, 64);
            this.tBoxPlus.Name = "tBoxPlus";
            this.tBoxPlus.Size = new System.Drawing.Size(100, 21);
            this.tBoxPlus.TabIndex = 1;
            this.tBoxPlus.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btMultiply
            // 
            this.btMultiply.Location = new System.Drawing.Point(151, 117);
            this.btMultiply.Name = "btMultiply";
            this.btMultiply.Size = new System.Drawing.Size(75, 23);
            this.btMultiply.TabIndex = 2;
            this.btMultiply.Text = "*";
            this.btMultiply.UseVisualStyleBackColor = true;
            this.btMultiply.Click += new System.EventHandler(this.btMultiply_Click);
            // 
            // tBoxMultiply
            // 
            this.tBoxMultiply.Location = new System.Drawing.Point(45, 118);
            this.tBoxMultiply.Name = "tBoxMultiply";
            this.tBoxMultiply.Size = new System.Drawing.Size(100, 21);
            this.tBoxMultiply.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.tBoxMultiply);
            this.Controls.Add(this.btMultiply);
            this.Controls.Add(this.tBoxPlus);
            this.Controls.Add(this.btPlus);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btPlus;
        private System.Windows.Forms.TextBox tBoxPlus;
        private System.Windows.Forms.Button btMultiply;
        private System.Windows.Forms.TextBox tBoxMultiply;
    }
}

