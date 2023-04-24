using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DormitoryManagment
{
    public partial class ViewInfoManager : DMForm
    {
        public ViewInfoManager()
        {
            InitializeComponent();
            Values.Text = Program.manager.GetName() + "\n\n" + Program.manager.GetEmail();
        }

        private void LogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DMForm startScreen = new StartScreen();
            Navigate(ref startScreen);
        }

        private void Return_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DMForm mainScreen = new ManagerMainScreen();
            Navigate(ref mainScreen);
        }

        private void SendReport_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DMForm nextForm = new ChangeInformation();
            Navigate(ref nextForm);
        }

        private void ChangePass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DMForm nextForm = new ChangePass(Program.manager, "Manager");
            Navigate(ref nextForm);
        }
    }
}
