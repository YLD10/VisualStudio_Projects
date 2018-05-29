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
    public partial class SelectRoomGoods : Form
    {
        public SelectRoomGoods()
        {
            InitializeComponent();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btAlter_Click(object sender, EventArgs e)
        {
            AlterRoomGoods al = new Hotel.AlterRoomGoods();
            al.tbID.Text = Common.StaticClass.choose1;
            al.tbRoomType.Text = Common.StaticClass.choose2;
            al.ShowDialog(this.Owner);
            this.Hide();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            DeleteRoomGoods del = new Hotel.DeleteRoomGoods();
            del.tbID.Text = Common.StaticClass.choose1;
            del.tbRoomType.Text = Common.StaticClass.choose2;
            del.ShowDialog(this.Owner);
            this.Hide();
        }
    }
}
