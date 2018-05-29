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
    public partial class UpdateStudent : Form
    {
        public UpdateStudent()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            if (Maticsoft.Common.StaticDataClass.student.stuSex == 1)
            {
                rbStuSex1.Checked = true;
            }
            else
            {
                rbStuSex0.Checked = true;
            }
            tbID.Text = Maticsoft.Common.StaticDataClass.student.ID;
            tbStuName.Text = Maticsoft.Common.StaticDataClass.student.stuName;
            tbStuCollege.Text = Maticsoft.Common.StaticDataClass.student.stuCollege;
            tbStuMajor.Text = Maticsoft.Common.StaticDataClass.student.stuMajor;
            tbStuClass.Text = Maticsoft.Common.StaticDataClass.student.stuClass;
        }

        private void btConfirm_Click(object sender, EventArgs e)
        {
            string ID = tbID.Text.Trim(),
                   stuName = tbStuName.Text.Trim(),
                   stuCollege = tbStuCollege.Text.Trim(),
                   stuMajor = tbStuMajor.Text.Trim(),
                   stuClass = tbStuClass.Text.Trim(),
                   passwd = tbPasswd.Text.Trim(),
                   confirmPasswd = tbConfirmPasswd.Text.Trim();
            int stuSex = rbStuSex1.Checked ? 1 : 0;

            if (stuName == "" || stuName == null || stuCollege == "" || stuCollege == null || stuMajor == "" || stuMajor == null || stuClass == "" || stuClass == null || passwd == "" || passwd == null || confirmPasswd == "" || confirmPasswd == null)
            {
                MessageBox.Show("不能有空！", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (passwd.Equals(confirmPasswd))
                {
                    Maticsoft.Model.Students student = new Maticsoft.Model.Students();
                    student.ID = ID;
                    student.stuName = stuName;
                    student.stuSex = stuSex;
                    student.stuCollege = stuCollege;
                    student.stuClass = stuClass;
                    student.stuMajor = stuMajor;
                    student.passwd = passwd;
                    Maticsoft.Common.StaticDataClass.student = student;

                    Main main = (Main)this.Owner;
                    if (main.UpdateStudent())
                    {
                        MessageBox.Show("修改成功！", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        main.LoadData_Student();
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
