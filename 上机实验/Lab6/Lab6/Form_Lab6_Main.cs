using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lab6
{
    public partial class Form_Lab6_Main : Form
    {
        public Form_Lab6_Main()
        {
            InitializeComponent();
            
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddInOutPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Lab6_InOutRecord inOutRecord = new Form_Lab6_InOutRecord();
            inOutRecord.MdiParent = this;
            inOutRecord.Show();
        }

        private void QueryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("然而并没有！","信息",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void AddItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Lab6_AddItem addItem = new Form_Lab6_AddItem();
            addItem.MdiParent = this;
            addItem.Show();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Lab6_AboutBox_Us aboutUs = new Form_Lab6_AboutBox_Us();
            aboutUs.MdiParent = this;
            aboutUs.Show();
        }

        private void Form_Lab6_Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form_Lab6_Login login = (Form_Lab6_Login)this.Owner;
            login.Dispose();
            login.Close();
        }
    }
}
