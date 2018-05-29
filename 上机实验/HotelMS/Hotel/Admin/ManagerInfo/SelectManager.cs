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
    public partial class SelectManager : Form
    {
        public SelectManager()
        {
            InitializeComponent();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btAlter_Click(object sender, EventArgs e)
        {
            AlterManager al = new Hotel.AlterManager();
            al.tbID.Text = Common.StaticClass.choose1;
            al.ShowDialog(this.Owner);
            this.Hide();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            DeleteManager del = new Hotel.DeleteManager();
            del.tbID.Text = Common.StaticClass.choose1;
            del.ShowDialog(this.Owner);
            this.Hide();
        }
    }
}
