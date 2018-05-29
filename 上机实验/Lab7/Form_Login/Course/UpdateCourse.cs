﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Form_SC
{
    public partial class UpdateCourse : Form
    {
        public UpdateCourse()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            tbID.Text = Maticsoft.Common.StaticDataClass.course.ID;
            tbCouName.Text = Maticsoft.Common.StaticDataClass.course.couName;
            nudCouTime.Value = Maticsoft.Common.StaticDataClass.course.couTime;
            nudCouPoint.Value = Maticsoft.Common.StaticDataClass.course.couPoint;
        }

        private void btConfirm_Click(object sender, EventArgs e)
        {
            string ID = tbID.Text.Trim(),
                   couName = tbCouName.Text.Trim();
            decimal couTime = nudCouTime.Value,
                    couPoint = nudCouPoint.Value;

            if (couName == "" || couName == null || ID == "" || ID == null)
            {
                MessageBox.Show("不能有空！", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (couTime > 0 && couPoint > 0)
                {
                    Maticsoft.Model.Courses course = new Maticsoft.Model.Courses();
                    course.ID = ID;
                    course.couName = couName;
                    course.couTime = Convert.ToInt32(couTime);
                    course.couPoint = couPoint;
                    Maticsoft.Common.StaticDataClass.course = course;

                    Main main = (Main)this.Owner;
                    if (main.UpdateCourse())
                    {
                        MessageBox.Show("修改成功！", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        main.LoadData_Course();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("修改失败！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("学时和学分都应大于零！", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
