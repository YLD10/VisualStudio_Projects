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
* @date : 2017/5/1 23:13
* @last change : 
*****************************************************************************/

namespace lab3
{
    public partial class calcu : Form
    {
        public calcu()
        {
            InitializeComponent();
        }

        private bool Alert(int flag)
        {
            switch (flag) 
            {
                case 1:
                    if (tbNumberA.Text == "" || tbNumberB.Text == "")
                    {
                        MessageBox.Show("不能为空！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return true ; 
                    }
                    break;
                case 2:
                    if (tbNumberA2.Text == "" || tbNumberB2.Text == "" || tbOperator.Text == "")
                    {
                        MessageBox.Show("不能为空！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return true;
                    }
                    break;
            }
            return false;
        } 

        private void btPlus_Click(object sender, EventArgs e)
        {
            if (Alert(1)) return;
            labResult.Text = "a + b = " +
                            Convert.ToString(Convert.ToDouble(tbNumberA.Text) + Convert.ToDouble(tbNumberB.Text));
            labResult.Visible = true;
        }

        private void btMinus_Click(object sender, EventArgs e)
        {
            if (Alert(1)) return;
            labResult.Text = "a - b = " +
                Convert.ToString(Convert.ToDouble(tbNumberA.Text) - Convert.ToDouble(tbNumberB.Text));
            labResult.Visible = true;
        }

        private void btMultiply_Click(object sender, EventArgs e)
        {
            if (Alert(1)) return;
            labResult.Text = "a * b = " +
                Convert.ToString(Convert.ToDouble(tbNumberA.Text) * Convert.ToDouble(tbNumberB.Text));
            labResult.Visible = true;
        }

        private void btDivide_Click(object sender, EventArgs e)
        {
            if (Alert(1)) return;
            if (Convert.ToDouble(tbNumberB.Text) == 0)
            {
                MessageBox.Show("b不能为0！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            } 
            labResult.Text = "a / b = " +
                Convert.ToString(Convert.ToDouble(tbNumberA.Text) / Convert.ToDouble(tbNumberB.Text));
            labResult.Visible = true;
        }

        private void btPow_Click(object sender, EventArgs e)
        {
            if (Alert(1)) return;
            labResult.Text = "a ^ b = " +
                Convert.ToString(Math.Pow(Convert.ToDouble(tbNumberA.Text),Convert.ToDouble(tbNumberB.Text)));
            labResult.Visible = true;
        }

        private void tbNumberA_TextChanged(object sender, EventArgs e)
        {
            labResult.Visible = false;
        }

        /************************************************************************/
        /*                                                                      */
        /************************************************************************/

        private void Plus()
        {
            tbResult.Text = Convert.ToString(Convert.ToDouble(tbNumberA2.Text) + Convert.ToDouble(tbNumberB2.Text)); 
        }

        private void Minus()
        {
            tbResult.Text = Convert.ToString(Convert.ToDouble(tbNumberA2.Text) - Convert.ToDouble(tbNumberB2.Text));
        }

        private void Multiply()
        {
            tbResult.Text = Convert.ToString(Convert.ToDouble(tbNumberA2.Text) * Convert.ToDouble(tbNumberB2.Text));
        }

        private void Divide()
        {
            if (Convert.ToDouble(tbNumberB2.Text) == 0)
            {
                MessageBox.Show("b不能为0！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            tbResult.Text = Convert.ToString(Convert.ToDouble(tbNumberA2.Text) / Convert.ToDouble(tbNumberB2.Text));
        }

        private void Remainder()
        {
            tbResult.Text = Convert.ToString(Convert.ToDouble(tbNumberA2.Text) % Convert.ToDouble(tbNumberB2.Text));
        }

        private void Pow()
        {
            tbResult.Text = Convert.ToString(Math.Pow(Convert.ToDouble(tbNumberA2.Text),Convert.ToDouble(tbNumberB2.Text)));
        }

        private void btCalculate_Click(object sender, EventArgs e)
        {
            if (Alert(2)) return;
            switch (tbOperator.Text) 
            {
               case "+":
                        Plus();
                        break;
               case "-":
                        Minus();
                        break;
               case "*":
                        Multiply();
                        break;
               case "/":
                        Divide();
                        break;
               case "%":
                        Remainder();
                        break;
               case "^":
                        Pow();
                        break;
               default :
                        MessageBox.Show("非法运算符！","错误",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        break;
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            tbNumberA2.Text = "";
            tbOperator.Text = "";
            tbNumberB2.Text = "";
        }

        private void tbNumberA2_TextChanged(object sender, EventArgs e)
        {
            tbResult.Text = "";
        }

    }
}
