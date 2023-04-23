using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql;
using MySql.Data.MySqlClient;

namespace DormitoryManagment
{
    public partial class AddBuilding : DMForm
    {
        public AddBuilding()
        {
            InitializeComponent();
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Floor");
            dataTable.Columns.Add("Rooms' type");
            dataTable.Columns.Add("Number of room");
            Table.DataSource = dataTable;
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

        private void ModifyBuilding_Click(object sender, EventArgs e)
        {
            DMForm nextForm = new ModifyBuilding();
            Navigate(ref nextForm);
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

        private void Table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Gender__Click(object sender, EventArgs e)
        {

        }

        private void GenderInput_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Table_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
        }

        private void Table_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void SaveNewBuilding_Click(object sender, EventArgs e)
        {
            //Check before call the method to update the database
            if (NameInput.Text == "") 
            { 
                MessageBox.Show("The building's name is invalid!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (GenderInput.Text != "Male" && GenderInput.Text != "Female") 
            { 
                MessageBox.Show("The gender is invalid!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (FloorsInput.Value == 0)
            {
                MessageBox.Show("The number of floor is invalid!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DataTable data = Table.DataSource as DataTable;
            int totalNumOfRooms = 0;
            foreach (DataRow row in data.Rows)
            {
                byte typeRoom = Convert.ToByte(row[1]);
                int numRoom = Convert.ToInt32(row[2]);
                if (numRoom > 0 && (typeRoom < 2 || typeRoom > 8 || typeRoom%2 != 0)) 
                {
                    MessageBox.Show("The type of rooms in floor " + row[0].ToString() + " is invalid!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (numRoom < 0)
                {
                    MessageBox.Show("The number of room on floor " + row[0].ToString() + " is invalid!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                totalNumOfRooms += numRoom;
            }
            if (totalNumOfRooms == 0)
            {
                MessageBox.Show("There is no rooms added for the building!\nI can't add an empty building", "Add building failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //Update the database
            Program.admin.AddBuilding(NameInput.Text, GenderInput.Text, data);

            //Reset the page
            MessageBox.Show("Add a new building successfully!", "Successful update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DMForm nextForm = new AddBuilding();
            Navigate(ref nextForm);
        }

        private void FloorsInput_ValueChanged(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Floor");
            dataTable.Columns.Add("Rooms' type");
            dataTable.Columns.Add("Number of room");
            for (int i=1;i<=FloorsInput.Value;i++)
            {
                DataRow row = dataTable.NewRow();
                row[0] = i;
                row[1] = row[2] = 0;
                dataTable.Rows.Add(row);
            }
            Table.DataSource = dataTable;
        }
    }
}
