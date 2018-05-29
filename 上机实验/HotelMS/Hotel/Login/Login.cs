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
    public partial class login : Form
    {
        private int errorTime;
        private string userName;
        private string passwd;
        private string ensureCode;
        public login()
        {
            errorTime = 3;
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {
            checkCode_Random();
            combox_power.Text = "管理员";
        }

        private void checkCode_Click(object sender, EventArgs e)
        {
            checkCode_Random();
        }

        private void but_ok_Click(object sender, EventArgs e)
        {
            userName = text_userName.Text.Trim();
            passwd = text_passwd.Text.Trim();
            ensureCode = text_ensureCode.Text.Trim();

            if (ensureCode == string.Empty || passwd == string.Empty || userName == string.Empty)
            {
                MessageBox.Show("请完善信息", "糟糕", MessageBoxButtons.OK, MessageBoxIcon.Error);
                form_Shake();
                checkCode_Random();

                if (ensureCode == string.Empty)
                {
                    text_ensureCode.Focus();
                }
                if (passwd == string.Empty)
                {
                    text_ensureCode.Text = string.Empty;
                    text_passwd.Focus();
                }
                if (userName == string.Empty)
                {
                    text_ensureCode.Text = string.Empty;
                    text_passwd.Text = string.Empty;
                    text_userName.Focus();
                }
            }
            else
            {
                if(text_ensureCode.Text == checkCode.Text)
                {
                    string strWhere = string.Empty,
                            name = "";
                    int count = 0;
                    if (combox_power.Text == "管理员")
                    {                        
                        BLL.Admin bllAdmin = new BLL.Admin();
                        strWhere = string.Format("userID = '{0}' and passwd = '{1}'", userName, passwd);
                        count = bllAdmin.GetRecordCount(strWhere);

                        name = new BLL.Admin().GetModel(userName).userName;
                    }
                    else
                    {
                        BLL.Manager bllManager = new BLL.Manager();
                        strWhere = string.Format("manID = '{0}' and passwd = '{1}'", userName, passwd);
                        count = bllManager.GetRecordCount(strWhere);

                        name = new BLL.Manager().GetModel(userName).manName;
                    }

                    if (count == 1)
                    {
                        MessageBox.Show("登录成功", "恭喜", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Common.StaticClass.userType = combox_power.Text.ToString();
                        Common.StaticClass.userName = name;
                        Common.StaticClass.userID = userName;

                        this.Hide();

                        new Main_Admin().ShowDialog(this);

                        text_passwd.Text = text_ensureCode.Text = string.Empty;
                        checkCode_Random();
                    }
                    else
                    {
                        errorTime -= 1;                        
                        if(errorTime > 0)
                        {
                            MessageBox.Show("用户名或密码错误,还有" + errorTime.ToString() + "次机会", "糟糕", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            checkCode_Random();
                            form_Shake();
                            
                            text_userName.Text = text_passwd.Text = text_ensureCode.Text = string.Empty;
                            text_userName.Focus();
                        }
                        else
                        {
                            MessageBox.Show("用户名或密码错误三次，请稍后登录", "糟糕", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.Close();
                        }                        
                    }
                }
                else
                {
                    MessageBox.Show("验证码不正确", "糟糕", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    checkCode_Random();
                    form_Shake();
                }
            }
        }

        private void but_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //自定义方法
        private void checkCode_Random() //随机产生验证码
        {
            Random random = new Random();
            int minV = 12345, maxV = 98765;
            checkCode.Text = random.Next(minV, maxV).ToString();
        }
        private void form_Shake()   //窗口抖动
        {
            Random random = new Random((int)DateTime.Now.Ticks);
            Point point = this.Location;
            for (int i = 0; i < 10; ++i)
            {
                this.Location = new Point(point.X + random.Next(8) - 4, point.Y + random.Next(8) - 4);
                System.Threading.Thread.Sleep(15);
                this.Location = point;
                System.Threading.Thread.Sleep(15);
            }
        }     
    }
}
