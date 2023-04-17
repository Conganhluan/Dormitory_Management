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

        private void save_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (managerrb.Checked)
                Program.admin.AddManagers(filepath.Text);
            else if (studentrb.Checked)
                Program.admin.AddStudents(filepath.Text);
            else MessageBox.Show("Please enter the file path and choose Users' type!");
        }

        private void RETURN_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DMForm f = new AdminMainScreen();
            Navigate(ref f);
        }
    }
}
