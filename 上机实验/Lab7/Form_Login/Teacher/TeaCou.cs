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
    public partial class TeaCou : Form
    {
        private int sortOrder = 0;
        public static string couID = "", couName = "";

        public TeaCou()
        {
            InitializeComponent();
            LoadData_TC();
            labTeaName.Text = Maticsoft.Common.StaticDataClass.teacher.teaName;
        }

        public void LoadData_TC()
        {
            DataSet dsTC = new Maticsoft.BLL.TC().GetList(String.Format(" teaID = '{0}' and couID = Courses.ID and Teachers.ID = teaID ", Maticsoft.Common.StaticDataClass.teacher.ID));
            dsTC.Tables["ds"].Columns["couID"].ColumnName = "课程号";
            dsTC.Tables["ds"].Columns["couName"].ColumnName = "课程名称";
            dsTC.Tables["ds"].Columns["couTime"].ColumnName = "学时";
            dsTC.Tables["ds"].Columns["couPoint"].ColumnName = "学分";
            dsTC.Tables["ds"].Columns["teaID"].ColumnMapping = MappingType.Hidden;
            dsTC.Tables["ds"].Columns["teaName"].ColumnMapping = MappingType.Hidden;
            dsTC.Tables["ds"].Columns["teaSex"].ColumnMapping = MappingType.Hidden;
            dsTC.Tables["ds"].Columns["teaTitle"].ColumnMapping = MappingType.Hidden;

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

        private void dgvTC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                couID = dgv.Rows[e.RowIndex].Cells[0].Value.ToString();
                couName = dgv.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            else
            {
                couID = "";
                couName = "";
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

        private void btSeeAllStudents_Click(object sender, EventArgs e)
        {
            if (couID == "" || couID == null)
            {
                MessageBox.Show("请先选择一行记录！", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                new TeaStu().ShowDialog(this);
            }
        }

        private void TeaCou_FormClosed(object sender, FormClosedEventArgs e)
        {
            couID = "";
            couName = "";
        }
    }
}
