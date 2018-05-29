using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TransportLight
{
    public partial class Transport : Form
    {
        Image imgGreen = Image.FromFile(@"G:\上机文件\C#.Net\TransportLight\Images\green.jpg");   //绿灯
        Image imgRed = Image.FromFile(@"G:\上机文件\C#.Net\TransportLight\Images\red.jpg");   //红灯
        Image imgYellow = Image.FromFile(@"G:\上机文件\C#.Net\TransportLight\Images\yellow.jpg");   //黄灯

        int i = 20;

        public Transport()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (i == 0) i = 20;
            if (i > 13 && i <= 20)
            {
                pbUp.Image = imgRed;
                pbDown.Image = imgRed;
                pbLeft.Image = imgGreen;
                pbRight.Image = imgGreen;

                int j = i - 10;
                int k = i - 13;

                labUp.Text = j.ToString();
                labDown.Text = j.ToString();
                labLeft.Text = k.ToString();
                labRight.Text = k.ToString();

            }
            else
                if (i > 10 && i <= 13)
                {
                    pbUp.Image = imgRed;
                    pbDown.Image = imgRed;
                    pbLeft.Image = imgYellow;
                    pbRight.Image = imgYellow;

                    int j = i - 10;

                    labUp.Text = j.ToString();
                    labDown.Text = j.ToString();
                    labLeft.Text = j.ToString();
                    labRight.Text = j.ToString();
                }
                else
                    if (i > 3 && i <= 10)
                    {
                        pbUp.Image = imgGreen;
                        pbDown.Image = imgGreen;
                        pbLeft.Image = imgRed;
                        pbRight.Image = imgRed;

                        int j = i - 3;

                        labUp.Text = j.ToString();
                        labDown.Text = j.ToString();
                        labLeft.Text = i.ToString();
                        labRight.Text = i.ToString();
                    }
                    else
                    {
                        pbUp.Image = imgYellow;
                        pbDown.Image = imgYellow;
                        pbLeft.Image = imgRed;
                        pbRight.Image = imgRed;

                        labUp.Text = i.ToString();
                        labDown.Text = i.ToString();
                        labLeft.Text = i.ToString();
                        labRight.Text = i.ToString();
                    }

            --i;
        }

        private void btAction_Click(object sender, EventArgs e)
        {
            if (btAction.Text == "Start")
            {
                timer.Enabled = true;
                btAction.Text = "Stop";
            }
            else
            {
                timer.Enabled = false;
                btAction.Text = "Start";
            }
        }


    }
}
