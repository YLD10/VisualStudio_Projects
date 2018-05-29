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
    public partial class SeekManager : Form
    {
        private Model.Manager manmodel;
        public SeekManager(Model.Manager man)
        {
            manmodel = man;
            InitializeComponent();
        }

        private void SeekManager_Load(object sender, EventArgs e)
        {
            tbID.Text = manmodel.manID;
            tbName.Text = manmodel.manName;
            tbSex.Text = manmodel.manSex;
            tbAge.Text = manmodel.manAge.ToString();
            tbPasswd.Text = manmodel.passwd;
            MemoryStream ms = new MemoryStream(manmodel.manPhoto,0,manmodel.manPhoto.Length);
            pbPhoto.Image = Image.FromStream(ms);
        }

        private void btConfirm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
