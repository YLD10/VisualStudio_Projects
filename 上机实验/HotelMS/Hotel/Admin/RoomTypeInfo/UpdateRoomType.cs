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
    public partial class UpdateRoomType : Form
    {
        public UpdateRoomType()
        {
            InitializeComponent();
        }

        private void UpdateRoomType_Load(object sender, EventArgs e)
        {
            tbRoomType.Text = Main_Admin.roomType.roomTypeID;
            nudPrice.Value = Main_Admin.roomType.roomTypePrice;
        }

        private void btConfirm_Click(object sender, EventArgs e)
        {
            Model.RoomType model = new Model.RoomType();
            model.roomTypeID = tbRoomType.Text.ToString();
            model.roomTypePrice = nudPrice.Value;

            if (new BLL.RoomType().Update(model))
            {
                MessageBox.Show("修改成功！", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ((Main_Admin)this.Owner).LoadData_RoomTypeInfo();
                Main_Admin.roomType = new Model.RoomType();
                this.Close();
            }
            else
            {
                MessageBox.Show("修改失败！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
