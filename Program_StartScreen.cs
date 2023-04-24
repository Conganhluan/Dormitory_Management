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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DormitoryManagment
{
    public partial class StartScreen : DMForm
    {
        public StartScreen()
        {
            InitializeComponent();
            if (Program.admin != null) Program.admin.LogOut();
            if (Program.manager != null) Program.manager.LogOut();
            if (Program.student != null) Program.student.LogOut();
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
            Program.conn.Open();
            string sql = "SELECT * FROM Users WHERE Username = '" + UsernameInput.Text + "'";
            MySqlCommand cmd = new MySqlCommand(sql, Program.conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            string password = null, role = null;
            bool onlineStatus = false;
            while (rdr.Read())
            {
                password = rdr.GetString("Password");
                role = rdr.GetString("Role");
                onlineStatus = rdr.GetBoolean("Online");
            }
            rdr.Close();
            Program.conn.Close();
            if (password == null)
            {
                MessageBox.Show("The username is not found!", "Login failed", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            } 
            else if (password != PasswordInput.Text)
            {
                MessageBox.Show("The password is incorrect!", "Login failed", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            else
            {
                if (role == null) { MessageBox.Show("Cannot specify the role for this user!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                else if (onlineStatus) { MessageBox.Show("You can't login into 1 account many times simultaneously", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
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
                    Program.conn.Open();
                    sql = "UPDATE Users SET Online = 1 WHERE Username = '" + UsernameInput.Text + "'";
                    cmd = new MySqlCommand(sql, Program.conn);
                    cmd.ExecuteNonQuery();
                    Program.conn.Close();
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

        private void UsernameInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (UsernameInput.Text != "")
                if (e.KeyCode == Keys.Enter)
                    this.pictureBox1_Click(this, null);
        }

        private void PasswordInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (PasswordInput.Text != "")
                if (e.KeyCode == Keys.Enter)
                    this.pictureBox1_Click(this, null);
        }
    }
}
