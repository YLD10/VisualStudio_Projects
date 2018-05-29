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
    public partial class DeleteAdmin : Form
    {
        int flag = 0;
        public DeleteAdmin()
        {
            InitializeComponent();
        }

        private void btAdminCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btAdminConfirm_Click(object sender, EventArgs e)
        {
            if (tbAdminID.Text.Trim() == "" || tbAdminPasswd.Text.Trim() == "")
            {
                MessageBox.Show("输入信息不完整！", "删除失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                flag = 1;
            }

            if (flag == 0)
            {
                Maticsoft.BLL.Admin adm = new BLL.Admin();
                string string1 = string.Format("userID = '{0}' and passwd = '{1}'", tbAdminID.Text.Trim(), tbAdminPasswd.Text.Trim());
                string str2 = string.Format("{0}", tbAdminID.Text.Trim());
                if (adm.GetRecordCount(string1) > 0)
                {
                    if (adm.Delete(str2) == true)
                    {
                        MessageBox.Show("删除成功！");
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
                    MessageBox.Show("身份验证错误！", "删除出错", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}
