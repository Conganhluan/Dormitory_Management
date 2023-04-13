using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DormitoryManagment
{
    public partial class StartScreen : DMForm
    {
        public StartScreen()
        {
            InitializeComponent();
            Program.admin = null;
            Program.manager = null;
            Program.student = null;
        }

        private void StartScreen_Load(object sender, EventArgs e)
        {
    
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM Users WHERE Username = '" + UsernameInput.Text + "'";
            MySqlCommand cmd = new MySqlCommand(sql, Program.conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            string password = null, role = null;
            while (rdr.Read())
            {
                password = rdr.GetString("Password");
                role = rdr.GetString("Role");
            }
            rdr.Close();
            if (password == null)
            {
                MessageBox.Show("The username is not found!", "Login failed", MessageBoxButtons.OK);
            } 
            else if (password != PasswordInput.Text)
            {
                MessageBox.Show("The password is incorrect!", "Login failed", MessageBoxButtons.OK);
            }
            else
            {
                if (role == "") { MessageBox.Show("Cannot specify the role for this user!", "Error"); }
                else
                {
                    DMForm mainScreen = null;
                    if (role == "Admin")
                    {
                        Program.admin = new Program.Admin(password);
                        mainScreen = new AdminMainScreen();
                    }
                    else if (role == "Manager")
                    {
                        Program.manager = new Program.Manager(UsernameInput.Text);
                        mainScreen = new ManagerMainScreen();
                    }
                    else if (role == "Student")
                    {
                        Program.student = new Program.Student(UsernameInput.Text);
                        mainScreen = new StudentMainScreen();
                    }
                    this.Hide();
                    Navigate(ref mainScreen);
                }
                
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DMForm newForm = new ForgetPass();
            Navigate(ref newForm);
        }

        private void Crucial_Click(object sender, EventArgs e)
        {

        }
    }
}
