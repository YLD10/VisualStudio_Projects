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
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            rbStuSex1.Checked = true;
            tbID.Text = "";
            tbStuName.Text = "";
            tbStuCollege.Text = "";
            tbStuMajor.Text = "";
            tbStuClass.Text = "";
            tbPasswd.Text = "";
            tbConfirmPasswd.Text = "";
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
                    if (new Maticsoft.BLL.Students().Exists(ID))
                    {
                        MessageBox.Show("学号已存在！", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
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
                        if (main.AddStudent())
                        {
                            MessageBox.Show("添加成功！", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            main.LoadData_Student();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("添加失败！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
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
