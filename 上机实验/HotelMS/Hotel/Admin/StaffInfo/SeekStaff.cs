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
    public partial class SeekStaff : Form
    {
        private Model.Staff smodel;
        public SeekStaff(Model.Staff smo)
        {
            smodel = smo;
            InitializeComponent();
        }

        private void btConfirm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SeekStaff_Load(object sender, EventArgs e)
        {
            tbStaffID.Text = smodel.staID;
            tbStaffName.Text = smodel.staName;
            tbStaffSex.Text = smodel.staSex;
            tbStaffAge.Text = smodel.staAge.ToString();
            MemoryStream ms = new MemoryStream(smodel.staPhoto,0, smodel.staPhoto.Length);
            pbPhoto.Image = Image.FromStream(ms);
        }
    }
}
