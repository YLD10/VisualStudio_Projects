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
    public partial class DeleteStaff : Form
    {
        int flag = 0;
        public DeleteStaff()
        {
            InitializeComponent();
        }

        private void btcancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btConfirm_Click(object sender, EventArgs e)
        {
            if(tbStaffID.Text.Trim() == "")
            {
                MessageBox.Show("输入信息不完整！", "删除失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                flag = 1;
            }
            if(flag == 0)
            {
                if(tbStaffID.Text.Trim() != "离职")
                {
                    Maticsoft.BLL.Staff sta = new BLL.Staff();
                    string str1 = string.Format("staID = '{0}'", tbStaffID.Text.Trim());
                    string string1 = string.Format("{0}", tbStaffID.Text.Trim());
                    if (sta.GetRecordCount(str1) > 0)
                    {
                        if (sta.Delete(string1) == true)
                        {
                            MessageBox.Show("删除成功！");
                            ((Main_Admin)this.Owner).StaffLoad();
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("删除失败！");
                        }
                    }
                    else
                    {
                        MessageBox.Show("不存在此员工！", "删除失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("离职备份不可删除！", "删除失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                
            }
        }
    }
}
