namespace Lab6
{
    partial class Form_Lab6_InOutRecord
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
            this.labTypeInOutRecord = new System.Windows.Forms.Label();
            this.labCateGoryInOutRecord = new System.Windows.Forms.Label();
            this.labItemInOutRecord = new System.Windows.Forms.Label();
            this.labRemarkInOutRecord = new System.Windows.Forms.Label();
            this.labDateInOutRecord = new System.Windows.Forms.Label();
            this.labExplainInOutRecord = new System.Windows.Forms.Label();
            this.labPersonInOutRecord = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.rbIn = new System.Windows.Forms.RadioButton();
            this.rbOut = new System.Windows.Forms.RadioButton();
            this.dtpDateInOutRecord = new System.Windows.Forms.DateTimePicker();
            this.tbExplainInOutRecord = new System.Windows.Forms.TextBox();
            this.tbItemInOutRecord = new System.Windows.Forms.TextBox();
            this.tbRemarkInOutRecord = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cbMe = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.cbCategoryInOutRecord = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // labTypeInOutRecord
            // 
            this.labTypeInOutRecord.AutoSize = true;
            this.labTypeInOutRecord.Location = new System.Drawing.Point(54, 12);
            this.labTypeInOutRecord.Name = "labTypeInOutRecord";
            this.labTypeInOutRecord.Size = new System.Drawing.Size(65, 12);
            this.labTypeInOutRecord.TabIndex = 0;
            this.labTypeInOutRecord.Text = "收支类型：";
            // 
            // labCateGoryInOutRecord
            // 
            this.labCateGoryInOutRecord.AutoSize = true;
            this.labCateGoryInOutRecord.Location = new System.Drawing.Point(54, 55);
            this.labCateGoryInOutRecord.Name = "labCateGoryInOutRecord";
            this.labCateGoryInOutRecord.Size = new System.Drawing.Size(65, 12);
            this.labCateGoryInOutRecord.TabIndex = 0;
            this.labCateGoryInOutRecord.Text = "收支类别：";
            // 
            // labItemInOutRecord
            // 
            this.labItemInOutRecord.AutoSize = true;
            this.labItemInOutRecord.Location = new System.Drawing.Point(54, 100);
            this.labItemInOutRecord.Name = "labItemInOutRecord";
            this.labItemInOutRecord.Size = new System.Drawing.Size(65, 12);
            this.labItemInOutRecord.TabIndex = 0;
            this.labItemInOutRecord.Text = "收支项目：";
            // 
            // labRemarkInOutRecord
            // 
            this.labRemarkInOutRecord.AutoSize = true;
            this.labRemarkInOutRecord.Location = new System.Drawing.Point(54, 193);
            this.labRemarkInOutRecord.Name = "labRemarkInOutRecord";
            this.labRemarkInOutRecord.Size = new System.Drawing.Size(65, 12);
            this.labRemarkInOutRecord.TabIndex = 0;
            this.labRemarkInOutRecord.Text = "备    注：";
            // 
            // labDateInOutRecord
            // 
            this.labDateInOutRecord.AutoSize = true;
            this.labDateInOutRecord.Location = new System.Drawing.Point(322, 12);
            this.labDateInOutRecord.Name = "labDateInOutRecord";
            this.labDateInOutRecord.Size = new System.Drawing.Size(47, 12);
            this.labDateInOutRecord.TabIndex = 0;
            this.labDateInOutRecord.Text = "日 期：";
            // 
            // labExplainInOutRecord
            // 
            this.labExplainInOutRecord.AutoSize = true;
            this.labExplainInOutRecord.Location = new System.Drawing.Point(322, 55);
            this.labExplainInOutRecord.Name = "labExplainInOutRecord";
            this.labExplainInOutRecord.Size = new System.Drawing.Size(47, 12);
            this.labExplainInOutRecord.TabIndex = 0;
            this.labExplainInOutRecord.Text = "说 明：";
            // 
            // labPersonInOutRecord
            // 
            this.labPersonInOutRecord.AutoSize = true;
            this.labPersonInOutRecord.Location = new System.Drawing.Point(316, 101);
            this.labPersonInOutRecord.Name = "labPersonInOutRecord";
            this.labPersonInOutRecord.Size = new System.Drawing.Size(53, 12);
            this.labPersonInOutRecord.TabIndex = 0;
            this.labPersonInOutRecord.Text = "收支人：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(305, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "label1";
            // 
            // rbIn
            // 
            this.rbIn.AutoSize = true;
            this.rbIn.Location = new System.Drawing.Point(125, 12);
            this.rbIn.Name = "rbIn";
            this.rbIn.Size = new System.Drawing.Size(47, 16);
            this.rbIn.TabIndex = 1;
            this.rbIn.TabStop = true;
            this.rbIn.Text = "收入";
            this.rbIn.UseVisualStyleBackColor = true;
            // 
            // rbOut
            // 
            this.rbOut.AutoSize = true;
            this.rbOut.Location = new System.Drawing.Point(191, 12);
            this.rbOut.Name = "rbOut";
            this.rbOut.Size = new System.Drawing.Size(47, 16);
            this.rbOut.TabIndex = 1;
            this.rbOut.TabStop = true;
            this.rbOut.Text = "支出";
            this.rbOut.UseVisualStyleBackColor = true;
            // 
            // dtpDateInOutRecord
            // 
            this.dtpDateInOutRecord.Location = new System.Drawing.Point(375, 8);
            this.dtpDateInOutRecord.Name = "dtpDateInOutRecord";
            this.dtpDateInOutRecord.Size = new System.Drawing.Size(200, 21);
            this.dtpDateInOutRecord.TabIndex = 2;
            // 
            // tbExplainInOutRecord
            // 
            this.tbExplainInOutRecord.Location = new System.Drawing.Point(375, 55);
            this.tbExplainInOutRecord.Name = "tbExplainInOutRecord";
            this.tbExplainInOutRecord.Size = new System.Drawing.Size(100, 21);
            this.tbExplainInOutRecord.TabIndex = 3;
            // 
            // tbItemInOutRecord
            // 
            this.tbItemInOutRecord.Location = new System.Drawing.Point(125, 100);
            this.tbItemInOutRecord.Multiline = true;
            this.tbItemInOutRecord.Name = "tbItemInOutRecord";
            this.tbItemInOutRecord.Size = new System.Drawing.Size(137, 78);
            this.tbItemInOutRecord.TabIndex = 3;
            // 
            // tbRemarkInOutRecord
            // 
            this.tbRemarkInOutRecord.Location = new System.Drawing.Point(125, 193);
            this.tbRemarkInOutRecord.Multiline = true;
            this.tbRemarkInOutRecord.Name = "tbRemarkInOutRecord";
            this.tbRemarkInOutRecord.Size = new System.Drawing.Size(450, 136);
            this.tbRemarkInOutRecord.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(191, 353);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(375, 352);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // cbMe
            // 
            this.cbMe.AutoSize = true;
            this.cbMe.Location = new System.Drawing.Point(375, 100);
            this.cbMe.Name = "cbMe";
            this.cbMe.Size = new System.Drawing.Size(36, 16);
            this.cbMe.TabIndex = 6;
            this.cbMe.Text = "我";
            this.cbMe.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(440, 99);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(78, 16);
            this.checkBox2.TabIndex = 6;
            this.checkBox2.Text = "checkBox1";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(497, 99);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(78, 16);
            this.checkBox3.TabIndex = 6;
            this.checkBox3.Text = "checkBox1";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(375, 134);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(78, 16);
            this.checkBox4.TabIndex = 6;
            this.checkBox4.Text = "checkBox1";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(440, 133);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(78, 16);
            this.checkBox5.TabIndex = 6;
            this.checkBox5.Text = "checkBox1";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(497, 133);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(78, 16);
            this.checkBox6.TabIndex = 6;
            this.checkBox6.Text = "checkBox1";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(375, 166);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 21);
            this.numericUpDown1.TabIndex = 7;
            // 
            // cbCategoryInOutRecord
            // 
            this.cbCategoryInOutRecord.FormattingEnabled = true;
            this.cbCategoryInOutRecord.Location = new System.Drawing.Point(125, 55);
            this.cbCategoryInOutRecord.Name = "cbCategoryInOutRecord";
            this.cbCategoryInOutRecord.Size = new System.Drawing.Size(121, 20);
            this.cbCategoryInOutRecord.TabIndex = 8;
            // 
            // Form_Lab6_InOutRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 402);
            this.Controls.Add(this.cbCategoryInOutRecord);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.checkBox6);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.cbMe);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbRemarkInOutRecord);
            this.Controls.Add(this.tbItemInOutRecord);
            this.Controls.Add(this.tbExplainInOutRecord);
            this.Controls.Add(this.dtpDateInOutRecord);
            this.Controls.Add(this.rbOut);
            this.Controls.Add(this.rbIn);
            this.Controls.Add(this.labRemarkInOutRecord);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labPersonInOutRecord);
            this.Controls.Add(this.labItemInOutRecord);
            this.Controls.Add(this.labExplainInOutRecord);
            this.Controls.Add(this.labCateGoryInOutRecord);
            this.Controls.Add(this.labDateInOutRecord);
            this.Controls.Add(this.labTypeInOutRecord);
            this.Name = "Form_Lab6_InOutRecord";
            this.Text = "收支情况记录";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labTypeInOutRecord;
        private System.Windows.Forms.Label labCateGoryInOutRecord;
        private System.Windows.Forms.Label labItemInOutRecord;
        private System.Windows.Forms.Label labRemarkInOutRecord;
        private System.Windows.Forms.Label labDateInOutRecord;
        private System.Windows.Forms.Label labExplainInOutRecord;
        private System.Windows.Forms.Label labPersonInOutRecord;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rbIn;
        private System.Windows.Forms.RadioButton rbOut;
        private System.Windows.Forms.DateTimePicker dtpDateInOutRecord;
        private System.Windows.Forms.TextBox tbExplainInOutRecord;
        private System.Windows.Forms.TextBox tbItemInOutRecord;
        private System.Windows.Forms.TextBox tbRemarkInOutRecord;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox cbMe;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ComboBox cbCategoryInOutRecord;
    }
}