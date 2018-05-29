using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Maticsoft.Hotel
{
    public partial class Main_Admin : Form
    {
        public static Model.CustomerHistoryRecord cusHisRec = new Model.CustomerHistoryRecord();
        public static DataSet dsCusHisRec = new DataSet();

        public void LoadData_CustomerHistoryRecordInfo()
        {
            cusHisRec = new Model.CustomerHistoryRecord();
            dsCusHisRec = new BLL.CustomerHistoryRecord().GetListCusHisRec("");

            dgvCusHisRec.DataSource = dsCusHisRec.Tables["ds"];
            int columnNumber = dgvCusHisRec.ColumnCount;
            foreach (DataGridViewColumn col in dgvCusHisRec.Columns)
            {
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
                col.FillWeight = 100 / columnNumber;
            }
            dgvCusHisRec.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCusHisRec.AllowUserToAddRows = false;
            dgvCusHisRec.RowHeadersVisible = false;
            dgvCusHisRec.ReadOnly = true;
        }

        //private void combCusHisRec_DrawItem(object sender, DrawItemEventArgs e)
        //{
        //    e.DrawBackground();
        //    e.DrawFocusRectangle();
        //    e.Graphics.DrawString(((DataRowView)combCusHisRec.Items[e.Index]).Row[combCusHisRec.DisplayMember].ToString(), e.Font, new SolidBrush(e.ForeColor), e.Bounds, new System.Drawing.StringFormat());
        //}

        private void dgvCusHisRec_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                cusHisRec.cusID = dgv.Rows[e.RowIndex].Cells[0].Value.ToString();
                cusHisRec.historyTimes = int.Parse(dgv.Rows[e.RowIndex].Cells[1].Value.ToString());
                cusHisRec.discountRate = decimal.Parse(dgv.Rows[e.RowIndex].Cells[2].Value.ToString());
            }
            else
            {
                cusHisRec = new Model.CustomerHistoryRecord();
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

        private void SearchCusHisRec(string sqlString)
        {
            cusHisRec = new Model.CustomerHistoryRecord();
            DataSet ds = new BLL.CustomerHistoryRecord().GetListCusHisRec(sqlString);
            if (ds.Tables["ds"].Rows.Count == 0)
            {
                MessageBox.Show("查无结果！", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } 
            else
            {
                dgvCusHisRec.DataSource = ds.Tables["ds"];
                int columnNumber = dgvCusHisRec.ColumnCount;
                foreach (DataGridViewColumn col in dgvCusHisRec.Columns)
                {
                    col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    col.SortMode = DataGridViewColumnSortMode.NotSortable;
                    col.FillWeight = 100 / columnNumber;
                }
                dgvCusHisRec.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvCusHisRec.AllowUserToAddRows = false;
                dgvCusHisRec.RowHeadersVisible = false;
                dgvCusHisRec.ReadOnly = true;
            }
        }

        private void btSearchCusHisRec_Click(object sender, EventArgs e)
        {
            string select = tbCusHisRec.Text.ToString().Trim();
            switch (combCusHisRec.SelectedIndex)
            {
                case 0:
                    if (select == "" || select == null)
                    {
                        MessageBox.Show("不能有空！", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        SearchCusHisRec(String.Format(" cusID = '{0}' ", select));
                    }
                    break;
                case 1:
                    if (select == "" || select == null)
                    {
                        MessageBox.Show("不能有空！", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        SearchCusHisRec(String.Format(" historyTimes = '{0}' ", select));
                    }
                    break;
            }
        }

        private void btSeeAllCusHisRec_Click(object sender, EventArgs e)
        {
            LoadData_CustomerHistoryRecordInfo();
        }
    }
}
