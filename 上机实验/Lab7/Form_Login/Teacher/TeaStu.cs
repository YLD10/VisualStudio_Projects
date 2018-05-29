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
    public partial class TeaStu : Form
    {
        private int sortOrder = 0;
        public static string stuID = "";
        public static DataSet ds = new DataSet();

        public TeaStu()
        {
            InitializeComponent();
            LoadData_TS();
            labCouName.Text = Maticsoft.Common.StaticDataClass.teacher.teaName + ">" + TeaCou.couName;
        }

        public void LoadData_TS()
        {
            ds = new Maticsoft.BLL.CS().GetListTeaStu(String.Format(" CS.couID = '{0}' and CS.teaID = '{1}' and CS.stuID = Students.ID ", TeaCou.couID, Maticsoft.Common.StaticDataClass.teacher.ID));
            ds.Tables["ds"].Columns["stuID"].ColumnName = "学号";
            ds.Tables["ds"].Columns["stuName"].ColumnName = "姓名";
            ds.Tables["ds"].Columns["stuCollege"].ColumnName = "学院";
            ds.Tables["ds"].Columns["stuMajor"].ColumnName = "专业";
            ds.Tables["ds"].Columns["stuClass"].ColumnName = "班级";
            ds.Tables["ds"].Columns["score"].ColumnName = "成绩";

            dgvTS.DataSource = ds.Tables["ds"];
            int columnNumber = dgvTS.ColumnCount;
            foreach (DataGridViewColumn col in dgvTS.Columns)
            {
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
                col.FillWeight = 100 / columnNumber;
            }
            dgvTS.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvTS.AllowUserToAddRows = false;
            dgvTS.RowHeadersVisible = false;
            dgvTS.ReadOnly = true;
        }

        private void dgvTS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                stuID = dgv.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            else
            {
                stuID = "";
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

        private void btUpdateScore_Click(object sender, EventArgs e)
        {
            if (stuID == "" || stuID == null)
            {
                MessageBox.Show("请先选择一行记录！", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                new UpdateStuScore
().ShowDialog(this);
            }
        }

        private void TeaStu_FormClosed(object sender, FormClosedEventArgs e)
        {
            stuID = "";
        }
    }
}
