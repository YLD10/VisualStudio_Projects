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
    public partial class Form_Lab6_InOutRecord : Form
    {
        public Form_Lab6_InOutRecord()
        {
            InitializeComponent();
            cboCategoryInOutRecord.SelectedIndex = 0;
            rbIn.Checked = true;
            cbMeInOutRecord.Checked = true;
        }

        private void btSaveInOutRecord_Click(object sender, EventArgs e)
        {
            string typeInOut = "";
            DateTime dateInOut = dtpDateInOutRecord.Value;
            string categoryInOut = cboCategoryInOutRecord.SelectedItem.ToString();
            string explainInOut = tbExplainInOutRecord.Text.Trim();
            string itemInOut = lbItemInOutRecord.SelectedItem.ToString();
            string persionInOut = "";
            decimal moneyInOut = nudMoneyInOutRecord.Value;
            string remarkInOut = labRemarkInOutRecord.Text.Trim();
            Boolean flag = true;

            if (rbIn.Checked) typeInOut = rbIn.Text;
            else typeInOut = rbOut.Text;

            if (cbMeInOutRecord.Checked) persionInOut += cbMeInOutRecord.Text;
            if (cbFamilyInOutRecord.Checked) persionInOut += "," + cbFamilyInOutRecord.Text;
            if (cbRelativeInOutRecord.Checked) persionInOut += "," + cbRelativeInOutRecord.Text;
            if (cbFriendInOutRecord.Checked) persionInOut += "," + cbFriendInOutRecord.Text;
            if (cbColleagueInOutRecord.Checked) persionInOut += "," + cbColleagueInOutRecord.Text;
            if (cbOtherInOutRecord.Checked) persionInOut += "," + cbOtherInOutRecord.Text;

            if (persionInOut == "")
            {
                flag = false;
                MessageBox.Show("收支人不能为空！","警告",MessageBoxButtons.OK,MessageBoxIcon.Warning);

            }else if (moneyInOut <= 0)
            {
                flag = false;
                MessageBox.Show("金额需大于零！", "警告", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

            if (flag)
            {
                MessageBox.Show("保存成功！","信息",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void btCancelInOutRecord_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboCategoryInOutRecord_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            e.DrawFocusRectangle();
            StringFormat strFmt = new System.Drawing.StringFormat();
            e.Graphics.DrawString(cboCategoryInOutRecord.Items[e.Index].ToString(),e.Font,new SolidBrush(e.ForeColor),e.Bounds,strFmt);
        }

        private void lbItemInOutRecord_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            e.DrawFocusRectangle();
            StringFormat strFmt = new System.Drawing.StringFormat();
            e.Graphics.DrawString(lbItemInOutRecord.Items[e.Index].ToString(),e.Font,new SolidBrush(e.ForeColor),e.Bounds,strFmt);
        }

        private void cboCategoryInOutRecord_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbItemInOutRecord.Items.Clear();
            switch (cboCategoryInOutRecord.SelectedItem.ToString())
            {
                case "生活费":
                    lbItemInOutRecord.Items.Add("娱乐");
                    lbItemInOutRecord.Items.Add("书籍");
                    lbItemInOutRecord.Items.Add("美容");
                    lbItemInOutRecord.Items.Add("旅游");
                    lbItemInOutRecord.Items.Add("学习");
                    break;
                case "通讯费":
                    lbItemInOutRecord.Items.Add("短信");
                    lbItemInOutRecord.Items.Add("彩信");
                    lbItemInOutRecord.Items.Add("市话费");
                    lbItemInOutRecord.Items.Add("长途费");
                    lbItemInOutRecord.Items.Add("漫游费");
                    break;
                case "人情费":
                    lbItemInOutRecord.Items.Add("请客吃饭");
                    lbItemInOutRecord.Items.Add("压岁钱");
                    lbItemInOutRecord.Items.Add("生日礼物");
                    lbItemInOutRecord.Items.Add("结婚随礼");
                    lbItemInOutRecord.Items.Add("给父母");
                    break;
                case "饮食费":
                    lbItemInOutRecord.Items.Add("主食");
                    lbItemInOutRecord.Items.Add("蔬菜");
                    lbItemInOutRecord.Items.Add("肉类");
                    lbItemInOutRecord.Items.Add("水果");
                    lbItemInOutRecord.Items.Add("酒水");
                    break;
                case "住房费":
                    lbItemInOutRecord.Items.Add("水费");
                    lbItemInOutRecord.Items.Add("电费");
                    lbItemInOutRecord.Items.Add("天然气费");
                    lbItemInOutRecord.Items.Add("物业费");
                    lbItemInOutRecord.Items.Add("房租");
                    break;
                case "服饰费":
                    lbItemInOutRecord.Items.Add("衣服");
                    lbItemInOutRecord.Items.Add("裤子");
                    lbItemInOutRecord.Items.Add("鞋子");
                    lbItemInOutRecord.Items.Add("包包");
                    lbItemInOutRecord.Items.Add("饰品");
                    break;
                case "交通费":
                    lbItemInOutRecord.Items.Add("公交");
                    lbItemInOutRecord.Items.Add("出租");
                    lbItemInOutRecord.Items.Add("地铁");
                    lbItemInOutRecord.Items.Add("火车");
                    lbItemInOutRecord.Items.Add("飞机");
                    break;
                case "医疗费":
                    lbItemInOutRecord.Items.Add("药品");
                    lbItemInOutRecord.Items.Add("检查");
                    lbItemInOutRecord.Items.Add("体检");
                    lbItemInOutRecord.Items.Add("住院");
                    lbItemInOutRecord.Items.Add("康复");
                    break;
            }
            lbItemInOutRecord.SelectedIndex = 0;
        }

        private void timerRollInOutRecord_Tick(object sender, EventArgs e)
        {
            if (labRollInOutRecord.Left <= -labRollInOutRecord.Width)
            {
                labRollInOutRecord.Left = this.Width;
            }
            labRollInOutRecord.Left -= 1;
        }
    }
}
