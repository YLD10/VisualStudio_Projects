namespace _Lab6
{
    partial class Form_Lab6_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Lab6_Main));
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.SystemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddInOutPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QueryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BasicInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMain = new System.Windows.Forms.ToolStrip();
            this.tsbAddInOut = new System.Windows.Forms.ToolStripButton();
            this.tsbQuery = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbAddItem = new System.Windows.Forms.ToolStripButton();
            this.tsbDetail = new System.Windows.Forms.ToolStripButton();
            this.ssMain = new System.Windows.Forms.StatusStrip();
            this.sslReady = new System.Windows.Forms.ToolStripStatusLabel();
            this.sslBlank = new System.Windows.Forms.ToolStripStatusLabel();
            this.sslSelect = new System.Windows.Forms.ToolStripStatusLabel();
            this.msMain.SuspendLayout();
            this.tsMain.SuspendLayout();
            this.ssMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMain
            // 
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SystemToolStripMenuItem,
            this.InOutToolStripMenuItem,
            this.BasicInfoToolStripMenuItem,
            this.HelpToolStripMenuItem});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(784, 25);
            this.msMain.TabIndex = 1;
            // 
            // SystemToolStripMenuItem
            // 
            this.SystemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitToolStripMenuItem});
            this.SystemToolStripMenuItem.Name = "SystemToolStripMenuItem";
            this.SystemToolStripMenuItem.Size = new System.Drawing.Size(83, 21);
            this.SystemToolStripMenuItem.Text = "系统管理(&S)";
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.ExitToolStripMenuItem.Text = "退出(&X)";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // InOutToolStripMenuItem
            // 
            this.InOutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddInOutPToolStripMenuItem,
            this.QueryToolStripMenuItem});
            this.InOutToolStripMenuItem.Name = "InOutToolStripMenuItem";
            this.InOutToolStripMenuItem.Size = new System.Drawing.Size(83, 21);
            this.InOutToolStripMenuItem.Text = "收支管理(&E)";
            // 
            // AddInOutPToolStripMenuItem
            // 
            this.AddInOutPToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("AddInOutPToolStripMenuItem.Image")));
            this.AddInOutPToolStripMenuItem.Name = "AddInOutPToolStripMenuItem";
            this.AddInOutPToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.AddInOutPToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.AddInOutPToolStripMenuItem.Text = "添加收支(&P)";
            this.AddInOutPToolStripMenuItem.Click += new System.EventHandler(this.AddInOutPToolStripMenuItem_Click);
            // 
            // QueryToolStripMenuItem
            // 
            this.QueryToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("QueryToolStripMenuItem.Image")));
            this.QueryToolStripMenuItem.Name = "QueryToolStripMenuItem";
            this.QueryToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.QueryToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.QueryToolStripMenuItem.Text = "统计查询(&C)";
            this.QueryToolStripMenuItem.Click += new System.EventHandler(this.QueryToolStripMenuItem_Click);
            // 
            // BasicInfoToolStripMenuItem
            // 
            this.BasicInfoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddItemToolStripMenuItem,
            this.UserToolStripMenuItem});
            this.BasicInfoToolStripMenuItem.Name = "BasicInfoToolStripMenuItem";
            this.BasicInfoToolStripMenuItem.Size = new System.Drawing.Size(85, 21);
            this.BasicInfoToolStripMenuItem.Text = "基本资料(&D)";
            // 
            // AddItemToolStripMenuItem
            // 
            this.AddItemToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("AddItemToolStripMenuItem.Image")));
            this.AddItemToolStripMenuItem.Name = "AddItemToolStripMenuItem";
            this.AddItemToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.AddItemToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.AddItemToolStripMenuItem.Text = "添加收支项目(&I)";
            this.AddItemToolStripMenuItem.Click += new System.EventHandler(this.AddItemToolStripMenuItem_Click);
            // 
            // UserToolStripMenuItem
            // 
            this.UserToolStripMenuItem.Image = global::_Lab6.Properties.Resources.keysJPG;
            this.UserToolStripMenuItem.Name = "UserToolStripMenuItem";
            this.UserToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.UserToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.UserToolStripMenuItem.Text = "用户管理(&U)";
            this.UserToolStripMenuItem.Click += new System.EventHandler(this.QueryToolStripMenuItem_Click);
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutToolStripMenuItem});
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(61, 21);
            this.HelpToolStripMenuItem.Text = "帮助(&H)";
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("AboutToolStripMenuItem.Image")));
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.AboutToolStripMenuItem.Text = "关于(&A)";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // tsMain
            // 
            this.tsMain.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAddInOut,
            this.tsbQuery,
            this.toolStripSeparator1,
            this.tsbAddItem,
            this.tsbDetail});
            this.tsMain.Location = new System.Drawing.Point(0, 25);
            this.tsMain.Name = "tsMain";
            this.tsMain.Size = new System.Drawing.Size(784, 39);
            this.tsMain.TabIndex = 3;
            // 
            // tsbAddInOut
            // 
            this.tsbAddInOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAddInOut.Image = ((System.Drawing.Image)(resources.GetObject("tsbAddInOut.Image")));
            this.tsbAddInOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddInOut.Name = "tsbAddInOut";
            this.tsbAddInOut.Size = new System.Drawing.Size(36, 36);
            this.tsbAddInOut.Text = "添加收支";
            this.tsbAddInOut.Click += new System.EventHandler(this.AddInOutPToolStripMenuItem_Click);
            // 
            // tsbQuery
            // 
            this.tsbQuery.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbQuery.Image = ((System.Drawing.Image)(resources.GetObject("tsbQuery.Image")));
            this.tsbQuery.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbQuery.Name = "tsbQuery";
            this.tsbQuery.Size = new System.Drawing.Size(36, 36);
            this.tsbQuery.Text = "统计查询";
            this.tsbQuery.Click += new System.EventHandler(this.QueryToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // tsbAddItem
            // 
            this.tsbAddItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAddItem.Image = ((System.Drawing.Image)(resources.GetObject("tsbAddItem.Image")));
            this.tsbAddItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddItem.Name = "tsbAddItem";
            this.tsbAddItem.Size = new System.Drawing.Size(36, 36);
            this.tsbAddItem.Text = "添加收支项目";
            this.tsbAddItem.Click += new System.EventHandler(this.AddItemToolStripMenuItem_Click);
            // 
            // tsbDetail
            // 
            this.tsbDetail.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDetail.Image = global::_Lab6.Properties.Resources.keysJPG;
            this.tsbDetail.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDetail.Name = "tsbDetail";
            this.tsbDetail.Size = new System.Drawing.Size(36, 36);
            this.tsbDetail.Text = "用户管理";
            this.tsbDetail.Click += new System.EventHandler(this.QueryToolStripMenuItem_Click);
            // 
            // ssMain
            // 
            this.ssMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sslReady,
            this.sslBlank,
            this.sslSelect});
            this.ssMain.Location = new System.Drawing.Point(0, 540);
            this.ssMain.Name = "ssMain";
            this.ssMain.Size = new System.Drawing.Size(784, 22);
            this.ssMain.TabIndex = 4;
            // 
            // sslReady
            // 
            this.sslReady.Image = global::_Lab6.Properties.Resources.bulbPNG;
            this.sslReady.Name = "sslReady";
            this.sslReady.Size = new System.Drawing.Size(48, 17);
            this.sslReady.Text = "就绪";
            // 
            // sslBlank
            // 
            this.sslBlank.Name = "sslBlank";
            this.sslBlank.Size = new System.Drawing.Size(160, 17);
            this.sslBlank.Text = "                                      ";
            // 
            // sslSelect
            // 
            this.sslSelect.Name = "sslSelect";
            this.sslSelect.Size = new System.Drawing.Size(92, 17);
            this.sslSelect.Text = "请选择一个操作";
            // 
            // Form_Lab6_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.ssMain);
            this.Controls.Add(this.tsMain);
            this.Controls.Add(this.msMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msMain;
            this.Name = "Form_Lab6_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "个人理财";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Lab6_Main_FormClosed);
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.tsMain.ResumeLayout(false);
            this.tsMain.PerformLayout();
            this.ssMain.ResumeLayout(false);
            this.ssMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem SystemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem InOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddInOutPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem QueryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BasicInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.ToolStrip tsMain;
        private System.Windows.Forms.ToolStripButton tsbAddInOut;
        private System.Windows.Forms.ToolStripButton tsbQuery;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbAddItem;
        private System.Windows.Forms.ToolStripButton tsbDetail;
        private System.Windows.Forms.StatusStrip ssMain;
        private System.Windows.Forms.ToolStripStatusLabel sslReady;
        private System.Windows.Forms.ToolStripStatusLabel sslBlank;
        private System.Windows.Forms.ToolStripStatusLabel sslSelect;
    }
}