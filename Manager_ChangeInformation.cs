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
    public partial class ChangeInformation : DMForm
    {
        public ChangeInformation()
        {
            InitializeComponent();
            NameInput.Text = Program.manager.GetName();
            EmailInput.Text = Program.manager.GetEmail();
            Information.Text = "Change personal information";
        }

        private void Return_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DMForm nextForm = new ViewInfoManager();
            Navigate(ref nextForm);
        }

        private void LogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DMForm startScreen = new StartScreen();
            Navigate(ref startScreen);
        }

        private void Send_Click(object sender, EventArgs e)
        {
            Program.manager.updateData(NameInput.Text, EmailInput.Text);
            MessageBox.Show("Change the information successfully!", "Update successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
