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
    public partial class AddManager : Form
    {
        Byte[] mybyte = null;
        string filename = "";
        int flag = 0;
        string picturePath = "";
        public AddManager()
        {
            InitializeComponent();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btConfirm_Click(object sender, EventArgs e)
        {
            if (tbID.Text.Trim() == "" || tbName.Text.Trim() == "" || cbSex.Text == "" || nupAge.Value.ToString() == "" || pbPhoto.Image == null)
            {
                MessageBox.Show("输入信息不完整！", "添加失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                flag = 1;
            }
            if (flag == 0)
            {
                Maticsoft.BLL.Manager man = new BLL.Manager();
                Model.Manager manmodel = new Model.Manager();
                string str1 = string.Format("manID = '{0}'", tbID.Text.Trim());
                if (man.GetRecordCount(str1) > 0)
                {
                    MessageBox.Show("当前工号已存在！", "添加失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {   
                    manmodel.manID = tbID.Text.Trim();
                    manmodel.manName = tbName.Text.Trim();
                    manmodel.manSex = cbSex.Text.Trim();
                    manmodel.manAge = Convert.ToInt32(nupAge.Value);
                    manmodel.passwd = null;
                    manmodel.manPhoto = mybyte;
            
                    if (man.Add(manmodel) == true)
                    {
                        MessageBox.Show("添加成功！");
                        ((Main_Admin)this.Owner).ManagerLoad();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("添加失败！");
                    }
                }
            }
        }

        private void btSearch_Click(object sender, EventArgs e)
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

        private void AddManager_Load(object sender, EventArgs e)
        {
            cbSex.SelectedIndex = 0;
        }
    }
}
