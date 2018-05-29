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
    public partial class DeleteManager : Form
    {
        int flag = 0;
        public DeleteManager()
        {
            InitializeComponent();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btConfirm_Click(object sender, EventArgs e)
        {
            if (tbID.Text.Trim() == "")
            {
                MessageBox.Show("输入信息不完整！", "删除失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                flag = 1;
            }
            if (flag == 0)
            {
                if(tbID.Text.Trim() != "离职")
                {
                    Maticsoft.BLL.Manager man = new BLL.Manager();
                    string str1 = string.Format("manID = '{0}'", tbID.Text.Trim());
                    string string1 = string.Format("{0}", tbID.Text.Trim());
                    if (man.GetRecordCount(str1) > 0)
                    {
                        if (man.Delete(string1) == true)
                        {
                            MessageBox.Show("删除成功！");
                            this.DialogResult = DialogResult.OK;
                            ((Main_Admin)this.Owner).ManagerLoad();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("删除失败！");
                        }
                    }
                    else
                    {
                        MessageBox.Show("不存在此前台！", "删除失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("离职备份不可删除！", "删除失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                
            }
        }
    }
}
