namespace lab5
{
    partial class Lab5_Form
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
            this.labName = new System.Windows.Forms.Label();
            this.labAge = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.labChinese = new System.Windows.Forms.Label();
            this.labMath = new System.Windows.Forms.Label();
            this.tbChinese = new System.Windows.Forms.TextBox();
            this.tbMath = new System.Windows.Forms.TextBox();
            this.btPupil = new System.Windows.Forms.Button();
            this.btMiddle = new System.Windows.Forms.Button();
            this.labEnglish = new System.Windows.Forms.Label();
            this.tbEnglish = new System.Windows.Forms.TextBox();
            this.btCollege = new System.Windows.Forms.Button();
            this.tbManifest = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Location = new System.Drawing.Point(46, 59);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(41, 12);
            this.labName.TabIndex = 0;
            this.labName.Text = "姓名：";
            // 
            // labAge
            // 
            this.labAge.AutoSize = true;
            this.labAge.Location = new System.Drawing.Point(46, 108);
            this.labAge.Name = "labAge";
            this.labAge.Size = new System.Drawing.Size(41, 12);
            this.labAge.TabIndex = 0;
            this.labAge.Text = "年龄：";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(93, 56);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 21);
            this.tbName.TabIndex = 1;
            this.tbName.Click += new System.EventHandler(this.textBox_Click);
            // 
            // tbAge
            // 
            this.tbAge.Location = new System.Drawing.Point(93, 105);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(100, 21);
            this.tbAge.TabIndex = 1;
            this.tbAge.Click += new System.EventHandler(this.textBox_Click);
            // 
            // labChinese
            // 
            this.labChinese.AutoSize = true;
            this.labChinese.Location = new System.Drawing.Point(213, 59);
            this.labChinese.Name = "labChinese";
            this.labChinese.Size = new System.Drawing.Size(83, 12);
            this.labChinese.TabIndex = 0;
            this.labChinese.Text = "语文/必修课：";
            // 
            // labMath
            // 
            this.labMath.AutoSize = true;
            this.labMath.Location = new System.Drawing.Point(213, 108);
            this.labMath.Name = "labMath";
            this.labMath.Size = new System.Drawing.Size(83, 12);
            this.labMath.TabIndex = 0;
            this.labMath.Text = "数学/选修课：";
            // 
            // tbChinese
            // 
            this.tbChinese.Location = new System.Drawing.Point(302, 56);
            this.tbChinese.Name = "tbChinese";
            this.tbChinese.Size = new System.Drawing.Size(100, 21);
            this.tbChinese.TabIndex = 1;
            this.tbChinese.Click += new System.EventHandler(this.textBox_Click);
            // 
            // tbMath
            // 
            this.tbMath.Location = new System.Drawing.Point(302, 105);
            this.tbMath.Name = "tbMath";
            this.tbMath.Size = new System.Drawing.Size(100, 21);
            this.tbMath.TabIndex = 1;
            this.tbMath.Click += new System.EventHandler(this.textBox_Click);
            // 
            // btPupil
            // 
            this.btPupil.Location = new System.Drawing.Point(449, 54);
            this.btPupil.Name = "btPupil";
            this.btPupil.Size = new System.Drawing.Size(75, 23);
            this.btPupil.TabIndex = 2;
            this.btPupil.Text = "小学生";
            this.btPupil.UseVisualStyleBackColor = true;
            this.btPupil.Click += new System.EventHandler(this.btPupil_Click);
            // 
            // btMiddle
            // 
            this.btMiddle.Location = new System.Drawing.Point(449, 103);
            this.btMiddle.Name = "btMiddle";
            this.btMiddle.Size = new System.Drawing.Size(75, 23);
            this.btMiddle.TabIndex = 2;
            this.btMiddle.Text = "中学生";
            this.btMiddle.UseVisualStyleBackColor = true;
            this.btMiddle.Click += new System.EventHandler(this.btPupil_Click);
            // 
            // labEnglish
            // 
            this.labEnglish.AutoSize = true;
            this.labEnglish.Location = new System.Drawing.Point(255, 159);
            this.labEnglish.Name = "labEnglish";
            this.labEnglish.Size = new System.Drawing.Size(41, 12);
            this.labEnglish.TabIndex = 0;
            this.labEnglish.Text = "英语：";
            // 
            // tbEnglish
            // 
            this.tbEnglish.Location = new System.Drawing.Point(302, 156);
            this.tbEnglish.Name = "tbEnglish";
            this.tbEnglish.Size = new System.Drawing.Size(100, 21);
            this.tbEnglish.TabIndex = 1;
            this.tbEnglish.Click += new System.EventHandler(this.textBox_Click);
            // 
            // btCollege
            // 
            this.btCollege.Location = new System.Drawing.Point(449, 154);
            this.btCollege.Name = "btCollege";
            this.btCollege.Size = new System.Drawing.Size(75, 23);
            this.btCollege.TabIndex = 2;
            this.btCollege.Text = "大学生";
            this.btCollege.UseVisualStyleBackColor = true;
            this.btCollege.Click += new System.EventHandler(this.btPupil_Click);
            // 
            // tbManifest
            // 
            this.tbManifest.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbManifest.Location = new System.Drawing.Point(48, 239);
            this.tbManifest.Multiline = true;
            this.tbManifest.Name = "tbManifest";
            this.tbManifest.ReadOnly = true;
            this.tbManifest.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbManifest.Size = new System.Drawing.Size(476, 130);
            this.tbManifest.TabIndex = 3;
            // 
            // Lab5_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 420);
            this.Controls.Add(this.tbManifest);
            this.Controls.Add(this.btCollege);
            this.Controls.Add(this.btMiddle);
            this.Controls.Add(this.btPupil);
            this.Controls.Add(this.tbEnglish);
            this.Controls.Add(this.tbMath);
            this.Controls.Add(this.tbAge);
            this.Controls.Add(this.labEnglish);
            this.Controls.Add(this.tbChinese);
            this.Controls.Add(this.labMath);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.labChinese);
            this.Controls.Add(this.labAge);
            this.Controls.Add(this.labName);
            this.Name = "Lab5_Form";
            this.Text = "lab5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label labAge;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbAge;
        private System.Windows.Forms.Label labChinese;
        private System.Windows.Forms.Label labMath;
        private System.Windows.Forms.TextBox tbChinese;
        private System.Windows.Forms.TextBox tbMath;
        private System.Windows.Forms.Button btPupil;
        private System.Windows.Forms.Button btMiddle;
        private System.Windows.Forms.Label labEnglish;
        private System.Windows.Forms.TextBox tbEnglish;
        private System.Windows.Forms.Button btCollege;
        private System.Windows.Forms.TextBox tbManifest;
    }
}

