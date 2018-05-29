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
    public partial class UpdateStuScore : Form
    {
        public UpdateStuScore()
        {
            InitializeComponent();
            Init();
        }

        public void Init()
        {
            DataRow dr= TeaStu.ds.Tables["ds"].Select("学号=" + TeaStu.stuID)[0];
            tbID.Text = dr[0].ToString();
            tbStuName.Text = dr[1].ToString();
            tbStuCollege.Text = dr[2].ToString();
            tbStuMajor.Text = dr[3].ToString();
            tbStuClass.Text = dr[4].ToString();
            if (dr[5] != null)
            {
                tbScore.Text = dr[5].ToString();
            }
            else
            {
                tbScore.Text = "";
            }
        }

        private void btConfirm_Click(object sender, EventArgs e)
        {
            string score = tbScore.Text.Trim();
            Maticsoft.Model.CS model = new Maticsoft.Model.CS();
            model.couID = TeaCou.couID;
            model.stuID = TeaStu.stuID;
            model.teaID = Maticsoft.Common.StaticDataClass.teacher.ID;

            if (score != "" && score != null)
            {
                decimal scoreF = decimal.Parse(score);
                if (scoreF >= 0 && scoreF <= 100)
                {
                    model.score = scoreF;
                }
                else
                {
                    MessageBox.Show("成绩应在 0 ~ 100 之间！", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                if (score == null)
                {
                    MessageBox.Show("成绩出错！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                model.score = null;
            }

            if (new Maticsoft.BLL.CS().Update(model))
            {
                MessageBox.Show("修改成功！", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ((TeaStu)this.Owner).LoadData_TS();
                this.Close();
            }
            else
            {
                MessageBox.Show("修改失败！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
