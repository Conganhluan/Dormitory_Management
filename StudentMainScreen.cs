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
    public partial class StudentMainScreen : Form
    {
        public StudentMainScreen()
        {
            InitializeComponent();
        }

        private void usericon_Click(object sender, EventArgs e)
        {
            this.Hide();
            Studentinfo stinfo = new Studentinfo();
            stinfo.Show();
        }

        private void logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Program.LogOut();
        }

        private void paybill_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Program.student.PayRequest();
        }
    }
}
