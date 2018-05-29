namespace _Lab6
{
    partial class Form_Lab6_AddItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Lab6_AddItem));
            this.tcAddItem = new System.Windows.Forms.TabControl();
            this.tpAddItemInfo = new System.Windows.Forms.TabPage();
            this.btPreviewAddItem = new System.Windows.Forms.Button();
            this.gbItemCategoryAddItem = new System.Windows.Forms.GroupBox();
            this.cboCategoryAddItem = new System.Windows.Forms.ComboBox();
            this.labCategoryAddItem = new System.Windows.Forms.Label();
            this.rbOutAddItem = new System.Windows.Forms.RadioButton();
            this.rbInAddItem = new System.Windows.Forms.RadioButton();
            this.tbItemNameAddItem = new System.Windows.Forms.TextBox();
            this.labItemNameAddItem = new System.Windows.Forms.Label();
            this.tpConfirmInfo = new System.Windows.Forms.TabPage();
            this.btConfirmAddItem = new System.Windows.Forms.Button();
            this.tbManifestAddItem = new System.Windows.Forms.TextBox();
            this.tcAddItem.SuspendLayout();
            this.tpAddItemInfo.SuspendLayout();
            this.gbItemCategoryAddItem.SuspendLayout();
            this.tpConfirmInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcAddItem
            // 
            this.tcAddItem.Controls.Add(this.tpAddItemInfo);
            this.tcAddItem.Controls.Add(this.tpConfirmInfo);
            this.tcAddItem.Location = new System.Drawing.Point(12, 12);
            this.tcAddItem.Name = "tcAddItem";
            this.tcAddItem.SelectedIndex = 0;
            this.tcAddItem.Size = new System.Drawing.Size(296, 312);
            this.tcAddItem.TabIndex = 0;
            // 
            // tpAddItemInfo
            // 
            this.tpAddItemInfo.Controls.Add(this.btPreviewAddItem);
            this.tpAddItemInfo.Controls.Add(this.gbItemCategoryAddItem);
            this.tpAddItemInfo.Controls.Add(this.tbItemNameAddItem);
            this.tpAddItemInfo.Controls.Add(this.labItemNameAddItem);
            this.tpAddItemInfo.Location = new System.Drawing.Point(4, 22);
            this.tpAddItemInfo.Name = "tpAddItemInfo";
            this.tpAddItemInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpAddItemInfo.Size = new System.Drawing.Size(288, 286);
            this.tpAddItemInfo.TabIndex = 0;
            this.tpAddItemInfo.Text = "收支项目信息";
            this.tpAddItemInfo.UseVisualStyleBackColor = true;
            // 
            // btPreviewAddItem
            // 
            this.btPreviewAddItem.Location = new System.Drawing.Point(100, 235);
            this.btPreviewAddItem.Name = "btPreviewAddItem";
            this.btPreviewAddItem.Size = new System.Drawing.Size(75, 23);
            this.btPreviewAddItem.TabIndex = 4;
            this.btPreviewAddItem.Text = "预览(&V)";
            this.btPreviewAddItem.UseVisualStyleBackColor = true;
            this.btPreviewAddItem.Click += new System.EventHandler(this.btPreviewAddItem_Click);
            // 
            // gbItemCategoryAddItem
            // 
            this.gbItemCategoryAddItem.Controls.Add(this.cboCategoryAddItem);
            this.gbItemCategoryAddItem.Controls.Add(this.labCategoryAddItem);
            this.gbItemCategoryAddItem.Controls.Add(this.rbOutAddItem);
            this.gbItemCategoryAddItem.Controls.Add(this.rbInAddItem);
            this.gbItemCategoryAddItem.Location = new System.Drawing.Point(41, 87);
            this.gbItemCategoryAddItem.Name = "gbItemCategoryAddItem";
            this.gbItemCategoryAddItem.Size = new System.Drawing.Size(200, 122);
            this.gbItemCategoryAddItem.TabIndex = 2;
            this.gbItemCategoryAddItem.TabStop = false;
            this.gbItemCategoryAddItem.Text = "所属类别";
            // 
            // cboCategoryAddItem
            // 
            this.cboCategoryAddItem.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboCategoryAddItem.FormattingEnabled = true;
            this.cboCategoryAddItem.Items.AddRange(new object[] {
            "生活费",
            "通讯费",
            "人情费",
            "饮食费",
            "住房费",
            "服饰费",
            "交通费",
            "医疗费"});
            this.cboCategoryAddItem.Location = new System.Drawing.Point(59, 81);
            this.cboCategoryAddItem.Name = "cboCategoryAddItem";
            this.cboCategoryAddItem.Size = new System.Drawing.Size(121, 22);
            this.cboCategoryAddItem.TabIndex = 3;
            this.cboCategoryAddItem.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cboCategoryAddItem_DrawItem);
            // 
            // labCategoryAddItem
            // 
            this.labCategoryAddItem.AutoSize = true;
            this.labCategoryAddItem.Location = new System.Drawing.Point(12, 84);
            this.labCategoryAddItem.Name = "labCategoryAddItem";
            this.labCategoryAddItem.Size = new System.Drawing.Size(41, 12);
            this.labCategoryAddItem.TabIndex = 1;
            this.labCategoryAddItem.Text = "类别：";
            // 
            // rbOutAddItem
            // 
            this.rbOutAddItem.AutoSize = true;
            this.rbOutAddItem.Location = new System.Drawing.Point(115, 44);
            this.rbOutAddItem.Name = "rbOutAddItem";
            this.rbOutAddItem.Size = new System.Drawing.Size(47, 16);
            this.rbOutAddItem.TabIndex = 2;
            this.rbOutAddItem.TabStop = true;
            this.rbOutAddItem.Text = "支出";
            this.rbOutAddItem.UseVisualStyleBackColor = true;
            // 
            // rbInAddItem
            // 
            this.rbInAddItem.AutoSize = true;
            this.rbInAddItem.Location = new System.Drawing.Point(37, 44);
            this.rbInAddItem.Name = "rbInAddItem";
            this.rbInAddItem.Size = new System.Drawing.Size(47, 16);
            this.rbInAddItem.TabIndex = 2;
            this.rbInAddItem.TabStop = true;
            this.rbInAddItem.Text = "收入";
            this.rbInAddItem.UseVisualStyleBackColor = true;
            // 
            // tbItemNameAddItem
            // 
            this.tbItemNameAddItem.Location = new System.Drawing.Point(119, 33);
            this.tbItemNameAddItem.Name = "tbItemNameAddItem";
            this.tbItemNameAddItem.Size = new System.Drawing.Size(100, 21);
            this.tbItemNameAddItem.TabIndex = 1;
            // 
            // labItemNameAddItem
            // 
            this.labItemNameAddItem.AutoSize = true;
            this.labItemNameAddItem.Location = new System.Drawing.Point(48, 36);
            this.labItemNameAddItem.Name = "labItemNameAddItem";
            this.labItemNameAddItem.Size = new System.Drawing.Size(65, 12);
            this.labItemNameAddItem.TabIndex = 0;
            this.labItemNameAddItem.Text = "项目名称：";
            // 
            // tpConfirmInfo
            // 
            this.tpConfirmInfo.Controls.Add(this.btConfirmAddItem);
            this.tpConfirmInfo.Controls.Add(this.tbManifestAddItem);
            this.tpConfirmInfo.Location = new System.Drawing.Point(4, 22);
            this.tpConfirmInfo.Name = "tpConfirmInfo";
            this.tpConfirmInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpConfirmInfo.Size = new System.Drawing.Size(288, 286);
            this.tpConfirmInfo.TabIndex = 1;
            this.tpConfirmInfo.Text = "确认信息";
            this.tpConfirmInfo.UseVisualStyleBackColor = true;
            // 
            // btConfirmAddItem
            // 
            this.btConfirmAddItem.Location = new System.Drawing.Point(105, 231);
            this.btConfirmAddItem.Name = "btConfirmAddItem";
            this.btConfirmAddItem.Size = new System.Drawing.Size(75, 23);
            this.btConfirmAddItem.TabIndex = 1;
            this.btConfirmAddItem.Text = "确认(&Y)";
            this.btConfirmAddItem.UseVisualStyleBackColor = true;
            this.btConfirmAddItem.Click += new System.EventHandler(this.btConfirmAddItem_Click);
            // 
            // tbManifestAddItem
            // 
            this.tbManifestAddItem.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbManifestAddItem.Location = new System.Drawing.Point(30, 21);
            this.tbManifestAddItem.Multiline = true;
            this.tbManifestAddItem.Name = "tbManifestAddItem";
            this.tbManifestAddItem.ReadOnly = true;
            this.tbManifestAddItem.Size = new System.Drawing.Size(227, 178);
            this.tbManifestAddItem.TabIndex = 2;
            // 
            // Form_Lab6_AddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 336);
            this.Controls.Add(this.tcAddItem);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_Lab6_AddItem";
            this.Text = "添加收支项目";
            this.tcAddItem.ResumeLayout(false);
            this.tpAddItemInfo.ResumeLayout(false);
            this.tpAddItemInfo.PerformLayout();
            this.gbItemCategoryAddItem.ResumeLayout(false);
            this.gbItemCategoryAddItem.PerformLayout();
            this.tpConfirmInfo.ResumeLayout(false);
            this.tpConfirmInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcAddItem;
        private System.Windows.Forms.TabPage tpAddItemInfo;
        private System.Windows.Forms.TabPage tpConfirmInfo;
        private System.Windows.Forms.Button btConfirmAddItem;
        private System.Windows.Forms.TextBox tbManifestAddItem;
        private System.Windows.Forms.Button btPreviewAddItem;
        private System.Windows.Forms.GroupBox gbItemCategoryAddItem;
        private System.Windows.Forms.ComboBox cboCategoryAddItem;
        private System.Windows.Forms.Label labCategoryAddItem;
        private System.Windows.Forms.RadioButton rbOutAddItem;
        private System.Windows.Forms.RadioButton rbInAddItem;
        private System.Windows.Forms.TextBox tbItemNameAddItem;
        private System.Windows.Forms.Label labItemNameAddItem;
    }
}