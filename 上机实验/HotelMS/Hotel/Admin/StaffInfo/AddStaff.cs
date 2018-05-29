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
    public partial class AddStaff : Form
    {
        Byte[] mybyte = null;
        string filename = "";
        int flag = 0;
        string picturePath = "";
        public AddStaff()
        {
            InitializeComponent();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btConfirm_Click(object sender, EventArgs e)
        {
            if (tbStaffID.Text.Trim() == "" || tbStaffName.Text.Trim() == "" || cbStaffSex.Text == "" || nupStaffAge.Value.ToString() == "" || pbPhoto.Image == null)
            {
                MessageBox.Show("输入信息不完整！", "添加失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                flag = 1;
            }
            if (flag == 0)
            {
                Maticsoft.BLL.Staff sta = new BLL.Staff();
                Model.Staff stamodel = new Model.Staff();
                string str1 = string.Format("staID = '{0}'", tbStaffID.Text.Trim());
                if (sta.GetRecordCount(str1) > 0)
                {
                    MessageBox.Show("当前工号已存在！", "添加失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    stamodel.staID = tbStaffID.Text.Trim();
                    stamodel.staName = tbStaffName.Text.Trim();
                    stamodel.staSex = cbStaffSex.Text.Trim();
                    stamodel.staAge = Convert.ToInt32(nupStaffAge.Value);
                    stamodel.staPhoto = mybyte;    
                    if (sta.Add(stamodel) == true)
                    {
                        MessageBox.Show("添加成功！");
                        ((Main_Admin)this.Owner).StaffLoad();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("添加失败！");
                    }
                }
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

        private void AddStaff_Load(object sender, EventArgs e)
        {
            cbStaffSex.SelectedIndex = 0;
        }
    }
}
