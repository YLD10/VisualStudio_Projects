namespace Form_SC
{
    partial class AddCouTea
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
            this.tbTeaSex = new System.Windows.Forms.TextBox();
            this.tbTeaTitle = new System.Windows.Forms.TextBox();
            this.tbTeaName = new System.Windows.Forms.TextBox();
            this.labTeaSex = new System.Windows.Forms.Label();
            this.labTeaTitle = new System.Windows.Forms.Label();
            this.labTeaName = new System.Windows.Forms.Label();
            this.labID = new System.Windows.Forms.Label();
            this.combID = new System.Windows.Forms.ComboBox();
            this.btCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btConfirm
            // 
            this.btConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btConfirm.Location = new System.Drawing.Point(57, 212);
            this.btConfirm.Name = "btConfirm";
            this.btConfirm.Size = new System.Drawing.Size(75, 23);
            this.btConfirm.TabIndex = 5;
            this.btConfirm.Text = "确认";
            this.btConfirm.UseVisualStyleBackColor = true;
            this.btConfirm.Click += new System.EventHandler(this.btConfirm_Click);
            // 
            // tbTeaSex
            // 
            this.tbTeaSex.Location = new System.Drawing.Point(123, 122);
            this.tbTeaSex.Name = "tbTeaSex";
            this.tbTeaSex.ReadOnly = true;
            this.tbTeaSex.Size = new System.Drawing.Size(130, 21);
            this.tbTeaSex.TabIndex = 3;
            // 
            // tbTeaTitle
            // 
            this.tbTeaTitle.Location = new System.Drawing.Point(123, 161);
            this.tbTeaTitle.Name = "tbTeaTitle";
            this.tbTeaTitle.ReadOnly = true;
            this.tbTeaTitle.Size = new System.Drawing.Size(130, 21);
            this.tbTeaTitle.TabIndex = 4;
            // 
            // tbTeaName
            // 
            this.tbTeaName.Location = new System.Drawing.Point(123, 83);
            this.tbTeaName.Name = "tbTeaName";
            this.tbTeaName.ReadOnly = true;
            this.tbTeaName.Size = new System.Drawing.Size(130, 21);
            this.tbTeaName.TabIndex = 2;
            // 
            // labTeaSex
            // 
            this.labTeaSex.AutoSize = true;
            this.labTeaSex.Location = new System.Drawing.Point(64, 125);
            this.labTeaSex.Name = "labTeaSex";
            this.labTeaSex.Size = new System.Drawing.Size(53, 12);
            this.labTeaSex.TabIndex = 0;
            this.labTeaSex.Text = "性  别：";
            // 
            // labTeaTitle
            // 
            this.labTeaTitle.AutoSize = true;
            this.labTeaTitle.Location = new System.Drawing.Point(64, 164);
            this.labTeaTitle.Name = "labTeaTitle";
            this.labTeaTitle.Size = new System.Drawing.Size(53, 12);
            this.labTeaTitle.TabIndex = 0;
            this.labTeaTitle.Text = "职  称：";
            // 
            // labTeaName
            // 
            this.labTeaName.AutoSize = true;
            this.labTeaName.Location = new System.Drawing.Point(64, 86);
            this.labTeaName.Name = "labTeaName";
            this.labTeaName.Size = new System.Drawing.Size(53, 12);
            this.labTeaName.TabIndex = 0;
            this.labTeaName.Text = "姓  名：";
            // 
            // labID
            // 
            this.labID.AutoSize = true;
            this.labID.Location = new System.Drawing.Point(64, 45);
            this.labID.Name = "labID";
            this.labID.Size = new System.Drawing.Size(53, 12);
            this.labID.TabIndex = 0;
            this.labID.Text = "教工号：";
            // 
            // combID
            // 
            this.combID.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.combID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combID.FormattingEnabled = true;
            this.combID.ItemHeight = 18;
            this.combID.Location = new System.Drawing.Point(123, 42);
            this.combID.Name = "combID";
            this.combID.Size = new System.Drawing.Size(129, 24);
            this.combID.TabIndex = 1;
            this.combID.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.CombID_DrawItem);
            this.combID.SelectedIndexChanged += new System.EventHandler(this.combID_SelectedIndexChanged);
            // 
            // btCancel
            // 
            this.btCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(188, 212);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 5;
            this.btCancel.Text = "取消";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // AddCouTea
            // 
            this.AcceptButton = this.btConfirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btCancel;
            this.ClientSize = new System.Drawing.Size(317, 273);
            this.Controls.Add(this.combID);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btConfirm);
            this.Controls.Add(this.tbTeaSex);
            this.Controls.Add(this.tbTeaTitle);
            this.Controls.Add(this.tbTeaName);
            this.Controls.Add(this.labTeaSex);
            this.Controls.Add(this.labTeaTitle);
            this.Controls.Add(this.labTeaName);
            this.Controls.Add(this.labID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AddCouTea";
            this.Text = "AddCouTea";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btConfirm;
        private System.Windows.Forms.TextBox tbTeaSex;
        private System.Windows.Forms.TextBox tbTeaTitle;
        private System.Windows.Forms.TextBox tbTeaName;
        private System.Windows.Forms.Label labTeaSex;
        private System.Windows.Forms.Label labTeaTitle;
        private System.Windows.Forms.Label labTeaName;
        private System.Windows.Forms.Label labID;
        private System.Windows.Forms.ComboBox combID;
        private System.Windows.Forms.Button btCancel;
    }
}