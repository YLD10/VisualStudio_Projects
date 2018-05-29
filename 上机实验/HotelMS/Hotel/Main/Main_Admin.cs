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
    public partial class Main_Admin : Form
    {
        private int sortOrder = 0;

        public Main_Admin()
        {
            InitializeComponent();
        }

        private void Main_Admin_Load(object sender, EventArgs e)
        {
            this.Tag = "Close";
            tsslabWelcome.Text = Common.StaticClass.userName + "，欢迎您！";
            combCustomerLive.SelectedIndex = 0;
            combCusHisRec.SelectedIndex = 0;
            combManager.SelectedIndex = 0;
            combRoomGoods.SelectedIndex = 0;
            combStaff.SelectedIndex = 0;

            dgvAdmin_Load();
            LoadData_RoomInfo();
            LoadData_RoomTypeInfo();
            LoadData_CustomerLiveInfo();
            LoadData_CustomerHistoryRecordInfo();
        }

        private void labLogout_Click(object sender, EventArgs e)
        {
            ((login)this.Owner).Show();

            this.Tag = "Logout";
            this.Dispose();
            this.Close();
        }

        private void labHelp_Click(object sender, EventArgs e)
        {
            
        }

        private void Main_Admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.Tag.ToString() == "Close")
            {
                login login = (login)this.Owner;
                login.Dispose();
                login.Close();
            }
        }
    }
}
