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
            if (managercb.Checked)
                Program.admin.AddManagers(filepath.Text);
            else
                Program.admin.AddStudents(filepath.Text);
            managercb.Checked = false;
            studentcb.Checked = false;
            filepath.Text = string.Empty;
            this.filepath_Leave(null, null);
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
    }
}
