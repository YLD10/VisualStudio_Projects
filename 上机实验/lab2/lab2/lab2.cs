using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/*****************************************************************************
* @author : YLD10
* @date : 2017/4/25 22:19
* @last change : 
*****************************************************************************/

namespace lab2
{
    public partial class lab2Form : Form
    {
        int count = 0;
        float[] array = new float[5];

        public lab2Form()
        {
            InitializeComponent(); 
        }

        private bool Alert(int flag)
        {   
            switch (flag)
            {
                case 1:
                    if (tbCelsius.Text == "" && tbFahrenheit.Text == "")
                    {
                        MessageBox.Show("不能为空！","警告",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                        return true;
                    }
                    break;
                case 2:
                    if (tbMoney.Text == "" || tbRate.Text == "" || tbYear.Text == "")
                    {
                        MessageBox.Show("不能为空！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return true;
                    }
                    break;
                case 3:
                    if (tbNumber.Text == "")
                    {
                        MessageBox.Show("不能为空！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return true;
                    }
                    break;
                
            }
            return false;
        }

        private void btChange_Click(object sender, EventArgs e)
        {
            if (Alert(1)) return;

            if (tbFahrenheit.Text == "")
            {
                float cel = Convert.ToSingle(tbCelsius.Text);
                tbFahrenheit.Text = Convert.ToString(cel * 9 / 5 + 32);
                return;
            }

            if (tbCelsius.Text == "")
            {
                float fah = Convert.ToSingle(tbFahrenheit.Text);
                tbCelsius.Text = Convert.ToString((fah - 32) * 5 / 9);
                return;
            }
        }

        private void tbCelsius_Click(object sender, EventArgs e)
        {
            tbCelsius.Text = "";
            tbFahrenheit.Text = "";
        }

        private void btCalculate_Click(object sender, EventArgs e)
        {
            if (Alert(2)) return;
            float money = Convert.ToSingle(tbMoney.Text);
            float rate = Convert.ToSingle(tbRate.Text) / 100;
            float year = Convert.ToSingle(tbYear.Text);
            tbInterest.Text = Convert.ToString(money * rate * year);
            tbTotal.Text = Convert.ToString(money * (rate+1) * year);
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (Alert(3)) return;

            if (count < 5)
            {
                ++count;
                float[] arrayBefore = new float[count];
                
                float num = Convert.ToSingle(tbNumber.Text);
                array[count - 1] = num;
                Array.Copy(array, arrayBefore, count);
                
                tbBefore.Text += Convert.ToString(arrayBefore[count - 1]) + " ";

                if (count < 5)
                {
                    labMessage.Text = "请输入第" + Convert.ToString(count + 1) + "个元素：";
                }
                else
                {
                    btReset.Visible = true;
                    btAdd.FlatStyle = FlatStyle.Flat;
                    labMessage.Visible = false;
                    tbNumber.Visible = false;
                }
                
            }
        }

        private void btAscend_Click(object sender, EventArgs e)
        {
            if (Alert(3)) return;
            float[] arrayAfter = new float[count];   
            Array.Copy(array, arrayAfter, count);
            Array.Sort(arrayAfter);
            tbAfter.Text = "";
            foreach (float f in arrayAfter)
            {
                tbAfter.Text += Convert.ToString(f) + " ";
            }
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            count = 0;
            tbBefore.Text = "";
            tbAfter.Text = "";
            tbNumber.Text = "";
            labMessage.Text = "请输入第" + Convert.ToString(1) + "个元素：";
            Array.Clear(array,0,5);
            btReset.Visible = false;
            btAdd.FlatStyle = FlatStyle.Standard;
            labMessage.Visible = true;
            tbNumber.Visible = true;
            tbNumber.Focus();
        }
    }
}
