using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lab6
{
    public partial class Form_Lab6_Login : Form
    {
        public Form_Lab6_Login()
        {
            InitializeComponent();
        }

        private void btConfirmLogin_Click(object sender, EventArgs e)
        {
            if (tbUserNameLogin.Text != "" && tbPasswdLogin.Text != "")
            {
                string Name = tbUserNameLogin.Text;
                string passwd = tbPasswdLogin.Text;

                if (Name.Equals("admin") && passwd.Equals("123456"))
                {
                    MessageBox.Show("登录成功！", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("用户名或密码错误！", "信息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("不能有空！", "信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btCancelLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }


}
