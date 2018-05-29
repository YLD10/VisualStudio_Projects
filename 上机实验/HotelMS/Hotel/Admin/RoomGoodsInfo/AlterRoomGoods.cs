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
    public partial class AlterRoomGoods : Form
    {
        int flag = 0;
        public AlterRoomGoods()
        {
            InitializeComponent();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btConfirm_Click(object sender, EventArgs e)
        {
            if (tbID.Text.Trim() == "" || tbRoomType.Text.Trim() == "")
            {
                MessageBox.Show("输入信息不完整！", "修改失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                flag = 1;
            }
            if (flag == 0)
            {
                if (tbRoomType.Text.Trim() == "双人间" || tbRoomType.Text.Trim() == "单人间" || tbRoomType.Text.Trim() == "套房")
                {
                    Maticsoft.BLL.Goods go = new BLL.Goods();
                    string str1 = string.Format("goodsID = '{0}'", tbID.Text.Trim());
                    Model.Goods gmodel = new Model.Goods();
                    if (go.GetRecordCount(str1) > 0)
                    {
                        gmodel.goodsID = tbID.Text.Trim();
                        gmodel.goodsName = tbName.Text.Trim();
                        gmodel.goodsPrice = Convert.ToDecimal(tbPrice.Text.Trim());
                        gmodel.roomTypeID = tbRoomType.Text.Trim();
                        if (go.Update(gmodel) == true)
                        {
                            MessageBox.Show("修改成功！");
                            ((Main_Admin)this.Owner).RoomGoodsLoad();
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("修改失败！");
                        }
                    }
                    else
                    {
                        MessageBox.Show("不存在此物品编号！", "修改失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("房型不存在！", "修改失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}
