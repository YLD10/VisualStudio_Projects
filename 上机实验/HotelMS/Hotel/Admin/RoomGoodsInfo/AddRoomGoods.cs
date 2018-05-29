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
    public partial class AddRoomGoods : Form
    {
        int flag = 0;
        public AddRoomGoods()
        {
            InitializeComponent();
        }

        private void tbRoomType_TextChanged(object sender, EventArgs e)
        {

        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btConfirm_Click(object sender, EventArgs e)
        {
            if (tbID.Text.Trim() == "" || tbName.Text.Trim() == "" || tbPrice.Text.Trim() == "" || tbRoomType.Text.Trim() == "")
            {
                MessageBox.Show("输入信息不完整！", "添加失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                flag = 1;
            }
            if (flag == 0)
            {
                if (tbRoomType.Text.Trim() == "单人间" || tbRoomType.Text.Trim() == "双人间" || tbRoomType.Text.Trim() == "套房")
                {
                    Maticsoft.BLL.Goods go = new BLL.Goods();
                    Model.Goods gmodel = new Model.Goods();
                    string str1 = string.Format("goodsID = '{0}' and roomTypeID = '{1}'", tbID.Text.Trim(),tbRoomType.Text.Trim());
                    if (go.GetRecordCount(str1) > 0)
                    {
                        MessageBox.Show("当前物品已存在！", "添加失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        gmodel.goodsID = tbID.Text.Trim();
                        gmodel.goodsName = tbName.Text.Trim();
                        gmodel.goodsPrice = Convert.ToDecimal(tbPrice.Text.Trim());
                        gmodel.roomTypeID = tbRoomType.Text.Trim();
                        if (go.Add(gmodel) == true)
                        {
                            MessageBox.Show("添加成功！");
                            ((Main_Admin)this.Owner).RoomGoodsLoad();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("添加失败！");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("添加房型不存在！", "添加失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                
            }
        }
    }
}
