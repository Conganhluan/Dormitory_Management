using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace DormitoryManagment
{
    public partial class ManagerMainScreen : DMForm
    {
        public ManagerMainScreen()
        {
            InitializeComponent();
            Information.Text = "Welcome back " + Program.manager.GetName();
        }

        private void LogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Program.manager.LogOut();
            DMForm startScreen = new StartScreen();
            Navigate(ref startScreen);
        }

        private void HomePic_Click(object sender, EventArgs e)
        {
            DMForm nextForm = new ViewInfoManager();
            Navigate(ref nextForm);
        }

        private void Students_Click(object sender, EventArgs e)
        {
            DMForm nextForm = new StudentManage();
            Navigate(ref nextForm);
        }

        private void Rooms_Click(object sender, EventArgs e)
        {
            DMForm nextForm = new BillManage();
            Navigate(ref nextForm);
        }
    }
}
