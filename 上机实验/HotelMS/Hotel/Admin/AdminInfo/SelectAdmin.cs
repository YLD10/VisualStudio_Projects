using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Maticsoft.Hotel
{
    public partial class SelectAdmin : Form
    {
        public SelectAdmin()
        {
            InitializeComponent();
        }

        private void btAdminCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btAdminAlter_Click(object sender, EventArgs e)
        {
            AlterAdmin al = new Hotel.AlterAdmin();
            al.tbAdminID.Text = Common.StaticClass.choose1;
            al.tbAdminProPasswd.Text = Common.StaticClass.choose2;
            if (al.ShowDialog(this) == DialogResult.OK)
                this.DialogResult = DialogResult.OK;
            this.Hide();
        }

        private void btAdminDel_Click(object sender, EventArgs e)
        {
            DeleteAdmin del = new Hotel.DeleteAdmin();
            del.tbAdminID.Text = Common.StaticClass.choose1;
            del.tbAdminPasswd.Text = Common.StaticClass.choose2;
            if (del.ShowDialog(this) == DialogResult.OK)
                this.DialogResult = DialogResult.OK;
            this.Hide();
        }
    }
}
