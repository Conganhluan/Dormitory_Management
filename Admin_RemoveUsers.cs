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
    public partial class RemoveUsers : DMForm
    {
        DataView dataView;
        string filterName;
        public RemoveUsers()
        {
            InitializeComponent();
            filterName = "Name LIKE '*'";
            UpdateTable();
        }

        private void UpdateTable()
        {
            dataView = new DataView(DataBase.GetDataSource("SELECT `Username`, `Name`, `Role` FROM Users WHERE NOT Role = 'admin'"));
            dataView.RowFilter = filterName;
            Table.DataSource = dataView;
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

        private void RemoveUsersButton_Click(object sender, EventArgs e)
        {
            Program.admin.RemoveUsers(filepath.Text);
            this.filepath.Text = string.Empty;
            this.filepath_Leave(null, null);
            UpdateTable();
        }

        private void HomePic_Click(object sender, EventArgs e)
        {
            DMForm nextForm = new ChangePass(Program.admin, "Admin");
            Navigate(ref nextForm);
        }

        private void LogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DMForm startScreen = new StartScreen();
            Navigate(ref startScreen);
        }

        private void AddBuilding_Click(object sender, EventArgs e)
        {
            DMForm nextForm = new AddBuilding();
            Navigate(ref nextForm);
        }

        private void ModifyBuilding_Click(object sender, EventArgs e)
        {
            DMForm nextForm = new ModifyBuilding();
            Navigate(ref nextForm);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DMForm nextForm = new AddUsers();
            Navigate(ref nextForm);
        }

        private void RemoveUserButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in Table.SelectedRows)
            {
                Program.conn.Open();
                string sql = "DELETE FROM Users WHERE Username = '" + row.Cells[0].Value + "'";
                MySqlCommand cmd = new MySqlCommand(sql, Program.conn);
                cmd.ExecuteNonQuery();
                Program.conn.Close();
                MessageBox.Show("Successfully delete the chosen user!", "Delete successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Table.Rows.Remove(row);
            }
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            if (NameInput.Text == "") { filterName = "Name LIKE '*'"; }
            else { filterName = "Name LIKE '*" + NameInput.Text + "*'"; }
            UpdateTable();
        }
    }
}
