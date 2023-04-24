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
    public partial class ManageStudent : DMForm
    {
        static string filter = "1";
        static DataTable dataTable = null;
        static long count = 0;
        static long page = 1;
        static int numberOfLines = 25;

        public ManageStudent()
        {
            InitializeComponent();
            UpdateTable();
            Information.Text = "Welcome back " + Program.manager.GetName();
            numericUpDown1.Maximum = count;
        }

        private void UpdateTable()
        {
            string sql = "SELECT * FROM Students";
            if (Key.SelectedItem == null || Key.Text == "None") filter = "1";
            else filter = "BINARY `" + Key.Text + "` LIKE BINARY '%" + Value.Text + "%'"; 
            sql += " WHERE " + filter + " LIMIT " + ((page-1)*numberOfLines).ToString() + "," + numberOfLines.ToString();
            dataTable = DataBase.GetDataSource(sql);
            Table.DataSource = dataTable;
            Program.conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM Students" + " WHERE " + filter, Program.conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            count = reader.GetInt64(0);
            reader.Close();
            Program.conn.Close();
            PageTotal.Text = "/" + (count / numberOfLines + 1).ToString() + " Pages";
        }

        private void AddStudents_Click(object sender, EventArgs e)
        {
            DMForm nextForm = new AddStudents();
            Navigate(ref nextForm);
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            UpdateTable();
        }

        private void AddBills_Click(object sender, EventArgs e)
        {
            DMForm nextForm = new AddBills();
            Navigate(ref nextForm);
        }

        private void ReviewRequests_Click(object sender, EventArgs e)
        {
            DMForm nextForm = new ReviewRequests();
            Navigate(ref nextForm);
        }

        private void HomePic_Click(object sender, EventArgs e)
        {
            DMForm nextForm = new ViewInfoManager();
            Navigate(ref nextForm);
        }

        private void LogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DMForm startScreen = new StartScreen();
            Navigate(ref startScreen);
        }

        private void Save_Click(object sender, EventArgs e)
        {
            DataBase.SaveChanges(dataTable);
            UpdateTable();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in Table.SelectedRows)
            {
                Program.manager.RemoveStudent(row.Cells[5].ToString(), row.Cells[6].ToString());
                DataBase.SaveChanges(dataTable);
                UpdateTable();
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            page = Convert.ToInt32(numericUpDown1.Value);
            UpdateTable();
        }
    }
}
