using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DormitoryManagment
{
    public partial class ChangePass : DMForm
    {
        private Program.User currentUser;
        private string userRole;

        public ChangePass()
        {
            InitializeComponent();
            currentUser = null;
            userRole = "";
        }

        internal ChangePass(Program.User user, string role)
        {
            InitializeComponent();
            currentUser = user;
            userRole = role;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Confirm_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            currentUser.ChangePassword(OldPassword.Text, NewPassword.Text, ConfirmPassword.Text);
            OldPassword.Text = "";
            NewPassword.Text = "";
            ConfirmPassword.Text = "";
        }

        private void Return_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DMForm mainScreen = null;
            if (userRole == "Admin") { mainScreen = new AdminMainScreen(); }
            else if (userRole == "Manager") { mainScreen = new ManagerMainScreen(); }
            else if (userRole == "Student") { mainScreen = new StudentMainScreen(); }
            else
            {
                MessageBox.Show("Cannot specify the user's role!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Navigate(ref mainScreen);
        }
    }
}
