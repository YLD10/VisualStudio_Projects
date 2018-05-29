using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace Lab6
{
    partial class Form_Lab6_AboutBox_Us : Form
    {
        public Form_Lab6_AboutBox_Us()
        {
            InitializeComponent();
        }

        private void btConfirmAbout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
