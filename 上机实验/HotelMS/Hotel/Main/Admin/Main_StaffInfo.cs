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

        private void btSearchStaff_Click(object sender, EventArgs e)
        {
            string information = "";
            switch (combStaff.Text.Trim())
            {
                case "工号":
                    information = "staID";
                    break;
                case "姓名":
                    information = "staName";
                    break;
                case "性别":
                    information = "staSex";
                    break;
                case "年龄":
                    information = "staAge";
                    break;
                default:
                    break;
            }

            Maticsoft.BLL.Staff sta = new BLL.Staff();
            string string1 = string.Format("{0} = '{1}'", information, tbStaff.Text.Trim());
            if(information == "staID")
            {
                Model.Staff smodel = new Model.Staff();
                smodel = sta.GetModel1(string1);
                if (smodel.staID == "" || smodel.staID == null)
                {
                    MessageBox.Show("查无此人");
                }
                else
                {
                    SeekStaff see = new Hotel.SeekStaff(smodel);
                    see.ShowDialog(this);
                }

            }
            else
            {
                DataSet ds = new DataSet();
                ds = sta.GetList(string1);
                dgvManager.DataSource = ds.Tables[0];
                ds.Tables[0].Columns["staID"].ColumnName = "员工工号";
                ds.Tables[0].Columns["staName"].ColumnName = "姓名";
                ds.Tables[0].Columns["staSex"].ColumnName = "性别";
                ds.Tables[0].Columns["staAge"].ColumnName = "年龄";
                dgvStaff.AllowUserToAddRows = false;
                dgvStaff.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            
           
        }

        private void btSeeAllStaffs_Click(object sender, EventArgs e)
        {
            StaffLoad();
        }

        public void StaffLoad()
        {
            Maticsoft.BLL.Staff sta = new BLL.Staff();
            DataSet ds = new DataSet();
            ds = sta.GetList("");
            dgvStaff.DataSource = ds.Tables[0];
            ds.Tables[0].Columns["staId"].ColumnName = "员工工号";
            ds.Tables[0].Columns["staName"].ColumnName = "姓名";
            ds.Tables[0].Columns["staSex"].ColumnName = "性别";
            ds.Tables[0].Columns["staAge"].ColumnName = "年龄";
            dgvStaff.AllowUserToAddRows = false;
            dgvStaff.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void btAddStaff_Click(object sender, EventArgs e)
        {
            AddStaff ad = new AddStaff();
            ad.ShowDialog(this);
        }

        private void btDeleteStaff_Click(object sender, EventArgs e)
        {
            DeleteStaff del = new Hotel.DeleteStaff();
            del.ShowDialog(this);
        }

        private void btUpdateStaff_Click(object sender, EventArgs e)
        {
            AlterStaff al = new AlterStaff();
            al.ShowDialog(this);
        }

        private void btSeeCleanInfo_Click(object sender, EventArgs e)
        {
            CleanStaff cl = new CleanStaff();
            cl.ShowDialog(this);
        }

        private void dgvStaff_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Common.StaticClass.choose1 = dgvStaff.SelectedRows[0].Cells[0].Value.ToString();
            SelectStaff sel = new SelectStaff();
            sel.ShowDialog(this);
        }
        
    }
}

