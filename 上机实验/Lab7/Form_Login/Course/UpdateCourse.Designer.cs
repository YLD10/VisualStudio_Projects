namespace Form_SC
{
    partial class UpdateCourse
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
            this.btCancel = new System.Windows.Forms.Button();
            this.btConfirm = new System.Windows.Forms.Button();
            this.tbCouName = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labCouTime = new System.Windows.Forms.Label();
            this.labCouName = new System.Windows.Forms.Label();
            this.labID = new System.Windows.Forms.Label();
            this.nudCouPoint = new System.Windows.Forms.NumericUpDown();
            this.nudCouTime = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudCouPoint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCouTime)).BeginInit();
            this.SuspendLayout();
            // 
            // btCancel
            // 
            this.btCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(182, 275);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 7;
            this.btCancel.Text = "取消";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btConfirm
            // 
            this.btConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btConfirm.Location = new System.Drawing.Point(44, 275);
            this.btConfirm.Name = "btConfirm";
            this.btConfirm.Size = new System.Drawing.Size(75, 23);
            this.btConfirm.TabIndex = 6;
            this.btConfirm.Text = "确认";
            this.btConfirm.UseVisualStyleBackColor = true;
            this.btConfirm.Click += new System.EventHandler(this.btConfirm_Click);
            // 
            // tbCouName
            // 
            this.tbCouName.Location = new System.Drawing.Point(113, 99);
            this.tbCouName.Name = "tbCouName";
            this.tbCouName.Size = new System.Drawing.Size(130, 21);
            this.tbCouName.TabIndex = 2;
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(113, 40);
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(130, 21);
            this.tbID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "课程学分：";
            // 
            // labCouTime
            // 
            this.labCouTime.AutoSize = true;
            this.labCouTime.Location = new System.Drawing.Point(42, 157);
            this.labCouTime.Name = "labCouTime";
            this.labCouTime.Size = new System.Drawing.Size(65, 12);
            this.labCouTime.TabIndex = 0;
            this.labCouTime.Text = "课程学时：";
            // 
            // labCouName
            // 
            this.labCouName.AutoSize = true;
            this.labCouName.Location = new System.Drawing.Point(42, 102);
            this.labCouName.Name = "labCouName";
            this.labCouName.Size = new System.Drawing.Size(65, 12);
            this.labCouName.TabIndex = 0;
            this.labCouName.Text = "课程名称：";
            // 
            // labID
            // 
            this.labID.AutoSize = true;
            this.labID.Location = new System.Drawing.Point(42, 43);
            this.labID.Name = "labID";
            this.labID.Size = new System.Drawing.Size(65, 12);
            this.labID.TabIndex = 0;
            this.labID.Text = "课 程 号：";
            // 
            // nudCouPoint
            // 
            this.nudCouPoint.DecimalPlaces = 1;
            this.nudCouPoint.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudCouPoint.Location = new System.Drawing.Point(113, 212);
            this.nudCouPoint.Name = "nudCouPoint";
            this.nudCouPoint.Size = new System.Drawing.Size(129, 21);
            this.nudCouPoint.TabIndex = 4;
            // 
            // nudCouTime
            // 
            this.nudCouTime.Location = new System.Drawing.Point(114, 155);
            this.nudCouTime.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudCouTime.Name = "nudCouTime";
            this.nudCouTime.Size = new System.Drawing.Size(129, 21);
            this.nudCouTime.TabIndex = 3;
            // 
            // UpdateCourse
            // 
            this.AcceptButton = this.btConfirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btCancel;
            this.ClientSize = new System.Drawing.Size(299, 339);
            this.Controls.Add(this.nudCouPoint);
            this.Controls.Add(this.nudCouTime);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btConfirm);
            this.Controls.Add(this.tbCouName);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labCouTime);
            this.Controls.Add(this.labCouName);
            this.Controls.Add(this.labID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "UpdateCourse";
            this.Text = "UpdateCourse";
            ((System.ComponentModel.ISupportInitialize)(this.nudCouPoint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCouTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btConfirm;
        private System.Windows.Forms.TextBox tbCouName;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labCouTime;
        private System.Windows.Forms.Label labCouName;
        private System.Windows.Forms.Label labID;
        private System.Windows.Forms.NumericUpDown nudCouPoint;
        private System.Windows.Forms.NumericUpDown nudCouTime;

    }
}