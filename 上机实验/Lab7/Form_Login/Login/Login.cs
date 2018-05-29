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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            Init();
        }

        public void Init()
        {
            Maticsoft.Common.StaticDataClass.userType = "";
            combUserType.SelectedIndex = 0;
            tbUserName.Text = "";
            tbPasswd.Text = "";
        }

        private void CombUserType_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            e.DrawFocusRectangle();
            e.Graphics.DrawString(combUserType.Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor), e.Bounds, new System.Drawing.StringFormat());
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            string userName = tbUserName.Text.Trim(),
                   passwd = tbPasswd.Text.Trim(),
                   userType = combUserType.SelectedItem.ToString().Trim();
            if (userName == "" || userName == null || passwd == "" || passwd == null || userType == "" || userType == null)
            {
                MessageBox.Show("不能有空！", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int n = 0;

                switch (userType)
                {
                    case "管理员":
                        n = new Maticsoft.BLL.Administrators().GetRecordCount(String.Format("userName = '{0}' and passwd = '{1}'",userName,passwd));
                        break;
                    case "学生":
                        n = new Maticsoft.BLL.Students().GetRecordCount(String.Format("ID = '{0}' and passwd = '{1}'", userName, passwd));
                        Maticsoft.Common.StaticDataClass.loginStudentID = userName;
                        break;
                    case "教师":
                        n = new Maticsoft.BLL.Teachers().GetRecordCount(String.Format("ID = '{0}' and passwd = '{1}'", userName, passwd));
                        Maticsoft.Common.StaticDataClass.loginTeacherID = userName;
                        break;
                }

                if (n > 0)
                {
                    MessageBox.Show("登录成功！", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Maticsoft.Common.StaticDataClass.userType = userType;
                    this.Hide();
                    new Main().ShowDialog(this);
                }
                else
                {
                    MessageBox.Show("用户名或密码错误！", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
