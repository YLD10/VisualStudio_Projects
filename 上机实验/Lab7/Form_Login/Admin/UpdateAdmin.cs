using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Form_SC
{
    public partial class UpdateAdmin : Form
    {
        public UpdateAdmin()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            tbUserName.Text = Maticsoft.Common.StaticDataClass.admin.userName;
            tbPasswd.Text = "";
            tbConfirmPasswd.Text = "";
        }

        private void btConfirm_Click(object sender, EventArgs e)
        {
            string userName = tbUserName.Text.Trim(),
                   passwd = tbPasswd.Text.Trim(),
                   confirmPasswd = tbConfirmPasswd.Text.Trim();
            if (userName == "" || userName == null || passwd == "" || passwd == null || confirmPasswd == "" || confirmPasswd == null)
            {
                MessageBox.Show("不能有空！", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (passwd.Equals(confirmPasswd))
                {
                    Maticsoft.Common.StaticDataClass.admin.userName = userName;
                    Maticsoft.Common.StaticDataClass.admin.passwd = passwd;
                    Main main = (Main)this.Owner;
                    if (main.UpdateAdmin())
                    {
                        MessageBox.Show("修改成功！", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        main.LoadData_Admin();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("修改失败！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("两次密码不一致！", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
