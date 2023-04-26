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
    public partial class AdminMainScreen : DMForm
    {
        public AdminMainScreen()
        {
            InitializeComponent();
        }

        private void HomePic_Click(object sender, EventArgs e)
        {
            DMForm changePass = new ChangePass(Program.admin, "Admin");
            Navigate(ref changePass);
        }

        private void LogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DMForm startScreen = new StartScreen();
            Navigate(ref startScreen);
        }

        private void AdminMainScreen_Load(object sender, EventArgs e)
        {

        }

        private void AddBuilding_Click_1(object sender, EventArgs e)
        {
            DMForm nextForm = new AddBuilding();
            Navigate(ref nextForm);
        }

        private void ModifyBuilding_Click_1(object sender, EventArgs e)
        {
            DMForm nextForm = new ModifyBuilding();
            Navigate(ref nextForm);
        }

        private void AddUsers_Click_1(object sender, EventArgs e)
        {
            DMForm nextForm = new AddUsers();
            Navigate(ref nextForm);
        }

        private void RemoveUsers_Click_1(object sender, EventArgs e)
        {
            DMForm nextForm = new RemoveUsers();
            Navigate(ref nextForm);
        }

        private void BigLogo_Click(object sender, EventArgs e)
        {
            DMForm mainScreen = new AdminMainScreen();
            Navigate(ref mainScreen);
        }
    }
}
