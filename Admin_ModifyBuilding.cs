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
            foreach (DataGridViewRow row in Table.Rows)
            {
                if (row.Cells[1].Value.ToString() != "Male" && row.Cells[1].Value.ToString() != "Female")
                {
                    MessageBox.Show("The gender of students staying at the building " + row.Cells[0].Value.ToString() + " is invalid!\n" +
                                    "It is " + row.Cells[1].Value.ToString() + ", neither Male nor Female.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
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
    }
}
