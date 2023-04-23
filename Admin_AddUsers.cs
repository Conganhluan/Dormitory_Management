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
    public partial class AddUsers : DMForm
    {
        public AddUsers()
        {
            InitializeComponent();
        }

        private void RETURN_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DMForm f = new AdminMainScreen();
            Navigate(ref f);
        }

        private void managerrb_CheckedChanged(object sender, EventArgs e)
        {
            studentcb.Checked = false;
        }

        private void studentrb_CheckedChanged(object sender, EventArgs e)
        {
            managercb.Checked = false;
        }

        private void filepath_Enter(object sender, EventArgs e)
        {
            filepath.Text = "";
            filepath.ForeColor = SystemColors.ControlText;
        }

        private void filepath_Leave(object sender, EventArgs e)
        {
            if (filepath.Text == "")
            {
                filepath.Text = "Path/to/file.csv";
                filepath.ForeColor = SystemColors.GrayText;
            }
        }

        private void classing_Click(object sender, EventArgs e)
        {

        }

        private void SaveNewBuilding_Click(object sender, EventArgs e)
        {
            if (managercb.Checked)
                Program.admin.AddManagers(filepath.Text);
            else if (studentcb.Checked)
                Program.admin.AddStudents(filepath.Text);
            else
            {
                MessageBox.Show("You haven't chosen the type of user yet!", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            managercb.Checked = false;
            studentcb.Checked = false;
            filepath.Text = string.Empty;
            this.filepath_Leave(null, null);
        }

        private void filepath_TextChanged(object sender, EventArgs e)
        {

        }

        private void LogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DMForm startScreen = new StartScreen();
            Navigate(ref startScreen);
        }

        private void HomePic_Click(object sender, EventArgs e)
        {
            DMForm nextForm = new ChangePass(Program.admin, "Admin");
            Navigate(ref nextForm);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DMForm nextForm = new AddBuilding();
            Navigate(ref nextForm);
        }

        private void ModifyBuilding_Click(object sender, EventArgs e)
        {
            DMForm nextForm = new ModifyBuilding();
            Navigate(ref nextForm);
        }

        private void RemoveUsers_Click(object sender, EventArgs e)
        {
            DMForm nextForm = new RemoveUsers();
            Navigate(ref nextForm);
        }
    }
}
