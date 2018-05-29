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
    public partial class AddCouTea : Form
    {
        public AddCouTea()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            combID.DisplayMember = "教工号";
            combID.ValueMember = "教工号";
            combID.DataSource = Main.dsTeacher.Tables["ds"];
            combID.SelectedIndex = 0;
        }

        private void CombID_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            e.DrawFocusRectangle();
            e.Graphics.DrawString(((DataRowView)combID.Items[e.Index]).Row[combID.DisplayMember].ToString(), e.Font, new SolidBrush(e.ForeColor), e.Bounds, new System.Drawing.StringFormat());
        }

        private void combID_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbTeaName.Text = Main.dsTeacher.Tables["ds"].Rows[combID.SelectedIndex]["姓名"].ToString();
            tbTeaTitle.Text = Main.dsTeacher.Tables["ds"].Rows[combID.SelectedIndex]["职称"].ToString();
            tbTeaSex.Text = Main.dsTeacher.Tables["ds"].Rows[combID.SelectedIndex]["性别"].ToString();
        }

        private void btConfirm_Click(object sender, EventArgs e)
        {
            Maticsoft.Model.TC model = new Maticsoft.Model.TC();
            model.couID = Maticsoft.Common.StaticDataClass.course.ID;
            model.teaID = (string)combID.SelectedValue;

            if (new Maticsoft.BLL.TC().Exists(model.teaID, model.couID))
            {
                MessageBox.Show("此教师不能重复教授同一门课！", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (new Maticsoft.BLL.TC().Add(model))
                {
                    MessageBox.Show("添加成功！", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ((CouTea)this.Owner).LoadData_TC();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("添加失败！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
