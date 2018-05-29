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
    public partial class AddSelCou : Form
    {
        private int sortOrder = 0;
        public static string couID = "", couName = "", teaID = "", teaName = "";

        public AddSelCou()
        {
            InitializeComponent();
            LoadData_TC();
            labStuName.Text = Maticsoft.Common.StaticDataClass.student.stuName + ">选课";
        }

        public void LoadData_TC()
        {
            DataSet dsTC = new Maticsoft.BLL.TC().GetList(String.Format(" couID = Courses.ID and Teachers.ID = teaID "));
            dsTC.Tables["ds"].Columns["couID"].ColumnName = "课程号";
            dsTC.Tables["ds"].Columns["couName"].ColumnName = "课程名称";
            dsTC.Tables["ds"].Columns["couTime"].ColumnName = "学时";
            dsTC.Tables["ds"].Columns["couPoint"].ColumnName = "学分";
            dsTC.Tables["ds"].Columns["teaID"].ColumnName = "教工号";
            dsTC.Tables["ds"].Columns["teaName"].ColumnName = "教师";
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
                teaID = dgv.Rows[e.RowIndex].Cells[4].Value.ToString();
                teaName = dgv.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
            else
            {
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

        private void btConfirm_Click(object sender, EventArgs e)
        {
            if (couID == "" || couID == null)
            {
                MessageBox.Show("请先选择一行记录！", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (new Maticsoft.BLL.CS().Exists(couID,Maticsoft.Common.StaticDataClass.student.ID))
                {
                    MessageBox.Show("本门课程已选！", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (MessageBox.Show("确认选择教师 " + teaName + " 讲授的 《" + couName + "》 课程？", "信息", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        Maticsoft.Model.CS model = new Maticsoft.Model.CS();
                        model.stuID = Maticsoft.Common.StaticDataClass.student.ID;
                        model.couID = couID;
                        model.teaID = teaID;
                        if (new Maticsoft.BLL.CS().Add(model))
                        {
                            MessageBox.Show("选课成功！", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ((StuCou)this.Owner).LoadData_SC();
                        }
                        else
                        {
                            MessageBox.Show("选课失败！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddSelCou_FormClosed(object sender, FormClosedEventArgs e)
        {
            couID = "";
            couName = "";
            teaID = "";
            teaName = "";
        }
    }
}
