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
        public static Model.RoomType roomType = new Model.RoomType();
        public static DataSet dsRoomType = new DataSet();

        public void LoadData_RoomTypeInfo()
        {
            roomType = new Model.RoomType();
            dsRoomType = new BLL.RoomType().GetListRoomType("");

            dgvRoomType.DataSource = dsRoomType.Tables["ds"];
            int columnNumber = dgvRoomType.ColumnCount;
            foreach (DataGridViewColumn col in dgvRoomType.Columns)
            {
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
                col.FillWeight = 100 / columnNumber;
            }
            dgvRoomType.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvRoomType.AllowUserToAddRows = false;
            dgvRoomType.RowHeadersVisible = false;
            dgvRoomType.ReadOnly = true;
        }

        private void dgvRoomType_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                roomType.roomTypeID = dgv.Rows[e.RowIndex].Cells[0].Value.ToString();
                string priceString = dgv.Rows[e.RowIndex].Cells[1].Value.ToString();
                roomType.roomTypePrice = decimal.Parse(priceString.Remove(priceString.Length-1));
            }
            else
            {
                roomType = new Model.RoomType();
                if (sortOrder == 0)
                {
                    dgv.Sort(dgv.Columns[e.ColumnIndex], ListSortDirection.Descending);
                    sortOrder++;
                }
                else
                {
                    dgv.Sort(dgv.Columns[e.ColumnIndex], ListSortDirection.Ascending);
                    sortOrder--;
                }
            }
        }

        private void btAddRoomType_Click(object sender, EventArgs e)
        {
            new AddRoomType().ShowDialog(this);
        }

        private void btUpdateRoomType_Click(object sender, EventArgs e)
        {
            if (roomType.roomTypeID == "" || roomType.roomTypeID == null)
            {
                MessageBox.Show("请先选择一行记录！", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } 
            else
            {
                new UpdateRoomType().ShowDialog(this);
            }
        }
    }
}
