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
    public partial class Main : Form
    {
        #region 课程数据加载
        public void LoadData_Course()
        {
            dsCourse = new Maticsoft.BLL.Courses().GetList("");
            dsCourse.Tables["ds"].Columns["ID"].ColumnName = "课程号";
            dsCourse.Tables["ds"].Columns["couName"].ColumnName = "课程名称";
            dsCourse.Tables["ds"].Columns["couTime"].ColumnName = "学时";
            dsCourse.Tables["ds"].Columns["couPoint"].ColumnName = "学分";

            dgvCourse.DataSource = dsCourse.Tables["ds"];
            int columnNumber = dgvCourse.ColumnCount;
            foreach (DataGridViewColumn col in dgvCourse.Columns)
            {
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
                col.FillWeight = 100 / columnNumber;
            }
            dgvCourse.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCourse.AllowUserToAddRows = false;
            dgvCourse.RowHeadersVisible = false;
            dgvCourse.ReadOnly = true;
        }
        #endregion

        #region 课程信息相关操作
        private void btAddCourse_Click(object sender, EventArgs e)
        {
            new AddCourse().ShowDialog(this);
        }

        public bool AddCourse()
        {
            return new Maticsoft.BLL.Courses().Add(Maticsoft.Common.StaticDataClass.course);
        }

        private void btUpdateCourse_Click(object sender, EventArgs e)
        {
            if (Maticsoft.Common.StaticDataClass.course.ID == "" || Maticsoft.Common.StaticDataClass.course.ID == null)
            {
                MessageBox.Show("请先选择一行记录！", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                new UpdateCourse().ShowDialog(this);
            }
        }

        public bool UpdateCourse()
        {
            return new Maticsoft.BLL.Courses().Update(Maticsoft.Common.StaticDataClass.course);
        }

        private void btDeleteCourse_Click(object sender, EventArgs e)
        {
            if (Maticsoft.Common.StaticDataClass.course.ID == "" || Maticsoft.Common.StaticDataClass.course.ID == null)
            {
                MessageBox.Show("请先选择一行记录！", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (MessageBox.Show("确认删除 课程号为 " + Maticsoft.Common.StaticDataClass.course.ID + " 的课程信息？", "信息", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                if (DeleteCourse())
                {
                    MessageBox.Show("删除成功！", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Maticsoft.Common.StaticDataClass.course.ID = "";
                    LoadData_Course();
                }
                else
                {
                    MessageBox.Show("删除失败！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public bool DeleteCourse()
        {
            return new Maticsoft.BLL.Courses().Delete(Maticsoft.Common.StaticDataClass.course.ID);
        }

        private void btSearchByCouName_Click(object sender, EventArgs e)
        {
            Maticsoft.Common.StaticDataClass.course.ID = "";
            string name = tbCouName.Text.Trim();
            if (name == null || name == "")
            {
                MessageBox.Show("不能有空！", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DataSet ds = new Maticsoft.BLL.Courses().GetList(String.Format(" couName like '%{0}%' ", name));
                if (ds.Tables.Count > 0 && ds.Tables["ds"].Rows.Count > 0)
                {
                    ds.Tables["ds"].Columns["ID"].ColumnName = "课程号";
                    ds.Tables["ds"].Columns["couName"].ColumnName = "课程名称";
                    ds.Tables["ds"].Columns["couTime"].ColumnName = "学时";
                    ds.Tables["ds"].Columns["couPoint"].ColumnName = "学分";

                    dgvCourse.DataSource = ds.Tables["ds"];
                    int columnNumber = dgvCourse.ColumnCount;
                    foreach (DataGridViewColumn col in dgvCourse.Columns)
                    {
                        col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        col.SortMode = DataGridViewColumnSortMode.NotSortable;
                        col.FillWeight = 100 / columnNumber;
                    }
                    dgvCourse.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dgvCourse.AllowUserToAddRows = false;
                    dgvCourse.RowHeadersVisible = false;
                    dgvCourse.ReadOnly = true;
                }
                else
                {
                    MessageBox.Show("查无此课程！", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btSeeCouTea_Click(object sender, EventArgs e)
        {
            if (Maticsoft.Common.StaticDataClass.course.ID == "" || Maticsoft.Common.StaticDataClass.course.ID == null)
            {
                MessageBox.Show("请先选择一行记录！", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                new CouTea().ShowDialog(this);
            }
        }

        private void btSeeAllCourses_Click(object sender, EventArgs e)
        {
            Maticsoft.Common.StaticDataClass.course.ID = "";
            LoadData_Course();
        }
        #endregion
    }
}