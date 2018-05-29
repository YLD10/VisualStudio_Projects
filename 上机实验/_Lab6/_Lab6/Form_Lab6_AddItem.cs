using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _Lab6
{
    public partial class Form_Lab6_AddItem : Form
    {
        public Form_Lab6_AddItem()
        {
            InitializeComponent();
            cboCategoryAddItem.SelectedIndex = 0;
            rbInAddItem.Checked = true;
        }

        private void cboCategoryAddItem_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            e.DrawFocusRectangle();
            StringFormat strFmt = new System.Drawing.StringFormat();
            e.Graphics.DrawString(cboCategoryAddItem.Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor), e.Bounds, strFmt);
        }

        private void btPreviewAddItem_Click(object sender, EventArgs e)
        {
            string itemName = tbItemNameAddItem.Text.Trim();
            string typeInOut = "";
            string itemCategory = cboCategoryAddItem.SelectedItem.ToString();

            if (rbInAddItem.Checked)
            {
                typeInOut = rbInAddItem.Text;
            } 
            else
            {
                typeInOut = rbOutAddItem.Text;
            }

            if (itemName != "")
            {
                tbManifestAddItem.Text = string.Format("要添加的收支指项目为：{0}{1}所属类别：{2}{1}是{3}类型的项目",itemName,System.Environment.NewLine,itemCategory,typeInOut);
                tcAddItem.SelectedIndex = 1;

            }
            else
            {
                MessageBox.Show("项目名称不能为空！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbItemNameAddItem.Focus();
            }
        }

        private void btConfirmAddItem_Click(object sender, EventArgs e)
        {
            if (tbManifestAddItem.Text != "")
            {
                MessageBox.Show("添加成功！", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbItemNameAddItem.Text = "";
                tbManifestAddItem.Text = "";
            }
            else
            {
                MessageBox.Show("请先填写信息！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tcAddItem.SelectedIndex = 0;
            }
        }
    }
}
