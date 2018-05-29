using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace lab4
{
    public partial class TransportLight : Form
    {

        private int i = 60;

        public TransportLight()
        {
            InitializeComponent();
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            if (btStart.Text == "Start")
            {
                Timer.Enabled = true;
                btStart.Text = "Stop";
            }
            else
            {
                Timer.Enabled = false;
                btStart.Text = "Start";
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            labLeft.Visible = true;
            labUp.Visible = true;
            labRight.Visible = true;
            labDown.Visible = true;

            if (i == 0) i = 60;

            if (i > 30)
            {
                pbLeftTurnLeft.Image = ilAll.Images[1];
                pbLeftStraight1.Image = pbLeftStraight2.Image = ilAll.Images[5];
                labLeft.ForeColor = Color.Red;
                labLeft.Text = (100 + (i - 30)).ToString().Substring(1, 2);

                pbRightTurnLeft.Image = ilAll.Images[7];
                pbRightStraight1.Image = pbRightStraight2.Image = ilAll.Images[9];
                labRight.ForeColor = Color.Red;
                labRight.Text = (100 + (i - 30)).ToString().Substring(1, 2);


                if (i > 43)
                {
                    pbUpTurnLeft.Image = ilAll.Images[5];
                    pbUpStraight1.Image = pbUpStraight2.Image = ilAll.Images[3];
                    labUp.ForeColor = Color.Green;
                    labUp.Text = (100 + (i - 30 - 13)).ToString().Substring(1, 2);

                    pbDownTurnLeft.Image = ilAll.Images[9];
                    pbDownStraight1.Image = pbDownStraight2.Image = ilAll.Images[0];
                    labDown.ForeColor = Color.Green;
                    labDown.Text = (100 + (i - 30 - 13)).ToString().Substring(1, 2);
                }
                else
                {
                    if (i > 40)
                    {
                        pbUpTurnLeft.Image = ilAll.Images[5];
                        pbUpStraight1.Image = pbUpStraight2.Image = ilAll.Images[12];
                        labUp.ForeColor = Color.Yellow;
                        labUp.Text = (100 + (i - 30 - 10)).ToString().Substring(1, 2);

                        pbDownTurnLeft.Image = ilAll.Images[9];
                        pbDownStraight1.Image = pbDownStraight2.Image = ilAll.Images[2];
                        labDown.ForeColor = Color.Yellow;
                        labDown.Text = (100 + (i - 30 - 10)).ToString().Substring(1, 2);
                    }
                }

                if (i <= 40)
                {

                    if (i <= 33)
                    {
                        pbUpTurnLeft.Image = ilAll.Images[6];
                        pbDownTurnLeft.Image = ilAll.Images[10];
                        pbUpStraight1.Image = pbUpStraight2.Image = ilAll.Images[7];
                        labUp.ForeColor = Color.Green;
                        labUp.Text = (100 + (i - 30 - 3)).ToString().Substring(1, 2);

                        pbDownStraight1.Image = pbDownStraight2.Image = ilAll.Images[1];
                        labDown.ForeColor = Color.Green;
                        labDown.Text = (100 + (i - 30 - 3)).ToString().Substring(1, 2);
                    }
                    else
                    {
                        pbUpTurnLeft.Image = ilAll.Images[4];
                        pbDownTurnLeft.Image = ilAll.Images[8];
                        pbUpStraight1.Image = pbUpStraight2.Image = ilAll.Images[7];
                        labUp.ForeColor = Color.Yellow;
                        labUp.Text = (100 + (i - 30)).ToString().Substring(1, 2);

                        pbDownStraight1.Image = pbDownStraight2.Image = ilAll.Images[1];
                        labDown.ForeColor = Color.Yellow;
                        labDown.Text = (100 + (i - 30)).ToString().Substring(1, 2);
                    }
                }

            }
            else
            {

            }
            -- i;
        }
    }
}
