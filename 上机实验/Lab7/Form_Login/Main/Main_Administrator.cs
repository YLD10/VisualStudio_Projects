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
        #region 系统用户数据加载
        public void LoadData_Admin()
        {
            dsAdmin = new Maticsoft.BLL.Administrators().GetList("");
            dsAdmin.Tables["ds"].Columns["ID"].ColumnName = "ID";
            dsAdmin.Tables["ds"].Columns["userName"].ColumnName = "用户名";

            dgvAdmin.DataSource = dsAdmin.Tables["ds"];
            int columnNumber = dgvAdmin.ColumnCount;
            foreach (DataGridViewColumn col in dgvAdmin.Columns)
            {
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
                col.FillWeight = 100 / columnNumber;
            }
            dgvAdmin.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvAdmin.AllowUserToAddRows = false;
            dgvAdmin.RowHeadersVisible = false;
            dgvAdmin.ReadOnly = true;
        }
        #endregion

        #region 系统用户信息相关操作
        private void btAddAdmin_Click(object sender, EventArgs e)
        {
            new AddAdmin().ShowDialog(this);
        }

        public bool AddAdmin()
        {
            return new Maticsoft.BLL.Administrators().Add(Maticsoft.Common.StaticDataClass.admin);
        }

        private void btUpdateAdmin_Click(object sender, EventArgs e)
        {
            if (Maticsoft.Common.StaticDataClass.admin.userName == "" || Maticsoft.Common.StaticDataClass.admin.userName == null)
            {
                MessageBox.Show("请先选择一行记录！", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                new UpdateAdmin().ShowDialog(this);
            }
        }

        public bool UpdateAdmin()
        {
            return new Maticsoft.BLL.Administrators().Update(Maticsoft.Common.StaticDataClass.admin);
        }

        private void btDeleteAdmin_Click(object sender, EventArgs e)
        {
            if (Maticsoft.Common.StaticDataClass.admin.userName == "" || Maticsoft.Common.StaticDataClass.admin.userName == null)
            {
                MessageBox.Show("请先选择一行记录！", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (MessageBox.Show("确认删除 用户名为 " + Maticsoft.Common.StaticDataClass.admin.userName + " 的系统用户？", "信息", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                if (DeleteAdmin())
                {
                    MessageBox.Show("删除成功！", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Maticsoft.Common.StaticDataClass.admin.userName = "";
                    LoadData_Admin();
                }
                else
                {
                    MessageBox.Show("删除失败！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public bool DeleteAdmin()
        {
            return new Maticsoft.BLL.Administrators().Delete(Maticsoft.Common.StaticDataClass.admin.ID);
        }
        #endregion
    }
}
