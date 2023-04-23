using MySql.Data.MySqlClient;
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
    public partial class ForgetPass : DMForm
    {
        static private int sentCount = 0;
        static private string sentEmail = null;
        public ForgetPass()
        {
            InitializeComponent();
        }

        private void Information_Click(object sender, EventArgs e)
        {

        }

        private void Send_Click(object sender, EventArgs e)
        {
            Program.conn.Open();
            string sql = "SELECT * FROM Users WHERE Email = '" + EmailInput.Text + "'";
            MySqlCommand cmd = new MySqlCommand(sql, Program.conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
            {
                if (sentCount >= 1 && sentEmail == EmailInput.Text) MessageBox.Show("I have sent again!\nCheck your email before click SEND more","Caution",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                else if (sentEmail != EmailInput.Text) sentCount = 0;
                NotFound.Visible = false;
                Sent.Visible = true;
                sentCount++;
            }
            else
            {
                NotFound.Visible = true;
                Sent.Visible = false;
            }
            rdr.Close();
            Program.conn.Close();
            sentEmail = EmailInput.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Return_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DMForm startScreen = new StartScreen();
            Navigate(ref startScreen);
        }
    }
}
