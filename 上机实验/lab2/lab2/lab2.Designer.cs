namespace lab2
{
    partial class lab2Form
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
            this.tbCelsius = new System.Windows.Forms.TextBox();
            this.tbFahrenheit = new System.Windows.Forms.TextBox();
            this.labChange = new System.Windows.Forms.Label();
            this.labFahrenheit = new System.Windows.Forms.Label();
            this.labCelsius = new System.Windows.Forms.Label();
            this.btChange = new System.Windows.Forms.Button();
            this.labMoney = new System.Windows.Forms.Label();
            this.labYear = new System.Windows.Forms.Label();
            this.labInterest = new System.Windows.Forms.Label();
            this.labTotal = new System.Windows.Forms.Label();
            this.tbMoney = new System.Windows.Forms.TextBox();
            this.tbRate = new System.Windows.Forms.TextBox();
            this.tbYear = new System.Windows.Forms.TextBox();
            this.labRate = new System.Windows.Forms.Label();
            this.tbInterest = new System.Windows.Forms.TextBox();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.btCalculate = new System.Windows.Forms.Button();
            this.labYuan = new System.Windows.Forms.Label();
            this.labPersent = new System.Windows.Forms.Label();
            this.labNian = new System.Windows.Forms.Label();
            this.labWeight = new System.Windows.Forms.Label();
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.labMessage = new System.Windows.Forms.Label();
            this.btAdd = new System.Windows.Forms.Button();
            this.labBefore = new System.Windows.Forms.Label();
            this.tbBefore = new System.Windows.Forms.TextBox();
            this.tbAfter = new System.Windows.Forms.TextBox();
            this.labAfter = new System.Windows.Forms.Label();
            this.btAscend = new System.Windows.Forms.Button();
            this.btReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbCelsius
            // 
            this.tbCelsius.Location = new System.Drawing.Point(15, 31);
            this.tbCelsius.Name = "tbCelsius";
            this.tbCelsius.Size = new System.Drawing.Size(73, 21);
            this.tbCelsius.TabIndex = 0;
            this.tbCelsius.Click += new System.EventHandler(this.tbCelsius_Click);
            // 
            // tbFahrenheit
            // 
            this.tbFahrenheit.Location = new System.Drawing.Point(196, 31);
            this.tbFahrenheit.Name = "tbFahrenheit";
            this.tbFahrenheit.Size = new System.Drawing.Size(73, 21);
            this.tbFahrenheit.TabIndex = 0;
            this.tbFahrenheit.Click += new System.EventHandler(this.tbCelsius_Click);
            // 
            // labChange
            // 
            this.labChange.AutoSize = true;
            this.labChange.Location = new System.Drawing.Point(151, 34);
            this.labChange.Name = "labChange";
            this.labChange.Size = new System.Drawing.Size(29, 12);
            this.labChange.TabIndex = 1;
            this.labChange.Text = "<==>";
            // 
            // labFahrenheit
            // 
            this.labFahrenheit.AutoSize = true;
            this.labFahrenheit.Location = new System.Drawing.Point(275, 34);
            this.labFahrenheit.Name = "labFahrenheit";
            this.labFahrenheit.Size = new System.Drawing.Size(41, 12);
            this.labFahrenheit.TabIndex = 1;
            this.labFahrenheit.Text = "华氏度";
            // 
            // labCelsius
            // 
            this.labCelsius.AutoSize = true;
            this.labCelsius.Location = new System.Drawing.Point(94, 34);
            this.labCelsius.Name = "labCelsius";
            this.labCelsius.Size = new System.Drawing.Size(41, 12);
            this.labCelsius.TabIndex = 1;
            this.labCelsius.Text = "摄氏度";
            // 
            // btChange
            // 
            this.btChange.Location = new System.Drawing.Point(351, 28);
            this.btChange.Name = "btChange";
            this.btChange.Size = new System.Drawing.Size(75, 23);
            this.btChange.TabIndex = 2;
            this.btChange.Text = "转换";
            this.btChange.UseVisualStyleBackColor = true;
            this.btChange.Click += new System.EventHandler(this.btChange_Click);
            // 
            // labMoney
            // 
            this.labMoney.AutoSize = true;
            this.labMoney.Location = new System.Drawing.Point(88, 117);
            this.labMoney.Name = "labMoney";
            this.labMoney.Size = new System.Drawing.Size(65, 12);
            this.labMoney.TabIndex = 3;
            this.labMoney.Text = "存款金额：";
            // 
            // labYear
            // 
            this.labYear.AutoSize = true;
            this.labYear.Location = new System.Drawing.Point(88, 201);
            this.labYear.Name = "labYear";
            this.labYear.Size = new System.Drawing.Size(65, 12);
            this.labYear.TabIndex = 3;
            this.labYear.Text = "存款年限：";
            // 
            // labInterest
            // 
            this.labInterest.AutoSize = true;
            this.labInterest.Location = new System.Drawing.Point(86, 309);
            this.labInterest.Name = "labInterest";
            this.labInterest.Size = new System.Drawing.Size(65, 12);
            this.labInterest.TabIndex = 3;
            this.labInterest.Text = "利息总额：";
            // 
            // labTotal
            // 
            this.labTotal.AutoSize = true;
            this.labTotal.Location = new System.Drawing.Point(86, 358);
            this.labTotal.Name = "labTotal";
            this.labTotal.Size = new System.Drawing.Size(65, 12);
            this.labTotal.TabIndex = 3;
            this.labTotal.Text = "本息合计：";
            // 
            // tbMoney
            // 
            this.tbMoney.Location = new System.Drawing.Point(169, 114);
            this.tbMoney.Name = "tbMoney";
            this.tbMoney.Size = new System.Drawing.Size(100, 21);
            this.tbMoney.TabIndex = 4;
            // 
            // tbRate
            // 
            this.tbRate.Location = new System.Drawing.Point(169, 158);
            this.tbRate.Name = "tbRate";
            this.tbRate.Size = new System.Drawing.Size(100, 21);
            this.tbRate.TabIndex = 4;
            // 
            // tbYear
            // 
            this.tbYear.Location = new System.Drawing.Point(169, 198);
            this.tbYear.Name = "tbYear";
            this.tbYear.Size = new System.Drawing.Size(100, 21);
            this.tbYear.TabIndex = 4;
            // 
            // labRate
            // 
            this.labRate.AutoSize = true;
            this.labRate.Location = new System.Drawing.Point(88, 161);
            this.labRate.Name = "labRate";
            this.labRate.Size = new System.Drawing.Size(59, 12);
            this.labRate.TabIndex = 3;
            this.labRate.Text = "年利率%：";
            // 
            // tbInterest
            // 
            this.tbInterest.BackColor = System.Drawing.SystemColors.Control;
            this.tbInterest.Location = new System.Drawing.Point(169, 306);
            this.tbInterest.Name = "tbInterest";
            this.tbInterest.ReadOnly = true;
            this.tbInterest.Size = new System.Drawing.Size(100, 21);
            this.tbInterest.TabIndex = 4;
            this.tbInterest.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbTotal
            // 
            this.tbTotal.BackColor = System.Drawing.SystemColors.Control;
            this.tbTotal.Location = new System.Drawing.Point(169, 355);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.ReadOnly = true;
            this.tbTotal.Size = new System.Drawing.Size(100, 21);
            this.tbTotal.TabIndex = 4;
            this.tbTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btCalculate
            // 
            this.btCalculate.Location = new System.Drawing.Point(194, 248);
            this.btCalculate.Name = "btCalculate";
            this.btCalculate.Size = new System.Drawing.Size(75, 23);
            this.btCalculate.TabIndex = 5;
            this.btCalculate.Text = "计算";
            this.btCalculate.UseVisualStyleBackColor = true;
            this.btCalculate.Click += new System.EventHandler(this.btCalculate_Click);
            // 
            // labYuan
            // 
            this.labYuan.AutoSize = true;
            this.labYuan.Location = new System.Drawing.Point(275, 117);
            this.labYuan.Name = "labYuan";
            this.labYuan.Size = new System.Drawing.Size(17, 12);
            this.labYuan.TabIndex = 3;
            this.labYuan.Text = "元";
            // 
            // labPersent
            // 
            this.labPersent.AutoSize = true;
            this.labPersent.Location = new System.Drawing.Point(275, 161);
            this.labPersent.Name = "labPersent";
            this.labPersent.Size = new System.Drawing.Size(11, 12);
            this.labPersent.TabIndex = 3;
            this.labPersent.Text = "%";
            // 
            // labNian
            // 
            this.labNian.AutoSize = true;
            this.labNian.Location = new System.Drawing.Point(275, 201);
            this.labNian.Name = "labNian";
            this.labNian.Size = new System.Drawing.Size(17, 12);
            this.labNian.TabIndex = 3;
            this.labNian.Text = "年";
            // 
            // labWeight
            // 
            this.labWeight.AutoSize = true;
            this.labWeight.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labWeight.Location = new System.Drawing.Point(604, 33);
            this.labWeight.Name = "labWeight";
            this.labWeight.Size = new System.Drawing.Size(217, 14);
            this.labWeight.TabIndex = 6;
            this.labWeight.Text = "数组空间为5，请依次输入5个数：";
            // 
            // tbNumber
            // 
            this.tbNumber.Location = new System.Drawing.Point(744, 81);
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.Size = new System.Drawing.Size(67, 21);
            this.tbNumber.TabIndex = 7;
            // 
            // labMessage
            // 
            this.labMessage.AutoSize = true;
            this.labMessage.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labMessage.Location = new System.Drawing.Point(605, 82);
            this.labMessage.Name = "labMessage";
            this.labMessage.Size = new System.Drawing.Size(126, 14);
            this.labMessage.TabIndex = 8;
            this.labMessage.Text = "请输入第1个元素：";
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(853, 79);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 9;
            this.btAdd.Text = "添加";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // labBefore
            // 
            this.labBefore.AutoSize = true;
            this.labBefore.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labBefore.Location = new System.Drawing.Point(605, 147);
            this.labBefore.Name = "labBefore";
            this.labBefore.Size = new System.Drawing.Size(119, 14);
            this.labBefore.TabIndex = 8;
            this.labBefore.Text = "排序前数组序列：";
            // 
            // tbBefore
            // 
            this.tbBefore.BackColor = System.Drawing.SystemColors.Control;
            this.tbBefore.Location = new System.Drawing.Point(608, 191);
            this.tbBefore.Name = "tbBefore";
            this.tbBefore.ReadOnly = true;
            this.tbBefore.Size = new System.Drawing.Size(320, 21);
            this.tbBefore.TabIndex = 10;
            // 
            // tbAfter
            // 
            this.tbAfter.BackColor = System.Drawing.SystemColors.Control;
            this.tbAfter.Location = new System.Drawing.Point(607, 309);
            this.tbAfter.Name = "tbAfter";
            this.tbAfter.ReadOnly = true;
            this.tbAfter.Size = new System.Drawing.Size(321, 21);
            this.tbAfter.TabIndex = 10;
            // 
            // labAfter
            // 
            this.labAfter.AutoSize = true;
            this.labAfter.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labAfter.Location = new System.Drawing.Point(605, 257);
            this.labAfter.Name = "labAfter";
            this.labAfter.Size = new System.Drawing.Size(119, 14);
            this.labAfter.TabIndex = 8;
            this.labAfter.Text = "排序后数组序列：";
            // 
            // btAscend
            // 
            this.btAscend.Location = new System.Drawing.Point(853, 254);
            this.btAscend.Name = "btAscend";
            this.btAscend.Size = new System.Drawing.Size(75, 23);
            this.btAscend.TabIndex = 9;
            this.btAscend.Text = "升序";
            this.btAscend.UseVisualStyleBackColor = true;
            this.btAscend.Click += new System.EventHandler(this.btAscend_Click);
            // 
            // btReset
            // 
            this.btReset.Location = new System.Drawing.Point(698, 82);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(75, 23);
            this.btReset.TabIndex = 11;
            this.btReset.Text = "重置";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Visible = false;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // lab2Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 481);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.tbAfter);
            this.Controls.Add(this.tbBefore);
            this.Controls.Add(this.btAscend);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.labAfter);
            this.Controls.Add(this.labBefore);
            this.Controls.Add(this.labMessage);
            this.Controls.Add(this.tbNumber);
            this.Controls.Add(this.labWeight);
            this.Controls.Add(this.btCalculate);
            this.Controls.Add(this.tbTotal);
            this.Controls.Add(this.tbInterest);
            this.Controls.Add(this.tbYear);
            this.Controls.Add(this.tbRate);
            this.Controls.Add(this.tbMoney);
            this.Controls.Add(this.labTotal);
            this.Controls.Add(this.labInterest);
            this.Controls.Add(this.labYear);
            this.Controls.Add(this.labNian);
            this.Controls.Add(this.labPersent);
            this.Controls.Add(this.labRate);
            this.Controls.Add(this.labYuan);
            this.Controls.Add(this.labMoney);
            this.Controls.Add(this.btChange);
            this.Controls.Add(this.labFahrenheit);
            this.Controls.Add(this.labCelsius);
            this.Controls.Add(this.labChange);
            this.Controls.Add(this.tbFahrenheit);
            this.Controls.Add(this.tbCelsius);
            this.Name = "lab2Form";
            this.Text = "窗口";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCelsius;
        private System.Windows.Forms.TextBox tbFahrenheit;
        private System.Windows.Forms.Label labChange;
        private System.Windows.Forms.Label labFahrenheit;
        private System.Windows.Forms.Label labCelsius;
        private System.Windows.Forms.Button btChange;
        private System.Windows.Forms.Label labMoney;
        private System.Windows.Forms.Label labYear;
        private System.Windows.Forms.Label labInterest;
        private System.Windows.Forms.Label labTotal;
        private System.Windows.Forms.TextBox tbMoney;
        private System.Windows.Forms.TextBox tbRate;
        private System.Windows.Forms.TextBox tbYear;
        private System.Windows.Forms.Label labRate;
        private System.Windows.Forms.TextBox tbInterest;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Button btCalculate;
        private System.Windows.Forms.Label labYuan;
        private System.Windows.Forms.Label labPersent;
        private System.Windows.Forms.Label labNian;
        private System.Windows.Forms.Label labWeight;
        private System.Windows.Forms.TextBox tbNumber;
        private System.Windows.Forms.Label labMessage;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Label labBefore;
        private System.Windows.Forms.TextBox tbBefore;
        private System.Windows.Forms.TextBox tbAfter;
        private System.Windows.Forms.Label labAfter;
        private System.Windows.Forms.Button btAscend;
        private System.Windows.Forms.Button btReset;
    }
}

