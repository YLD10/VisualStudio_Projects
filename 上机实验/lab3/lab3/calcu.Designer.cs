namespace lab3
{
    partial class calcu
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
            this.labNumberA = new System.Windows.Forms.Label();
            this.labNumberB = new System.Windows.Forms.Label();
            this.tbNumberA = new System.Windows.Forms.TextBox();
            this.tbNumberB = new System.Windows.Forms.TextBox();
            this.btPlus = new System.Windows.Forms.Button();
            this.btMinus = new System.Windows.Forms.Button();
            this.btDivide = new System.Windows.Forms.Button();
            this.btMultiply = new System.Windows.Forms.Button();
            this.btPow = new System.Windows.Forms.Button();
            this.labResult = new System.Windows.Forms.Label();
            this.labNumberA2 = new System.Windows.Forms.Label();
            this.labOperator = new System.Windows.Forms.Label();
            this.labNumberB2 = new System.Windows.Forms.Label();
            this.tbNumberA2 = new System.Windows.Forms.TextBox();
            this.tbOperator = new System.Windows.Forms.TextBox();
            this.tbNumberB2 = new System.Windows.Forms.TextBox();
            this.btCalculate = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.labResult2 = new System.Windows.Forms.Label();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labNumberA
            // 
            this.labNumberA.AutoSize = true;
            this.labNumberA.Location = new System.Drawing.Point(80, 47);
            this.labNumberA.Name = "labNumberA";
            this.labNumberA.Size = new System.Drawing.Size(47, 12);
            this.labNumberA.TabIndex = 0;
            this.labNumberA.Text = "数字a：";
            // 
            // labNumberB
            // 
            this.labNumberB.AutoSize = true;
            this.labNumberB.Location = new System.Drawing.Point(80, 100);
            this.labNumberB.Name = "labNumberB";
            this.labNumberB.Size = new System.Drawing.Size(47, 12);
            this.labNumberB.TabIndex = 0;
            this.labNumberB.Text = "数字b：";
            // 
            // tbNumberA
            // 
            this.tbNumberA.Location = new System.Drawing.Point(143, 44);
            this.tbNumberA.Name = "tbNumberA";
            this.tbNumberA.Size = new System.Drawing.Size(100, 21);
            this.tbNumberA.TabIndex = 1;
            this.tbNumberA.TextChanged += new System.EventHandler(this.tbNumberA_TextChanged);
            // 
            // tbNumberB
            // 
            this.tbNumberB.Location = new System.Drawing.Point(143, 97);
            this.tbNumberB.Name = "tbNumberB";
            this.tbNumberB.Size = new System.Drawing.Size(100, 21);
            this.tbNumberB.TabIndex = 1;
            this.tbNumberB.TextChanged += new System.EventHandler(this.tbNumberA_TextChanged);
            // 
            // btPlus
            // 
            this.btPlus.Location = new System.Drawing.Point(271, 42);
            this.btPlus.Name = "btPlus";
            this.btPlus.Size = new System.Drawing.Size(33, 23);
            this.btPlus.TabIndex = 2;
            this.btPlus.Text = "加";
            this.btPlus.UseVisualStyleBackColor = true;
            this.btPlus.Click += new System.EventHandler(this.btPlus_Click);
            // 
            // btMinus
            // 
            this.btMinus.Location = new System.Drawing.Point(313, 42);
            this.btMinus.Name = "btMinus";
            this.btMinus.Size = new System.Drawing.Size(33, 23);
            this.btMinus.TabIndex = 2;
            this.btMinus.Text = "减";
            this.btMinus.UseVisualStyleBackColor = true;
            this.btMinus.Click += new System.EventHandler(this.btMinus_Click);
            // 
            // btDivide
            // 
            this.btDivide.Location = new System.Drawing.Point(313, 71);
            this.btDivide.Name = "btDivide";
            this.btDivide.Size = new System.Drawing.Size(33, 23);
            this.btDivide.TabIndex = 2;
            this.btDivide.Text = "除";
            this.btDivide.UseVisualStyleBackColor = true;
            this.btDivide.Click += new System.EventHandler(this.btDivide_Click);
            // 
            // btMultiply
            // 
            this.btMultiply.Location = new System.Drawing.Point(271, 71);
            this.btMultiply.Name = "btMultiply";
            this.btMultiply.Size = new System.Drawing.Size(33, 23);
            this.btMultiply.TabIndex = 2;
            this.btMultiply.Text = "乘";
            this.btMultiply.UseVisualStyleBackColor = true;
            this.btMultiply.Click += new System.EventHandler(this.btMultiply_Click);
            // 
            // btPow
            // 
            this.btPow.Location = new System.Drawing.Point(271, 100);
            this.btPow.Name = "btPow";
            this.btPow.Size = new System.Drawing.Size(75, 23);
            this.btPow.TabIndex = 3;
            this.btPow.Text = "a的b次方";
            this.btPow.UseVisualStyleBackColor = true;
            this.btPow.Click += new System.EventHandler(this.btPow_Click);
            // 
            // labResult
            // 
            this.labResult.AutoSize = true;
            this.labResult.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labResult.Location = new System.Drawing.Point(143, 162);
            this.labResult.Name = "labResult";
            this.labResult.Size = new System.Drawing.Size(49, 14);
            this.labResult.TabIndex = 4;
            this.labResult.Text = "result";
            this.labResult.Visible = false;
            // 
            // labNumberA2
            // 
            this.labNumberA2.AutoSize = true;
            this.labNumberA2.Location = new System.Drawing.Point(126, 230);
            this.labNumberA2.Name = "labNumberA2";
            this.labNumberA2.Size = new System.Drawing.Size(47, 12);
            this.labNumberA2.TabIndex = 5;
            this.labNumberA2.Text = "数字a：";
            // 
            // labOperator
            // 
            this.labOperator.AutoSize = true;
            this.labOperator.Location = new System.Drawing.Point(126, 265);
            this.labOperator.Name = "labOperator";
            this.labOperator.Size = new System.Drawing.Size(53, 12);
            this.labOperator.TabIndex = 5;
            this.labOperator.Text = "运算符：";
            // 
            // labNumberB2
            // 
            this.labNumberB2.AutoSize = true;
            this.labNumberB2.Location = new System.Drawing.Point(126, 300);
            this.labNumberB2.Name = "labNumberB2";
            this.labNumberB2.Size = new System.Drawing.Size(47, 12);
            this.labNumberB2.TabIndex = 5;
            this.labNumberB2.Text = "数字b：";
            // 
            // tbNumberA2
            // 
            this.tbNumberA2.Location = new System.Drawing.Point(194, 227);
            this.tbNumberA2.Name = "tbNumberA2";
            this.tbNumberA2.Size = new System.Drawing.Size(100, 21);
            this.tbNumberA2.TabIndex = 6;
            this.tbNumberA2.TextChanged += new System.EventHandler(this.tbNumberA2_TextChanged);
            // 
            // tbOperator
            // 
            this.tbOperator.Location = new System.Drawing.Point(194, 262);
            this.tbOperator.Name = "tbOperator";
            this.tbOperator.Size = new System.Drawing.Size(100, 21);
            this.tbOperator.TabIndex = 6;
            this.tbOperator.TextChanged += new System.EventHandler(this.tbNumberA2_TextChanged);
            // 
            // tbNumberB2
            // 
            this.tbNumberB2.Location = new System.Drawing.Point(194, 297);
            this.tbNumberB2.Name = "tbNumberB2";
            this.tbNumberB2.Size = new System.Drawing.Size(100, 21);
            this.tbNumberB2.TabIndex = 6;
            this.tbNumberB2.TextChanged += new System.EventHandler(this.tbNumberA2_TextChanged);
            // 
            // btCalculate
            // 
            this.btCalculate.Location = new System.Drawing.Point(128, 335);
            this.btCalculate.Name = "btCalculate";
            this.btCalculate.Size = new System.Drawing.Size(75, 23);
            this.btCalculate.TabIndex = 7;
            this.btCalculate.Text = "计算";
            this.btCalculate.UseVisualStyleBackColor = true;
            this.btCalculate.Click += new System.EventHandler(this.btCalculate_Click);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(219, 335);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 7;
            this.btCancel.Text = "取消";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // labResult2
            // 
            this.labResult2.AutoSize = true;
            this.labResult2.Location = new System.Drawing.Point(126, 387);
            this.labResult2.Name = "labResult2";
            this.labResult2.Size = new System.Drawing.Size(41, 12);
            this.labResult2.TabIndex = 5;
            this.labResult2.Text = "结果：";
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(194, 384);
            this.tbResult.Name = "tbResult";
            this.tbResult.ReadOnly = true;
            this.tbResult.Size = new System.Drawing.Size(100, 21);
            this.tbResult.TabIndex = 6;
            // 
            // calcu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 492);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btCalculate);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.tbNumberB2);
            this.Controls.Add(this.tbOperator);
            this.Controls.Add(this.tbNumberA2);
            this.Controls.Add(this.labResult2);
            this.Controls.Add(this.labNumberB2);
            this.Controls.Add(this.labOperator);
            this.Controls.Add(this.labNumberA2);
            this.Controls.Add(this.labResult);
            this.Controls.Add(this.btPow);
            this.Controls.Add(this.btDivide);
            this.Controls.Add(this.btMultiply);
            this.Controls.Add(this.btMinus);
            this.Controls.Add(this.btPlus);
            this.Controls.Add(this.tbNumberB);
            this.Controls.Add(this.tbNumberA);
            this.Controls.Add(this.labNumberB);
            this.Controls.Add(this.labNumberA);
            this.Name = "calcu";
            this.Text = "Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labNumberA;
        private System.Windows.Forms.Label labNumberB;
        private System.Windows.Forms.TextBox tbNumberA;
        private System.Windows.Forms.TextBox tbNumberB;
        private System.Windows.Forms.Button btPlus;
        private System.Windows.Forms.Button btMinus;
        private System.Windows.Forms.Button btDivide;
        private System.Windows.Forms.Button btMultiply;
        private System.Windows.Forms.Button btPow;
        private System.Windows.Forms.Label labResult;
        private System.Windows.Forms.Label labNumberA2;
        private System.Windows.Forms.Label labOperator;
        private System.Windows.Forms.Label labNumberB2;
        private System.Windows.Forms.TextBox tbNumberA2;
        private System.Windows.Forms.TextBox tbOperator;
        private System.Windows.Forms.TextBox tbNumberB2;
        private System.Windows.Forms.Button btCalculate;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Label labResult2;
        private System.Windows.Forms.TextBox tbResult;
    }
}

