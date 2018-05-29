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
    public partial class AddRoomType : Form
    {
        public AddRoomType()
        {
            InitializeComponent();
        }

        private void AddRoomType_Load(object sender, EventArgs e)
        {
            tbRoomType.Text = "";
        }

        private void btConfirm_Click(object sender, EventArgs e)
        {
            string roomType = tbRoomType.Text.ToString().Trim();
            decimal price = Convert.ToDecimal(nudPrice.Value);

            if (roomType == "" || roomType == null)
            {
                MessageBox.Show("不能有空！", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (new BLL.RoomType().Exists(roomType))
                {
                    MessageBox.Show("房间已存在！", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                } 
                else
                {
                    Model.RoomType model = new Model.RoomType();
                    model.roomTypeID = roomType;
                    model.roomTypePrice = price;
                    if (new BLL.RoomType().Add(model))
                    {
                        MessageBox.Show("添加成功！", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ((Main_Admin)this.Owner).LoadData_RoomTypeInfo();
                        Main_Admin.roomType = new Model.RoomType();
                        this.Close();
                    } 
                    else
                    {
                        MessageBox.Show("添加失败！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
