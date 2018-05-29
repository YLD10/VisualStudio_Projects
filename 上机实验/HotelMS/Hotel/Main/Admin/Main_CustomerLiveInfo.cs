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
        public static Model.CustomerLive customerLive = new Model.CustomerLive();
        public static DataSet dsCustomerLive = new DataSet();

        public void LoadData_CustomerLiveInfo()
        {
            customerLive = new Model.CustomerLive();
            dsCustomerLive = new BLL.CustomerLive().GetListCustomerLive("");

            dgvCustomerLive.DataSource = dsCustomerLive.Tables["ds"];
            int columnNumber = dgvCustomerLive.ColumnCount;
            foreach (DataGridViewColumn col in dgvCustomerLive.Columns)
            {
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
                col.FillWeight = 100 / columnNumber;
            }
            dgvCustomerLive.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCustomerLive.AllowUserToAddRows = false;
            dgvCustomerLive.RowHeadersVisible = false;
            dgvCustomerLive.ReadOnly = true;
        }

        //private void combCustomerLive_DrawItem(object sender, DrawItemEventArgs e)
        //{
        //    e.DrawBackground();
        //    e.DrawFocusRectangle();
        //    e.Graphics.DrawString(((DataRowView)combCustomerLive.Items[e.Index]).Row[combCustomerLive.DisplayMember].ToString(), e.Font, new SolidBrush(e.ForeColor), e.Bounds, new System.Drawing.StringFormat());
        //}

        private void dgvCustomerLive_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                customerLive.cusID = dgv.Rows[e.RowIndex].Cells[0].Value.ToString();
                customerLive.floorNum = dgv.Rows[e.RowIndex].Cells[1].Value.ToString();
                customerLive.roomID = dgv.Rows[e.RowIndex].Cells[2].Value.ToString();
                customerLive.startLiveTime = DateTime.Parse(dgv.Rows[e.RowIndex].Cells[3].Value.ToString());
                customerLive.proEndLiveTime = DateTime.Parse(dgv.Rows[e.RowIndex].Cells[4].Value.ToString());
                customerLive.endLiveTime = DateTime.Parse(dgv.Rows[e.RowIndex].Cells[5].Value.ToString());
                customerLive.isAccount = dgv.Rows[e.RowIndex].Cells[6].Value.ToString() == "是" ? 1 : 0;
            }
            else
            {
                customerLive = new Model.CustomerLive();
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

        private void combCustomerLive_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combCustomerLive.SelectedIndex == 3)
            {
                tbCustomerLive.Visible = false;
                dtpStart.Visible = true;
                dtpEnd.Visible = true;
                labFromTo.Visible = true;
                btSearchCustomerLive.Location = new Point(440, 30);
                btSeeAllCustomerLive.Location = new Point(536, 30);
                btDeleteCustomerLive.Location = new Point(633, 30);
            }
            else
            {
                tbCustomerLive.Visible = true;
                dtpStart.Visible = false;
                dtpEnd.Visible = false;
                labFromTo.Visible = false;
                btSearchCustomerLive.Location = new Point(278, 30);
                btSeeAllCustomerLive.Location = new Point(407, 30);
                btDeleteCustomerLive.Location = new Point(536, 30);
            }
        }

        private void SearchCustomerLive(string sqlString)
        {
            customerLive = new Model.CustomerLive();
            DataSet ds = new BLL.CustomerLive().GetListCustomerLive(sqlString);

            if (ds.Tables["ds"].Rows.Count == 0)
            {
                MessageBox.Show("查无结果！", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } 
            else
            {
                dgvCustomerLive.DataSource = ds.Tables["ds"];
                int columnNumber = dgvCustomerLive.ColumnCount;
                foreach (DataGridViewColumn col in dgvCustomerLive.Columns)
                {
                    col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    col.SortMode = DataGridViewColumnSortMode.NotSortable;
                    col.FillWeight = 100 / columnNumber;
                }
                dgvCustomerLive.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvCustomerLive.AllowUserToAddRows = false;
                dgvCustomerLive.RowHeadersVisible = false;
                dgvCustomerLive.ReadOnly = true;
            }
        }

        private void btSearchCustomerLive_Click(object sender, EventArgs e)
        {
            string select = tbCustomerLive.Text.ToString().Trim();
            switch (combCustomerLive.SelectedIndex)
            {
                case 0:
                    if (select == "" || select == null)
                    {
                        MessageBox.Show("不能有空！", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    } 
                    else
                    {
                        SearchCustomerLive(String.Format(" cusID = '{0}' ", select));
                    }
                    break;
                case 1:
                    if (select == "" || select == null)
                    {
                        MessageBox.Show("不能有空！", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    } 
                    else
                    {
                        SearchCustomerLive(String.Format(" floorNum = '{0}' ", select));
                    }
                    break;
                case 2:
                    if (select == "" || select == null)
                    {
                        MessageBox.Show("不能有空！", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    } 
                    else
                    {
                        SearchCustomerLive(String.Format(" roomID = '{0}' ", select));
                    }
                    break; 
                case 3:
                    DateTime dtStart = dtpStart.Value,
                             dtEnd = dtpEnd.Value;
                    
                    if (dtStart <= dtEnd)
                    {
                        SearchCustomerLive(String.Format(" startLiveTime between '{0}' and '{1}' ", dtStart.ToShortDateString() + " 00:00:00", dtEnd.ToShortDateString() + " 23:59:59"));
                    } 
                    else
                    {
                        MessageBox.Show("起始时间不得大于结束时间！", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break; 
            }
        }

        private void btDeleteCustomerLive_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定删除一年前的客户入住记录吗？", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                new BLL.CustomerLive().DeleteCustomerLive(String.Format(" endLiveTime < '{0}' ", DateTime.Now.AddYears(-1).ToString()));
                MessageBox.Show("删除成功！", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData_CustomerLiveInfo();
            }            
        }

        private void btSeeAllCustomerLive_Click(object sender, EventArgs e)
        {
            LoadData_CustomerLiveInfo();
        }
    }
}
