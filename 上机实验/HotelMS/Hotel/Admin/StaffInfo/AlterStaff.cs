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
    public partial class AlterStaff : Form
    {
        Byte[] mybyte = null;
        string filename = "";
        string picturePath = "";
        int flag = 0;
        public AlterStaff()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btConfirm_Click(object sender, EventArgs e)
        {
            if (tbID.Text.Trim() == "")
            {
                MessageBox.Show("输入信息不完整！", "修改失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                flag = 1;
            }
            if (flag == 0)
            {
                Maticsoft.BLL.Staff sta = new BLL.Staff();
                string string1 = string.Format("staID = '{0}'",tbID.Text.Trim());
                if (sta.GetRecordCount(string1) == 1)
                {
                    Model.Staff stamodel = new Model.Staff();
                    stamodel.staID = tbID.Text.Trim();
                    stamodel.staName = tbName.Text.Trim();
                    stamodel.staSex = cbSex.Text.Trim();
                    stamodel.staAge = Convert.ToInt32(nudAge.Value);
                    stamodel.staPhoto = mybyte;
                    if (sta.Update(stamodel) == true)
                    {
                        MessageBox.Show("修改成功！");
                        ((Main_Admin)this.Owner).StaffLoad();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("修改失败！");
                    }
                }
                else
                {
                    MessageBox.Show("不存在此员工！", "修改出错", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void tbID_TextChanged(object sender, EventArgs e)
        {
            Maticsoft.BLL.Staff sta = new BLL.Staff();
            string string1 = string.Format("staID = '{0}'", tbID.Text.Trim());
            if (sta.GetRecordCount(string1) == 1)
            {
                Model.Staff stamodel = new Model.Staff();
                nudAge.Value = sta.GetModel1(string1).staAge;
            }
            else
            {
                nudAge.Value = 18;
            }
        }

        private void btScan_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filename = this.openFileDialog1.FileName;
                tbPath.Text = filename;
                picturePath = @filename;
                FileStream fs = new FileStream(picturePath, FileMode.Open, FileAccess.Read);
                Byte[] mybyte = new byte[fs.Length];
                fs.Read(mybyte, 0, mybyte.Length);       //把图片转化为2进制文件，储存在mybyte中
                fs.Close();
                MemoryStream ms = new MemoryStream(mybyte);
                pbPhoto.Image = Image.FromStream(ms);
            }
        }

        private void AlterStaff_Load(object sender, EventArgs e)
        {
            cbSex.SelectedIndex = 0;
        }
    }
}
