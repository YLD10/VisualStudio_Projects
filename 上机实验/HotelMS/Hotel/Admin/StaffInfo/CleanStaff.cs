using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Maticsoft.Hotel
{
    public partial class CleanStaff : Form
    {
        public CleanStaff()
        {
            InitializeComponent();
        }

        private void btConfirm_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("server=.;database=HotelMS;Integrated Security=true");
            string sql = string.Format("select Staff.staID,staName,staSex,staAge,floorNum from Staff,Clean where Clean.staId=Staff.staID ");
            SqlCommand comm = new SqlCommand(sql, conn);
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = comm;
            DataSet dss = new DataSet();
            da.Fill(dss, "Stuff");
            dgvClean.DataSource = dss.Tables["Stuff"];
            dgvClean.AllowUserToAddRows = false;
            dss.Tables["Stuff"].Columns["staID"].ColumnName = "员工工号";
            dss.Tables["Stuff"].Columns["staName"].ColumnName = "姓名";
            dss.Tables["Stuff"].Columns["staSex"].ColumnName = "性别";
            dss.Tables["Stuff"].Columns["staAge"].ColumnName = "年龄";
            dss.Tables["Stuff"].Columns["floorNum"].ColumnName = "楼层号";
            conn.Close();
        }
    }
}
