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
    public partial class StuCou : Form
    {
        private int sortOrder = 0;
        public static string couID = "", teaID = "";

        public StuCou()
        {
            InitializeComponent();
            LoadData_SC();
            labStuName.Text = Maticsoft.Common.StaticDataClass.student.stuName;
        }

        #region 选课关系数据加载
        public void LoadData_SC()
        {
            DataSet dsSC = new Maticsoft.BLL.CS().GetList(String.Format(" CS.stuID = '{0}' and CS.couID = Courses.ID and CS.teaID = Teachers.ID ", Maticsoft.Common.StaticDataClass.student.ID));
            dsSC.Tables["ds"].Columns["couID"].ColumnName = "课程号";
            dsSC.Tables["ds"].Columns["couName"].ColumnName = "课程名称";
            dsSC.Tables["ds"].Columns["couTime"].ColumnName = "学时";
            dsSC.Tables["ds"].Columns["couPoint"].ColumnName = "学分";
            dsSC.Tables["ds"].Columns["teaID"].ColumnName = "教工号";
            dsSC.Tables["ds"].Columns["teaName"].ColumnName = "教师";
            dsSC.Tables["ds"].Columns["score"].ColumnName = "成绩";

            dgvSC.DataSource = dsSC.Tables["ds"];
            int columnNumber = dgvSC.ColumnCount;
            foreach (DataGridViewColumn col in dgvSC.Columns)
            {
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
                col.FillWeight = 100 / columnNumber;
            }
            dgvSC.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSC.AllowUserToAddRows = false;
            dgvSC.RowHeadersVisible = false;
            dgvSC.ReadOnly = true;
        }
        #endregion

        private void dgvSC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                couID = dgv.Rows[e.RowIndex].Cells[0].Value.ToString();
                teaID = dgv.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
            else
            {
                couID = "";
                teaID = "";
                if (sortOrder == 0)
                {
                    dgv.Sort(dgv.Columns[e.ColumnIndex], ListSortDirection.Descending);
                    sortOrder++;
                }
                else
                {
                    dgv.Sort(dgv.Columns[e.ColumnIndex], ListSortDirection.Ascending);
                    sortOrder--;
                }
            }
        }

        private void btAddSelCou_Click(object sender, EventArgs e)
        {
            new AddSelCou().ShowDialog(this);
        }

        private void btDeleteSelCou_Click(object sender, EventArgs e)
        {
            if (couID == "" || couID == null)
            {
                MessageBox.Show("请先选择一行记录！", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (MessageBox.Show("确认删除 课程号为 " + couID + " 的选课记录？", "信息", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    Maticsoft.Model.CS model = new Maticsoft.Model.CS();
                    model.stuID = Maticsoft.Common.StaticDataClass.student.ID;
                    model.teaID = teaID;
                    model.couID = couID;
                    if (new Maticsoft.BLL.CS().Delete(model))
                    {
                        MessageBox.Show("删除成功！", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        couID = "";
                        teaID = "";
                        LoadData_SC();
                    }
                    else
                    {
                        MessageBox.Show("删除失败！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void StuCou_FormClosed(object sender, FormClosedEventArgs e)
        {
            couID = "";
            teaID = "";
        }
    }
}
