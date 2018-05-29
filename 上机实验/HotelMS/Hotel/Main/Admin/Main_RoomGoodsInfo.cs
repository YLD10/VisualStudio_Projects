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
    public partial class Main_Admin : Form
    {
        private void btSearchRoomGoods_Click(object sender, EventArgs e)
        {
            string information = "";
            switch (combRoomGoods.Text.Trim())
            {
                case "编号":
                    information = "goodsID";
                    break;
                case "名称":
                    information = "goodsName";
                    break;
                case "价格":
                    information = "goodsPrice";
                    break;
                default:
                    break;
            }
            Maticsoft.BLL.Goods go = new BLL.Goods();
            string string1 = string.Format("{0} = '{1}'", information, tbRoomGoods.Text.Trim());
            DataSet ds = new DataSet();
            ds = go.GetList(string1);
            dgvRoomGoods.DataSource = ds.Tables[0];
            ds.Tables[0].Columns["goodsId"].ColumnName = "编号";
            ds.Tables[0].Columns["goodsName"].ColumnName = "名称";
            ds.Tables[0].Columns["goodsPrice"].ColumnName = "价格";
            ds.Tables[0].Columns["roomTypeID"].ColumnName = "房型";
            dgvRoomGoods.AllowUserToAddRows = false;
            dgvRoomGoods.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btSeeAllRoomGoods_Click(object sender, EventArgs e)
        {
            RoomGoodsLoad();
        }

        public void RoomGoodsLoad()
        {
            Maticsoft.BLL.Goods go = new BLL.Goods();
            DataSet ds = new DataSet();
            ds = go.GetList("");
            dgvRoomGoods.DataSource = ds.Tables[0];
            ds.Tables[0].Columns["goodsId"].ColumnName = "编号";
            ds.Tables[0].Columns["goodsName"].ColumnName = "名称";
            ds.Tables[0].Columns["goodsPrice"].ColumnName = "价格";
            ds.Tables[0].Columns["roomTypeID"].ColumnName = "房型";
            dgvRoomGoods.AllowUserToAddRows = false;
            dgvRoomGoods.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void btAddRoomGoods_Click(object sender, EventArgs e)
        {
            AddRoomGoods ad = new Hotel.AddRoomGoods();
            ad.ShowDialog(this);
        }

        private void btUpdateRoomGoods_Click(object sender, EventArgs e)
        {
            AlterRoomGoods alt = new Hotel.AlterRoomGoods();
            alt.ShowDialog(this);
        }

        private void btDeleteRoomGoods_Click(object sender, EventArgs e)
        {
            DeleteRoomGoods del = new Hotel.DeleteRoomGoods();
            del.ShowDialog(this);
        }

        private void dgvRoomGoods_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Common.StaticClass.choose1 = dgvRoomGoods.SelectedRows[0].Cells[0].Value.ToString();
            Common.StaticClass.choose2 = dgvRoomGoods.SelectedRows[0].Cells[3].Value.ToString();
            SelectRoomGoods sel = new Hotel.SelectRoomGoods();
            sel.ShowDialog(this);
        }
    }
}
