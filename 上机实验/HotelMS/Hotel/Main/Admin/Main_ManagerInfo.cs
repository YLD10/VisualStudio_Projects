using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Maticsoft.Hotel
{
    public partial class Main_Admin : Form
    {
        private void btSearchManager_Click(object sender, EventArgs e)
        {
            string information = "";
            switch (combManager.Text.Trim())
            {
                case "工号":
                    information = "manID";
                    break;
                case "姓名":
                    information = "manName";
                    break;
                case "性别":
                    information = "manSex";
                    break;
                case "年龄":
                    information = "manAge";
                    break;
                default:
                    break;
            }
            Maticsoft.BLL.Manager man = new BLL.Manager();
            string string1 = string.Format("{0} = '{1}'", information, tbManager.Text.Trim());
            if (information == "manID")
            {
                Model.Manager manmodel = new Model.Manager();
                manmodel = man.GetModel1(string1);
                if(manmodel.manID == "" || manmodel.manID == null)
                {
                    MessageBox.Show("查无此人");
                }
                else
                {
                    SeekManager see = new Hotel.SeekManager(manmodel);
                    see.ShowDialog(this);
                } 
            }
            else
            {
                DataSet ds = new DataSet();
                ds = man.GetList(string1);
                dgvManager.DataSource = ds.Tables[0];
                ds.Tables[0].Columns["manID"].ColumnName = "前台工号";
                ds.Tables[0].Columns["manName"].ColumnName = "姓名";
                ds.Tables[0].Columns["manSex"].ColumnName = "性别";
                ds.Tables[0].Columns["manAge"].ColumnName = "年龄";
                ds.Tables[0].Columns["passwd"].ColumnName = "密码";
                dgvManager.AllowUserToAddRows = false;
                dgvManager.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }   
        }

        private void btSeeAllManagers_Click(object sender, EventArgs e)
        {
            ManagerLoad();
        }

        public void ManagerLoad()
        {
            Maticsoft.BLL.Manager man = new BLL.Manager();
            DataSet ds = new DataSet();
            string str1 = string.Format("manID != '离职'");
            ds = man.GetList(str1);
            dgvManager.DataSource = ds.Tables[0];
            ds.Tables[0].Columns["manID"].ColumnName = "前台工号";
            ds.Tables[0].Columns["manName"].ColumnName = "姓名";
            ds.Tables[0].Columns["manSex"].ColumnName = "性别";
            ds.Tables[0].Columns["manAge"].ColumnName = "年龄";
            ds.Tables[0].Columns["passwd"].ColumnName = "密码";
            dgvManager.AllowUserToAddRows = false;
            dgvManager.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void btAddManager_Click(object sender, EventArgs e)
        {
            AddManager ad = new Hotel.AddManager();
            ad.ShowDialog(this);
        }

        private void btUpdateManager_Click(object sender, EventArgs e)
        {
            AlterManager al = new Hotel.AlterManager();
            al.ShowDialog(this);
        }

        private void btDeleteManager_Click(object sender, EventArgs e)
        {
            DeleteManager del = new Hotel.DeleteManager();
            del.ShowDialog(this);
        }

        private void btSeeChargeInfo_Click(object sender, EventArgs e)
        {
            ChargeManager cha = new ChargeManager();
            cha.ShowDialog(this);
        }

        private void dgvManager_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Common.StaticClass.choose1 = dgvManager.SelectedRows[0].Cells[0].Value.ToString();
            SelectManager sel = new Hotel.SelectManager();
            sel.ShowDialog(this);
        }
    }
}
