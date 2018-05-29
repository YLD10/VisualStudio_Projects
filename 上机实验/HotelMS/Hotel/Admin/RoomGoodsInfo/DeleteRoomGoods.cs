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
    public partial class DeleteRoomGoods : Form
    {
        int flag = 0;
        public DeleteRoomGoods()
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
                MessageBox.Show("输入信息不完整！", "删除失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                flag = 1;
            }
            if (flag == 0)
            {
                if (tbRoomType.Text.Trim() == "双人间" || tbRoomType.Text.Trim() == "单人间" || tbRoomType.Text.Trim() == "套房")
                {
                    Maticsoft.BLL.Goods go = new BLL.Goods();
                    string str1 = string.Format("goodsID = '{0}'", tbID.Text.Trim());
                    string string1 = string.Format("{0}", tbID.Text.Trim());
                    string str2 = string.Format("{0}", tbRoomType.Text.Trim());
                    if (go.GetRecordCount(str1) > 0)
                    {
                        if (go.Delete(string1,str2) == true)
                        {
                            MessageBox.Show("删除成功！");
                            ((Main_Admin)this.Owner).RoomGoodsLoad();
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("删除失败！");
                        }
                    }
                    else
                    {
                        MessageBox.Show("不存在此物品编号！", "删除失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("房型不存在！", "删除失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            } 
        }
    }
}
