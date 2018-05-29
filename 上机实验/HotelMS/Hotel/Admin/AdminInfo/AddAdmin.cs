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
    public partial class AddAdmin : Form
    {
        int flag = 0;
        public AddAdmin()
        {
            InitializeComponent();
        }

        private void btAdminCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btAdminConfirm_Click(object sender, EventArgs e)
        {
            if (tbAdminID.Text.Trim() == "" || tbAdminName.Text.Trim() == "" || tbAdminPassword.Text.Trim() == "" || tbAdminConfirmPasswd.Text == "")
            {
                MessageBox.Show("输入信息不完整！", "添加失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                flag = 1;
            }
            if (flag == 0)
            {
                Maticsoft.BLL.Admin adm = new BLL.Admin();
                Model.Admin adminmodel = new Model.Admin();
                string str1 = string.Format("userID = '{0}'", tbAdminID.Text.Trim());
                if(adm.GetRecordCount(str1) > 0)
                {
                    MessageBox.Show("当前用户名已存在！", "添加失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (tbAdminPassword.Text.Trim().ToString().Length >= 6 && tbAdminPassword.Text.Trim().ToString().Length <= 10)
                    {
                        if (tbAdminPassword.Text.Trim() == tbAdminConfirmPasswd.Text.Trim())
                        {
                            adminmodel.userID = tbAdminID.Text.Trim();
                            adminmodel.userName = tbAdminName.Text.Trim();
                            adminmodel.passwd = tbAdminPassword.Text.Trim();
                            if (adm.Add(adminmodel) == true)
                            {
                                MessageBox.Show("添加成功！");
                                ((Main_Admin)this.Owner).dgvAdmin_Load();
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("添加失败！");
                            }
                        }
                        else
                        {
                            MessageBox.Show("两次密码不对应！", "添加失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else
                    {
                        MessageBox.Show("输入密码不合规范！", "添加失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                } 
            }
        }
    }
}
