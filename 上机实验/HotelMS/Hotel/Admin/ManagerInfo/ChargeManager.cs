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
    public partial class ChargeManager : Form
    {
        public ChargeManager()
        {
            InitializeComponent();
        }

        private void btConfirm_Click(object sender, EventArgs e)
        {
            SqlConnection conn2 = new SqlConnection("server=.;database=HotelMS;Integrated Security=true");
            string sql2 = string.Format("select Charge.cusID,cusName,cusSex,cusAge,Charge.manID,manName from Manager,Customer,Charge where Manager.manId=Charge.manID and Customer.cusID=Charge.cusID");
            SqlCommand comm2 = new SqlCommand(sql2, conn2);
            conn2.Open();
            SqlDataAdapter da2 = new SqlDataAdapter();
            da2.SelectCommand = comm2;
            DataSet dss2 = new DataSet();
            da2.Fill(dss2, "Charge");
            dgvCharge.DataSource = dss2.Tables["Charge"];
            dss2.Tables["Charge"].Columns["cusID"].ColumnName = "身份证号";
            dss2.Tables["Charge"].Columns["cusName"].ColumnName = "客户姓名";
            dss2.Tables["Charge"].Columns["cusSex"].ColumnName = "客户性别";
            dss2.Tables["Charge"].Columns["cusAge"].ColumnName = "客户年龄";
            dss2.Tables["Charge"].Columns["manID"].ColumnName = "前台工号";
            dss2.Tables["Charge"].Columns["manName"].ColumnName = "前台姓名";
            dgvCharge.AllowUserToAddRows = false;
            conn2.Close();

        }
    }
}
