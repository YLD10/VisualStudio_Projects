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
    public partial class AddRoom : Form
    {
        public AddRoom()
        {
            InitializeComponent();
        }

        private void AddRoom_Load(object sender, EventArgs e)
        {
            combRoomType.DisplayMember = "房间类型";
            combRoomType.ValueMember = "房间类型";
            combRoomType.DataSource = Main_Admin.dsRoomType.Tables["ds"];
            combRoomType.SelectedIndex = 0;
        }

        private void CombRoomType(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            e.DrawFocusRectangle();
            e.Graphics.DrawString(((DataRowView)combRoomType.Items[e.Index]).Row[combRoomType.DisplayMember].ToString(), e.Font, new SolidBrush(e.ForeColor), e.Bounds, new System.Drawing.StringFormat());
        }

        private void btConfirm_Click(object sender, EventArgs e)
        {
            string floorNum = nudFloorNum.Value.ToString().Trim(),
                    roomID = nudRoomID.Value.ToString().Trim(),
                    roomType = combRoomType.SelectedValue.ToString();
            int intRoomID = Convert.ToInt32(nudRoomID.Value);

            if (floorNum == "" || floorNum == null || roomID == "" || roomID == null || roomType == "" || roomType == null)
            {
                MessageBox.Show("不能有空！", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (intRoomID < 10)
                {
                    roomID = "00" + roomID;
                } 
                else if (intRoomID < 100)
                {
                    roomID = "0" + roomID;
                }

                Model.Room model = new Model.Room();
                int flag = 0;

                if (new BLL.Room().Exists(floorNum,roomID))
                {
                    model = new BLL.Room().GetModel(floorNum,roomID);
                    if (model.roomAbandoned == 0)
                    {
                        model.roomAbandoned = 1;
                        if (new BLL.Room().Update(model))
                        {
                            flag = 1;
                        }
                    }
                    else
                    {
                        MessageBox.Show("房间已存在！", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                else
                {
                    model.floorNum = floorNum;
                    model.roomID = roomID;
                    model.roomTypeID = roomType;
                    model.liveState = 0;
                    model.cleanState = 1;
                    model.damageState = 1;
                    if (new BLL.Room().Add(model))
                    {
                        flag = 1;
                    }
                }

                if (flag == 1)
                {
                    MessageBox.Show("添加成功！", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ((Main_Admin)this.Owner).LoadData_RoomInfo();
                    Main_Admin.room = new Model.Room();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("添加失败！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
