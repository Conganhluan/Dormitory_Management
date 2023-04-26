using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace DormitoryManagment
{
    public partial class ModifyBuilding : DMForm
    {
        DataView dataView;
        string filterName;
        string filterGender;

        public ModifyBuilding()
        {
            InitializeComponent();
            filterName = "Name LIKE '*'";
            filterGender = "Gender LIKE '*'";
            UpdateTable();
        }

        private void UpdateTable()
        {
            dataView = new DataView(DataBase.GetDataSource("SELECT * FROM Buildings"));
            dataView.RowFilter = filterName + " AND " + filterGender;
            Table.DataSource = dataView;
            Table.Columns[0].ReadOnly = true;
        }

        private void ModifyBuilding_Load(object sender, EventArgs e)
        {
            Table.DataSource = new DataView(DataBase.GetDataSource("SELECT * FROM Buildings"));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "All") { filterGender = "Gender LIKE '*'"; }
            else { filterGender = "Gender = '" + comboBox1.Text + "'"; }
            if (NameInput.Text == "") { filterName = "Name LIKE '*'"; }
            else { filterName = "Name LIKE '*" + NameInput.Text + "*'"; }
            UpdateTable();
        }

        private void NameBox_Enter(object sender, EventArgs e)
        {

        }

        private void SaveChanges(object sender, EventArgs e)
        {
            DataTable oldDT = DataBase.GetDataSource("SELECT * FROM Buildings");
            foreach (DataGridViewRow row in Table.Rows)
            {
               if (row.Cells[1].Value.ToString() != oldDT.Rows[row.Index][1].ToString())
                {   
                    string building = row.Cells[0].Value.ToString(), gender = row.Cells[1].Value.ToString();
                    if (gender != "Male" && gender != "Female")
                    {
                        MessageBox.Show("The gender of students staying at the building " + building + " is invalid!\n" +
                                        "It is " + gender + ", neither Male nor Female.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    Program.conn.Open();
                    string sql = "SELECT * FROM Students WHERE `Building name` = '" + building + "'";
                    MySqlCommand cmd = new MySqlCommand(sql, Program.conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        MessageBox.Show("There are students staying at this building, you can't change its gender!", "Warning",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        UpdateTable();
                        reader.Close();
                        Program.conn.Close();
                        return;
                    }
                    reader.Close();
                    Program.conn.Close();
                }
            }
            DataBase.SaveChanges(((DataView)Table.DataSource).Table.Copy());
            UpdateTable();
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

        private void AddBuilding_Click(object sender, EventArgs e)
        {
            DMForm nextForm = new AddBuilding();
            Navigate(ref nextForm);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void AddUsers_Click(object sender, EventArgs e)
        {
            DMForm nextForm = new AddUsers();
            Navigate(ref nextForm);
        }

        private void RemoveUsers_Click(object sender, EventArgs e)
        {
            DMForm nextForm = new RemoveUsers();
            Navigate(ref nextForm);
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in Table.SelectedRows)
            {
                string building = row.Cells[0].Value.ToString();
                Program.conn.Open();
                string sql = "SELECT * FROM Students WHERE `Building name` = '" + building + "'";
                MySqlCommand cmd = new MySqlCommand(sql, Program.conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    MessageBox.Show("There are students staying at this building, you can't delete it!", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    UpdateTable();
                    reader.Close();
                    Program.conn.Close();
                    return;
                }
                Table.Rows.Remove(row);
                DataBase.SaveChanges(((DataView)Table.DataSource).Table.Copy());
                Program.conn.Close();
            } 
            
        }

        private void BigLogo_Click(object sender, EventArgs e)
        {
            DMForm mainScreen = new AdminMainScreen();
            Navigate(ref mainScreen);
        }
    }
}
