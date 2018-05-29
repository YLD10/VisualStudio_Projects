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
    public partial class UpdateTeacher : Form
    {
        public UpdateTeacher()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            tbID.Text = Maticsoft.Common.StaticDataClass.teacher.ID;
            tbTeaName.Text = Maticsoft.Common.StaticDataClass.teacher.teaName;
            if (Maticsoft.Common.StaticDataClass.teacher.teaSex == 1)
            {
                rbTeaSex1.Checked = true;
            }
            else
            {
                rbTeaSex0.Checked = true;
            }
            tbTeaTitle.Text = Maticsoft.Common.StaticDataClass.teacher.teaTitle;
        }

        private void btConfirm_Click(object sender, EventArgs e)
        {
            string ID = tbID.Text.Trim(),
                   teaName = tbTeaName.Text.Trim(),
                   teaTitle = tbTeaTitle.Text.Trim(),
                   passwd = tbPasswd.Text.Trim(),
                   confirmPasswd = tbConfirmPasswd.Text.Trim();
            int teaSex = rbTeaSex1.Checked ? 1 : 0;

            if (ID == "" || ID == null || teaName == "" || teaName == null || teaTitle == "" || teaTitle == null || passwd == "" || passwd == null || confirmPasswd == "" || confirmPasswd == null)
            {
                MessageBox.Show("不能有空！", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (passwd.Equals(confirmPasswd))
                {
                    Maticsoft.Model.Teachers teacher = new Maticsoft.Model.Teachers();
                    teacher.ID = ID;
                    teacher.teaName = teaName;
                    teacher.teaSex = teaSex;
                    teacher.teaTitle = teaTitle;
                    teacher.passwd = passwd;
                    Maticsoft.Common.StaticDataClass.teacher = teacher;

                    Main main = (Main)this.Owner;
                    if (main.UpdateTeacher())
                    {
                        MessageBox.Show("修改成功！", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        main.LoadData_Teacher();
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
