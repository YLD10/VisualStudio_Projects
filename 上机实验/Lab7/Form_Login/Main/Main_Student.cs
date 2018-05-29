using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Form_SC
{
    public partial class Main : Form
    {
        #region 学生数据加载
        public void LoadData_Student()
        {
            if (Maticsoft.Common.StaticDataClass.userType.Equals("管理员"))
            {
                dsStudent = new Maticsoft.BLL.Students().GetList("");
            }
            else
            {
                dsStudent = new Maticsoft.BLL.Students().GetList(String.Format("ID = '{0}'", Maticsoft.Common.StaticDataClass.loginStudentID));
            }
            dsStudent.Tables["ds"].Columns["ID"].ColumnName = "学号";
            dsStudent.Tables["ds"].Columns["stuName"].ColumnName = "姓名";
            dsStudent.Tables["ds"].Columns["stuSex"].ColumnName = "性别";
            dsStudent.Tables["ds"].Columns["stuCollege"].ColumnName = "学院";
            dsStudent.Tables["ds"].Columns["stuMajor"].ColumnName = "专业";
            dsStudent.Tables["ds"].Columns["stuClass"].ColumnName = "班级";

            dgvStudent.DataSource = dsStudent.Tables["ds"];
            int columnNumber = dgvStudent.ColumnCount;
            foreach (DataGridViewColumn col in dgvStudent.Columns)
            {
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
                col.FillWeight = 100 / columnNumber;
            }
            dgvStudent.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvStudent.AllowUserToAddRows = false;
            dgvStudent.RowHeadersVisible = false;
            dgvStudent.ReadOnly = true;
        }
        #endregion

        #region 学生信息相关操作
        private void btAddStudent_Click(object sender, EventArgs e)
        {
            new AddStudent().ShowDialog(this);
        }

        public bool AddStudent()
        {
            return new Maticsoft.BLL.Students().Add(Maticsoft.Common.StaticDataClass.student);
        }

        private void btUpdateStudent_Click(object sender, EventArgs e)
        {
            if (Maticsoft.Common.StaticDataClass.student.ID == "" || Maticsoft.Common.StaticDataClass.student.ID == null)
            {
                MessageBox.Show("请先选择一行记录！", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                new UpdateStudent().ShowDialog(this);
            }
        }

        public bool UpdateStudent()
        {
            return new Maticsoft.BLL.Students().Update(Maticsoft.Common.StaticDataClass.student);
        }

        private void btDeleteStudent_Click(object sender, EventArgs e)
        {
            if (Maticsoft.Common.StaticDataClass.student.ID == "" || Maticsoft.Common.StaticDataClass.student.ID == null)
            {
                MessageBox.Show("请先选择一行记录！", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (MessageBox.Show("确认删除 学号为 " + Maticsoft.Common.StaticDataClass.student.ID + " 的学生信息？", "信息", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                if (DeleteStudent())
                {
                    MessageBox.Show("删除成功！", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Maticsoft.Common.StaticDataClass.student.ID = "";
                    LoadData_Student();
                }
                else
                {
                    MessageBox.Show("删除失败！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public bool DeleteStudent()
        {
            return new Maticsoft.BLL.Students().Delete(Maticsoft.Common.StaticDataClass.student.ID);
        }

        private void btSearchByStuID_Click(object sender, EventArgs e)
        {
            Maticsoft.Common.StaticDataClass.student.ID = "";
            string ID = tbStuID.Text.Trim();
            if (ID == null || ID == "")
            {
                MessageBox.Show("不能有空！", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
               DataSet ds = new Maticsoft.BLL.Students().GetList(String.Format("ID = '{0}'", ID));
               if (ds.Tables.Count > 0 && ds.Tables["ds"].Rows.Count > 0)
                {
                    ds.Tables["ds"].Columns["ID"].ColumnName = "学号";
                    ds.Tables["ds"].Columns["stuName"].ColumnName = "姓名";
                    ds.Tables["ds"].Columns["stuSex"].ColumnName = "性别";
                    ds.Tables["ds"].Columns["stuCollege"].ColumnName = "学院";
                    ds.Tables["ds"].Columns["stuMajor"].ColumnName = "专业";
                    ds.Tables["ds"].Columns["stuClass"].ColumnName = "班级";

                    dgvStudent.DataSource = ds.Tables["ds"];
                    int columnNumber = dgvStudent.ColumnCount;
                    foreach (DataGridViewColumn col in dgvStudent.Columns)
                    {
                        col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        col.SortMode = DataGridViewColumnSortMode.NotSortable;
                        col.FillWeight = 100 / columnNumber;
                    }
                    dgvStudent.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dgvStudent.AllowUserToAddRows = false;
                    dgvStudent.RowHeadersVisible = false;
                    dgvStudent.ReadOnly = true;
                }
                else
                {
                    MessageBox.Show("查无此人！", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
 
        }

        private void btSeeAllStudents_Click(object sender, EventArgs e)
        {
            Maticsoft.Common.StaticDataClass.student.ID = "";
            LoadData_Student();
        }

        private void btSeeStuCou_Click(object sender, EventArgs e)
        {
            if (Maticsoft.Common.StaticDataClass.student.ID == "" || Maticsoft.Common.StaticDataClass.student.ID == null)
            {
                MessageBox.Show("请先选择一行记录！", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                new StuCou().ShowDialog(this);
            }
        }

        #endregion
    }
}
