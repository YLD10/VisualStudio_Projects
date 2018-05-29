namespace _Lab6
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Lab6_InOutRecord));
            this.labTypeInOutRecord = new System.Windows.Forms.Label();
            this.labCateGoryInOutRecord = new System.Windows.Forms.Label();
            this.labItemInOutRecord = new System.Windows.Forms.Label();
            this.labRemarkInOutRecord = new System.Windows.Forms.Label();
            this.labDateInOutRecord = new System.Windows.Forms.Label();
            this.labExplainInOutRecord = new System.Windows.Forms.Label();
            this.labPersonInOutRecord = new System.Windows.Forms.Label();
            this.labMoneyInOutRecord = new System.Windows.Forms.Label();
            this.rbIn = new System.Windows.Forms.RadioButton();
            this.rbOut = new System.Windows.Forms.RadioButton();
            this.dtpDateInOutRecord = new System.Windows.Forms.DateTimePicker();
            this.tbExplainInOutRecord = new System.Windows.Forms.TextBox();
            this.tbRemarkInOutRecord = new System.Windows.Forms.TextBox();
            this.btSaveInOutRecord = new System.Windows.Forms.Button();
            this.btCancelInOutRecord = new System.Windows.Forms.Button();
            this.cbMeInOutRecord = new System.Windows.Forms.CheckBox();
            this.cbFamilyInOutRecord = new System.Windows.Forms.CheckBox();
            this.cbRelativeInOutRecord = new System.Windows.Forms.CheckBox();
            this.cbFriendInOutRecord = new System.Windows.Forms.CheckBox();
            this.cbColleagueInOutRecord = new System.Windows.Forms.CheckBox();
            this.cbOtherInOutRecord = new System.Windows.Forms.CheckBox();
            this.nudMoneyInOutRecord = new System.Windows.Forms.NumericUpDown();
            this.cboCategoryInOutRecord = new System.Windows.Forms.ComboBox();
            this.lbItemInOutRecord = new System.Windows.Forms.ListBox();
            this.labRollInOutRecord = new System.Windows.Forms.Label();
            this.timerRollInOutRecord = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nudMoneyInOutRecord)).BeginInit();
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
            // labMoneyInOutRecord
            // 
            this.labMoneyInOutRecord.AutoSize = true;
            this.labMoneyInOutRecord.Location = new System.Drawing.Point(322, 168);
            this.labMoneyInOutRecord.Name = "labMoneyInOutRecord";
            this.labMoneyInOutRecord.Size = new System.Drawing.Size(47, 12);
            this.labMoneyInOutRecord.TabIndex = 0;
            this.labMoneyInOutRecord.Text = "金 额：";
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
            this.dtpDateInOutRecord.MaxDate = new System.DateTime(2017, 5, 28, 16, 54, 26, 0);
            this.dtpDateInOutRecord.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpDateInOutRecord.Name = "dtpDateInOutRecord";
            this.dtpDateInOutRecord.Size = new System.Drawing.Size(200, 21);
            this.dtpDateInOutRecord.TabIndex = 2;
            this.dtpDateInOutRecord.Value = new System.DateTime(2017, 5, 28, 0, 0, 0, 0);
            // 
            // tbExplainInOutRecord
            // 
            this.tbExplainInOutRecord.Location = new System.Drawing.Point(375, 55);
            this.tbExplainInOutRecord.Name = "tbExplainInOutRecord";
            this.tbExplainInOutRecord.Size = new System.Drawing.Size(200, 21);
            this.tbExplainInOutRecord.TabIndex = 4;
            // 
            // tbRemarkInOutRecord
            // 
            this.tbRemarkInOutRecord.Location = new System.Drawing.Point(125, 193);
            this.tbRemarkInOutRecord.Multiline = true;
            this.tbRemarkInOutRecord.Name = "tbRemarkInOutRecord";
            this.tbRemarkInOutRecord.Size = new System.Drawing.Size(450, 136);
            this.tbRemarkInOutRecord.TabIndex = 8;
            // 
            // btSaveInOutRecord
            // 
            this.btSaveInOutRecord.Location = new System.Drawing.Point(191, 353);
            this.btSaveInOutRecord.Name = "btSaveInOutRecord";
            this.btSaveInOutRecord.Size = new System.Drawing.Size(75, 23);
            this.btSaveInOutRecord.TabIndex = 9;
            this.btSaveInOutRecord.Text = "保存(&S)";
            this.btSaveInOutRecord.UseVisualStyleBackColor = true;
            this.btSaveInOutRecord.Click += new System.EventHandler(this.btSaveInOutRecord_Click);
            // 
            // btCancelInOutRecord
            // 
            this.btCancelInOutRecord.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancelInOutRecord.Location = new System.Drawing.Point(375, 352);
            this.btCancelInOutRecord.Name = "btCancelInOutRecord";
            this.btCancelInOutRecord.Size = new System.Drawing.Size(75, 23);
            this.btCancelInOutRecord.TabIndex = 10;
            this.btCancelInOutRecord.Text = "取消(&C)";
            this.btCancelInOutRecord.UseVisualStyleBackColor = true;
            this.btCancelInOutRecord.Click += new System.EventHandler(this.btCancelInOutRecord_Click);
            // 
            // cbMeInOutRecord
            // 
            this.cbMeInOutRecord.AutoSize = true;
            this.cbMeInOutRecord.Location = new System.Drawing.Point(375, 100);
            this.cbMeInOutRecord.Name = "cbMeInOutRecord";
            this.cbMeInOutRecord.Size = new System.Drawing.Size(36, 16);
            this.cbMeInOutRecord.TabIndex = 6;
            this.cbMeInOutRecord.Text = "我";
            this.cbMeInOutRecord.UseVisualStyleBackColor = true;
            // 
            // cbFamilyInOutRecord
            // 
            this.cbFamilyInOutRecord.AutoSize = true;
            this.cbFamilyInOutRecord.Location = new System.Drawing.Point(431, 99);
            this.cbFamilyInOutRecord.Name = "cbFamilyInOutRecord";
            this.cbFamilyInOutRecord.Size = new System.Drawing.Size(48, 16);
            this.cbFamilyInOutRecord.TabIndex = 6;
            this.cbFamilyInOutRecord.Text = "家人";
            this.cbFamilyInOutRecord.UseVisualStyleBackColor = true;
            // 
            // cbRelativeInOutRecord
            // 
            this.cbRelativeInOutRecord.AutoSize = true;
            this.cbRelativeInOutRecord.Location = new System.Drawing.Point(488, 99);
            this.cbRelativeInOutRecord.Name = "cbRelativeInOutRecord";
            this.cbRelativeInOutRecord.Size = new System.Drawing.Size(48, 16);
            this.cbRelativeInOutRecord.TabIndex = 6;
            this.cbRelativeInOutRecord.Text = "亲戚";
            this.cbRelativeInOutRecord.UseVisualStyleBackColor = true;
            // 
            // cbFriendInOutRecord
            // 
            this.cbFriendInOutRecord.AutoSize = true;
            this.cbFriendInOutRecord.Location = new System.Drawing.Point(375, 133);
            this.cbFriendInOutRecord.Name = "cbFriendInOutRecord";
            this.cbFriendInOutRecord.Size = new System.Drawing.Size(48, 16);
            this.cbFriendInOutRecord.TabIndex = 6;
            this.cbFriendInOutRecord.Text = "朋友";
            this.cbFriendInOutRecord.UseVisualStyleBackColor = true;
            // 
            // cbColleagueInOutRecord
            // 
            this.cbColleagueInOutRecord.AutoSize = true;
            this.cbColleagueInOutRecord.Location = new System.Drawing.Point(431, 134);
            this.cbColleagueInOutRecord.Name = "cbColleagueInOutRecord";
            this.cbColleagueInOutRecord.Size = new System.Drawing.Size(48, 16);
            this.cbColleagueInOutRecord.TabIndex = 6;
            this.cbColleagueInOutRecord.Text = "同事";
            this.cbColleagueInOutRecord.UseVisualStyleBackColor = true;
            // 
            // cbOtherInOutRecord
            // 
            this.cbOtherInOutRecord.AutoSize = true;
            this.cbOtherInOutRecord.Location = new System.Drawing.Point(488, 134);
            this.cbOtherInOutRecord.Name = "cbOtherInOutRecord";
            this.cbOtherInOutRecord.Size = new System.Drawing.Size(48, 16);
            this.cbOtherInOutRecord.TabIndex = 6;
            this.cbOtherInOutRecord.Text = "其他";
            this.cbOtherInOutRecord.UseVisualStyleBackColor = true;
            // 
            // nudMoneyInOutRecord
            // 
            this.nudMoneyInOutRecord.DecimalPlaces = 2;
            this.nudMoneyInOutRecord.Location = new System.Drawing.Point(375, 166);
            this.nudMoneyInOutRecord.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nudMoneyInOutRecord.Name = "nudMoneyInOutRecord";
            this.nudMoneyInOutRecord.Size = new System.Drawing.Size(200, 21);
            this.nudMoneyInOutRecord.TabIndex = 7;
            // 
            // cboCategoryInOutRecord
            // 
            this.cboCategoryInOutRecord.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboCategoryInOutRecord.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboCategoryInOutRecord.FormattingEnabled = true;
            this.cboCategoryInOutRecord.ItemHeight = 15;
            this.cboCategoryInOutRecord.Items.AddRange(new object[] {
            "生活费",
            "通讯费",
            "人情费",
            "饮食费",
            "住房费",
            "服饰费",
            "交通费",
            "医疗费"});
            this.cboCategoryInOutRecord.Location = new System.Drawing.Point(125, 55);
            this.cboCategoryInOutRecord.Name = "cboCategoryInOutRecord";
            this.cboCategoryInOutRecord.Size = new System.Drawing.Size(137, 21);
            this.cboCategoryInOutRecord.TabIndex = 3;
            this.cboCategoryInOutRecord.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cboCategoryInOutRecord_DrawItem);
            this.cboCategoryInOutRecord.SelectedIndexChanged += new System.EventHandler(this.cboCategoryInOutRecord_SelectedIndexChanged);
            // 
            // lbItemInOutRecord
            // 
            this.lbItemInOutRecord.ColumnWidth = 1;
            this.lbItemInOutRecord.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.lbItemInOutRecord.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbItemInOutRecord.FormattingEnabled = true;
            this.lbItemInOutRecord.ItemHeight = 16;
            this.lbItemInOutRecord.Location = new System.Drawing.Point(125, 92);
            this.lbItemInOutRecord.Name = "lbItemInOutRecord";
            this.lbItemInOutRecord.Size = new System.Drawing.Size(137, 88);
            this.lbItemInOutRecord.TabIndex = 5;
            this.lbItemInOutRecord.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lbItemInOutRecord_DrawItem);
            // 
            // labRollInOutRecord
            // 
            this.labRollInOutRecord.AutoSize = true;
            this.labRollInOutRecord.Location = new System.Drawing.Point(322, 381);
            this.labRollInOutRecord.Name = "labRollInOutRecord";
            this.labRollInOutRecord.Size = new System.Drawing.Size(185, 12);
            this.labRollInOutRecord.TabIndex = 11;
            this.labRollInOutRecord.Text = "勤俭节约是中华民族的传统美德！";
            // 
            // timerRollInOutRecord
            // 
            this.timerRollInOutRecord.Enabled = true;
            this.timerRollInOutRecord.Interval = 30;
            this.timerRollInOutRecord.Tick += new System.EventHandler(this.timerRollInOutRecord_Tick);
            // 
            // Form_Lab6_InOutRecord
            // 
            this.AcceptButton = this.btSaveInOutRecord;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btCancelInOutRecord;
            this.ClientSize = new System.Drawing.Size(646, 402);
            this.Controls.Add(this.labRollInOutRecord);
            this.Controls.Add(this.lbItemInOutRecord);
            this.Controls.Add(this.cboCategoryInOutRecord);
            this.Controls.Add(this.nudMoneyInOutRecord);
            this.Controls.Add(this.cbOtherInOutRecord);
            this.Controls.Add(this.cbRelativeInOutRecord);
            this.Controls.Add(this.cbColleagueInOutRecord);
            this.Controls.Add(this.cbFamilyInOutRecord);
            this.Controls.Add(this.cbFriendInOutRecord);
            this.Controls.Add(this.cbMeInOutRecord);
            this.Controls.Add(this.btCancelInOutRecord);
            this.Controls.Add(this.btSaveInOutRecord);
            this.Controls.Add(this.tbRemarkInOutRecord);
            this.Controls.Add(this.tbExplainInOutRecord);
            this.Controls.Add(this.dtpDateInOutRecord);
            this.Controls.Add(this.rbOut);
            this.Controls.Add(this.rbIn);
            this.Controls.Add(this.labRemarkInOutRecord);
            this.Controls.Add(this.labMoneyInOutRecord);
            this.Controls.Add(this.labPersonInOutRecord);
            this.Controls.Add(this.labItemInOutRecord);
            this.Controls.Add(this.labExplainInOutRecord);
            this.Controls.Add(this.labCateGoryInOutRecord);
            this.Controls.Add(this.labDateInOutRecord);
            this.Controls.Add(this.labTypeInOutRecord);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_Lab6_InOutRecord";
            this.Text = "收支情况记录";
            ((System.ComponentModel.ISupportInitialize)(this.nudMoneyInOutRecord)).EndInit();
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
        private System.Windows.Forms.Label labMoneyInOutRecord;
        private System.Windows.Forms.RadioButton rbIn;
        private System.Windows.Forms.RadioButton rbOut;
        private System.Windows.Forms.DateTimePicker dtpDateInOutRecord;
        private System.Windows.Forms.TextBox tbExplainInOutRecord;
        private System.Windows.Forms.TextBox tbRemarkInOutRecord;
        private System.Windows.Forms.Button btSaveInOutRecord;
        private System.Windows.Forms.Button btCancelInOutRecord;
        private System.Windows.Forms.CheckBox cbMeInOutRecord;
        private System.Windows.Forms.CheckBox cbFamilyInOutRecord;
        private System.Windows.Forms.CheckBox cbRelativeInOutRecord;
        private System.Windows.Forms.CheckBox cbFriendInOutRecord;
        private System.Windows.Forms.CheckBox cbColleagueInOutRecord;
        private System.Windows.Forms.CheckBox cbOtherInOutRecord;
        private System.Windows.Forms.NumericUpDown nudMoneyInOutRecord;
        private System.Windows.Forms.ComboBox cboCategoryInOutRecord;
        private System.Windows.Forms.ListBox lbItemInOutRecord;
        private System.Windows.Forms.Label labRollInOutRecord;
        private System.Windows.Forms.Timer timerRollInOutRecord;
    }
}