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
        public static Model.Room room = new Model.Room();
        public static DataSet dsRoomInfo = new DataSet();

        public void LoadData_RoomInfo()
        {
            room = new Model.Room();
            dsRoomInfo = new BLL.Room().GetListRoomInfo("");

            dgvRoom.DataSource = dsRoomInfo.Tables["ds"];
            int columnNumber = dgvRoom.ColumnCount;
            foreach (DataGridViewColumn col in dgvRoom.Columns)
            {
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
                col.FillWeight = 100 / columnNumber;
            }
            dgvRoom.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvRoom.AllowUserToAddRows = false;
            dgvRoom.RowHeadersVisible = false;
            dgvRoom.ReadOnly = true;
        }

        private void dgvRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                room.floorNum = dgv.Rows[e.RowIndex].Cells[0].Value.ToString();
                room.roomID = dgv.Rows[e.RowIndex].Cells[1].Value.ToString();
                room.liveState = dgv.Rows[e.RowIndex].Cells[2].Value.ToString() == "已住" ? 1 : 0 ;
                room.cleanState = dgv.Rows[e.RowIndex].Cells[3].Value.ToString() == "已打扫" ? 1 : 0;
                room.damageState = dgv.Rows[e.RowIndex].Cells[4].Value.ToString() == "未损坏" ? 1 : 0;
                room.roomTypeID = dgv.Rows[e.RowIndex].Cells[5].Value.ToString();
                room.roomAbandoned = dgv.Rows[e.RowIndex].Cells[6].Value.ToString() == "未禁用" ? 1 : 0;
            }
            else
            {
                room = new Model.Room();
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

        private void RoomAbandonedRefesh(string floorNum, string roomNum)
        {
            room = new Model.Room();
            DataSet ds = new BLL.Room().GetListRoomInfo(String.Format(" floorNum = '{0}' and roomID = '{1}' ", floorNum, roomNum));

            dgvRoom.DataSource = ds.Tables["ds"];
            int columnNumber = dgvRoom.ColumnCount;
            foreach (DataGridViewColumn col in dgvRoom.Columns)
            {
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
                col.FillWeight = 100 / columnNumber;
            }
            dgvRoom.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvRoom.AllowUserToAddRows = false;
            dgvRoom.RowHeadersVisible = false;
            dgvRoom.ReadOnly = true;
        }

        private void btSearchRoom_Click(object sender, EventArgs e)
        {
            string floorNum = tbFloorNum.Text.Trim(),
                    roomNum = tbRoomNum.Text.Trim();

            if (floorNum == "" || floorNum == null || roomNum == "" || roomNum == null)
            {
                MessageBox.Show("不能有空！", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (new BLL.Room().Exists(floorNum,roomNum))
                {
                    RoomAbandonedRefesh(floorNum,roomNum);
                }
                else
                {
                    MessageBox.Show("查无此房间！", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btSeeAllRooms_Click(object sender, EventArgs e)
        {
            LoadData_RoomInfo();
        }

        private void btAddRoom_Click(object sender, EventArgs e)
        {
            new AddRoom().ShowDialog(this);
        }

        private void btAbandonedRoom_Click(object sender, EventArgs e)
        {
            if (room.floorNum == "" || room.floorNum == null)
            {
                MessageBox.Show("请先选择一行记录！", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } 
            else
            {
                room.roomAbandoned = room.roomAbandoned == 1 ? 0 : 1;

                if (new BLL.Room().Update(room))
                {
                    if (room.roomAbandoned == 1)
                    {
                        MessageBox.Show("解禁成功！", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (dgvRoom.RowCount > 1)
                        {
                            LoadData_RoomInfo();
                        }
                        else
                        {
                            RoomAbandonedRefesh(room.floorNum, room.roomID);
                        }
                    }
                    else
                    {
                        MessageBox.Show("禁用成功！", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (dgvRoom.RowCount > 1)
                        {
                            LoadData_RoomInfo();
                        }
                        else
                        {
                            RoomAbandonedRefesh(room.floorNum, room.roomID);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("修改失败！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
