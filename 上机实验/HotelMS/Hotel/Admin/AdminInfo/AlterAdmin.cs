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
    public partial class AlterAdmin : Form
    {
        int flag = 0;
        public AlterAdmin()
        {
            InitializeComponent();
        }

        private void btAdminCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btAdminConfirm_Click(object sender, EventArgs e)
        {
            if (tbAdminID.Text.Trim() == "" || tbAdminProPasswd.Text.Trim() == "" || (tbAdminName.Text.Trim() == "" & tbAdminNewPasswd.Text.Trim() == ""))
            {
                MessageBox.Show("输入信息不完整！", "修改失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                flag = 1;
            }
            if (flag == 0)
            {
                Maticsoft.BLL.Admin adm = new BLL.Admin();
                string string1 = string.Format("userID = '{0}' and passwd = '{1}'", tbAdminID.Text.Trim(),tbAdminProPasswd.Text.Trim());
                if (adm.GetRecordCount(string1) == 1)
                {
                    Model.Admin adminmodel = new Model.Admin();
                    adminmodel.userID = tbAdminID.Text.Trim();
                    adminmodel.userName = tbAdminName.Text.Trim();
                    adminmodel.passwd = tbAdminNewPasswd.Text.Trim();
                    if (adm.Update(adminmodel) == true)
                    {
                        MessageBox.Show("修改成功！");
                        ((Main_Admin)this.Owner).dgvAdmin_Load();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("修改失败！");
                    }  
                }
                else
                {
                    MessageBox.Show("身份验证错误！", "修改出错", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}
