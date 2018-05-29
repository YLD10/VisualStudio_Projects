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
        #region 教师数据加载
        public void LoadData_Teacher()
        {
            if (Maticsoft.Common.StaticDataClass.userType.Equals("管理员"))
            {
                dsTeacher = new Maticsoft.BLL.Teachers().GetList("");
            }
            else
            {
                dsTeacher = new Maticsoft.BLL.Teachers().GetList(String.Format("ID = '{0}'", Maticsoft.Common.StaticDataClass.loginTeacherID));
            }
            dsTeacher.Tables["ds"].Columns["ID"].ColumnName = "教工号";
            dsTeacher.Tables["ds"].Columns["teaName"].ColumnName = "姓名";
            dsTeacher.Tables["ds"].Columns["teaSex"].ColumnName = "性别";
            dsTeacher.Tables["ds"].Columns["teaTitle"].ColumnName = "职称";

            dgvTeacher.DataSource = dsTeacher.Tables["ds"];
            int columnNumber = dgvTeacher.ColumnCount;
            foreach (DataGridViewColumn col in dgvTeacher.Columns)
            {
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
                col.FillWeight = 100 / columnNumber;
            }
            dgvTeacher.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvTeacher.AllowUserToAddRows = false;
            dgvTeacher.RowHeadersVisible = false;
            dgvTeacher.ReadOnly = true;
        }
        #endregion

        #region 教师信息相关操作
        private void btAddTeacher_Click(object sender, EventArgs e)
        {
            new AddTeacher().ShowDialog(this);
        }

        public bool AddTeacher()
        {
            return new Maticsoft.BLL.Teachers().Add(Maticsoft.Common.StaticDataClass.teacher);
        }

        private void btUpdateTeacher_Click(object sender, EventArgs e)
        {
            if (Maticsoft.Common.StaticDataClass.teacher.ID == "" || Maticsoft.Common.StaticDataClass.teacher.ID == null)
            {
                MessageBox.Show("请先选择一行记录！", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                new UpdateTeacher().ShowDialog(this);
            }
        }

        public bool UpdateTeacher()
        {
            return new Maticsoft.BLL.Teachers().Update(Maticsoft.Common.StaticDataClass.teacher);
        }

        private void btDeleteTeacher_Click(object sender, EventArgs e)
        {
            if (Maticsoft.Common.StaticDataClass.teacher.ID == "" || Maticsoft.Common.StaticDataClass.teacher.ID == null)
            {
                MessageBox.Show("请先选择一行记录！", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (MessageBox.Show("确认删除 教工号为 " + Maticsoft.Common.StaticDataClass.teacher.ID + " 的教师信息？", "信息", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                if (DeleteTeacher())
                {
                    MessageBox.Show("删除成功！", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Maticsoft.Common.StaticDataClass.teacher.ID = "";
                    LoadData_Teacher();
                }
                else
                {
                    MessageBox.Show("删除失败！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public bool DeleteTeacher()
        {
            return new Maticsoft.BLL.Teachers().Delete(Maticsoft.Common.StaticDataClass.teacher.ID);
        }

        private void btSearchByTeaName_Click(object sender, EventArgs e)
        {
            Maticsoft.Common.StaticDataClass.teacher.ID = "";
            string name = tbTeaName.Text.Trim();
            if (name == null || name == "")
            {
                MessageBox.Show("不能有空！", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DataSet ds = new Maticsoft.BLL.Teachers().GetList(String.Format(" teaName like '%{0}%' ", name));
                if (ds.Tables.Count > 0 && ds.Tables["ds"].Rows.Count > 0)
                {
                    ds.Tables["ds"].Columns["ID"].ColumnName = "教工号";
                    ds.Tables["ds"].Columns["teaName"].ColumnName = "姓名";
                    ds.Tables["ds"].Columns["teaSex"].ColumnName = "性别";
                    ds.Tables["ds"].Columns["teaTitle"].ColumnName = "职称";

                    dgvTeacher.DataSource = ds.Tables["ds"];
                    int columnNumber = dgvTeacher.ColumnCount;
                    foreach (DataGridViewColumn col in dgvTeacher.Columns)
                    {
                        col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        col.SortMode = DataGridViewColumnSortMode.NotSortable;
                        col.FillWeight = 100 / columnNumber;
                    }
                    dgvTeacher.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dgvTeacher.AllowUserToAddRows = false;
                    dgvTeacher.RowHeadersVisible = false;
                    dgvTeacher.ReadOnly = true;
                }
                else
                {
                    MessageBox.Show("查无此人！", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void btSeeAllTeachers_Click(object sender, EventArgs e)
        {
            Maticsoft.Common.StaticDataClass.teacher.ID = "";
            LoadData_Teacher();
        }

        private void btSeeTeaCou_Click(object sender, EventArgs e)
        {
            if (Maticsoft.Common.StaticDataClass.teacher.ID == "" || Maticsoft.Common.StaticDataClass.teacher.ID == null)
            {
                MessageBox.Show("请先选择一行记录！", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                new TeaCou().ShowDialog(this);
            }
        }
        #endregion

    }
}