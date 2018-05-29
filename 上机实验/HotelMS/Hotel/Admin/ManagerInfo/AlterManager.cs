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
    public partial class AlterManager : Form
    {
        Byte[] mybyte = null;
        string filename = "";
        string picturePath = "";
        int flag = 0;
        public AlterManager()
        {
            InitializeComponent();
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
                Maticsoft.BLL.Manager man = new BLL.Manager();
                string string1 = string.Format("manID = '{0}'", tbID.Text.Trim());
                if (man.GetRecordCount(string1) == 1)
                {
                    Model.Manager manmodel = new Model.Manager();
                    manmodel.manID = tbID.Text.Trim();
                    manmodel.manName = tbName.Text.Trim();
                    manmodel.manSex = cbSex.Text.Trim();
                    manmodel.manAge = Convert.ToInt32(nudAge.Value);
                    manmodel.passwd = null;
                    manmodel.manPhoto = mybyte;
                    if (man.Update(manmodel) == true)
                    {
                        MessageBox.Show("修改成功！");
                        ((Main_Admin)this.Owner).ManagerLoad();
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

        private void tbID_TextChanged_1(object sender, EventArgs e)
        {
            Maticsoft.BLL.Manager man = new BLL.Manager();
            string string1 = string.Format("manID = '{0}'", tbID.Text.Trim());
            if (man.GetRecordCount(string1) == 1)
            {
                Model.Manager manmodel = new Model.Manager();
                nudAge.Value = man.GetModel1(string1).manAge;
            }
            else
            {
                nudAge.Value = 18;
            }
        }

        private void labPhoto_Click(object sender, EventArgs e)
        {

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

        private void AlterManager_Load(object sender, EventArgs e)
        {
            cbSex.SelectedIndex = 0;
        }
    }
}
