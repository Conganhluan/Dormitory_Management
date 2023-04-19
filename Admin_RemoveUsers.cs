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
    public partial class RemoveUsers : DMForm
    {
        public RemoveUsers()
        {
            InitializeComponent();
        }

        private void rmall_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Program.admin.RemoveUsers(filepath.Text);
            this.filepath.Text = string.Empty;
            this.filepath_Leave(null, null);
        }

        private void filepath_Leave(object sender, EventArgs e)
        {
            if (filepath.Text == "")
            {
                filepath.Text = "Path/to/file.csv";
                filepath.ForeColor = SystemColors.GrayText;
            }
        }

        private void filepath_Enter(object sender, EventArgs e)
        {
            filepath.Text = string.Empty;
            filepath.ForeColor = SystemColors.ControlText;
        }

        private void RETURN_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DMForm f = new AdminMainScreen();
            Navigate(ref f);
        }
    }
}
