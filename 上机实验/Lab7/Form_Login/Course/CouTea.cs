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
    public partial class CouTea : Form
    {
        private int sortOrder = 0;
        public static string teaID = "";

        public CouTea()
        {
            InitializeComponent();
            LoadData_TC();
            Init();
        }

        private void Init()
        {
            labCouName.Text = Maticsoft.Common.StaticDataClass.course.couName;
            if (Maticsoft.Common.StaticDataClass.userType != "管理员")
            {
                btAddTeacher.Visible = false;
                btDeleteTeacher.Visible = false;
                labCouName.Location = new Point(12, 12);
                dgvTC.Location = new Point(12, 36);
                dgvTC.Size = new System.Drawing.Size(703, 386);
            }
        }

        #region 任课关系数据加载
        public void LoadData_TC()
        {
            DataSet dsTC = new Maticsoft.BLL.TC().GetList(String.Format(" teaID = Teachers.ID and couID = '{0}' and Courses.ID = couID ", Maticsoft.Common.StaticDataClass.course.ID));
            dsTC.Tables["ds"].Columns["teaID"].ColumnName = "教工号";
            dsTC.Tables["ds"].Columns["teaName"].ColumnName = "姓名";
            dsTC.Tables["ds"].Columns["teaSex"].ColumnName = "性别";
            dsTC.Tables["ds"].Columns["teaTitle"].ColumnName = "职称";
            dsTC.Tables["ds"].Columns["couID"].ColumnMapping = MappingType.Hidden;
            dsTC.Tables["ds"].Columns["couName"].ColumnMapping = MappingType.Hidden;
            dsTC.Tables["ds"].Columns["couTime"].ColumnMapping = MappingType.Hidden;
            dsTC.Tables["ds"].Columns["couPoint"].ColumnMapping = MappingType.Hidden;

            dgvTC.DataSource = dsTC.Tables["ds"];
            int columnNumber = dgvTC.ColumnCount;
            foreach (DataGridViewColumn col in dgvTC.Columns)
            {
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
                col.FillWeight = 100 / columnNumber;
            }
            dgvTC.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvTC.AllowUserToAddRows = false;
            dgvTC.RowHeadersVisible = false;
            dgvTC.ReadOnly = true;
        }
        #endregion

        private void dgvTC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                teaID = dgv.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            else
            {
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

        private void btAddTeacher_Click(object sender, EventArgs e)
        {
            new AddCouTea().ShowDialog(this);
        }

        private void btDeleteTeacher_Click(object sender, EventArgs e)
        {
            if (teaID == "" || teaID == null)
            {
                MessageBox.Show("请先选择一行记录！", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (MessageBox.Show("确认删除 教工号为 " + teaID + " 的任课教师记录？", "信息", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    if (new Maticsoft.BLL.TC().Delete(teaID, Maticsoft.Common.StaticDataClass.course.ID))
                    {
                        new Maticsoft.BLL.CS().Delete(teaID, Maticsoft.Common.StaticDataClass.course.ID);
                        MessageBox.Show("删除成功！", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        teaID = "";
                        LoadData_TC();
                    }
                    else
                    {
                        MessageBox.Show("删除失败！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void CouTea_FormClosed(object sender, FormClosedEventArgs e)
        {
            teaID = "";
        }
    }
}
