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
        private void btAddAdmin_Click(object sender, EventArgs e)
        {
            AddAdmin adm = new Hotel.AddAdmin();
            adm.ShowDialog(this);
        }

        private void btUpdateAdmin_Click(object sender, EventArgs e)
        {
            AlterAdmin al = new AlterAdmin();
            al.ShowDialog(this);
        }

        private void btDeleteAdmin_Click(object sender, EventArgs e)
        {
            DeleteAdmin del = new Hotel.DeleteAdmin();
            if (del.ShowDialog(this) == DialogResult.OK)
                dgvAdmin_Load();
        }

        public void dgvAdmin_Load()
        {
            Maticsoft.BLL.Admin adm = new BLL.Admin();
            DataSet ds = new DataSet();
            ds = adm.GetList("");
            dgvAdmin.DataSource = ds.Tables[0];
            ds.Tables[0].Columns["userID"].ColumnName = "用户名";
            ds.Tables[0].Columns["userName"].ColumnName = "昵称";
            ds.Tables[0].Columns["passwd"].ColumnMapping = MappingType.Hidden;
            dgvAdmin.AllowUserToAddRows = false;
            dgvAdmin.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void dgvAdmin_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Common.StaticClass.choose1 = dgvAdmin.SelectedRows[0].Cells[0].Value.ToString();
            Common.StaticClass.choose2 = dgvAdmin.SelectedRows[0].Cells[2].Value.ToString();
            SelectAdmin sel = new SelectAdmin();
            if (sel.ShowDialog(this) == DialogResult.OK)
                dgvAdmin_Load();
        }
    }
}
