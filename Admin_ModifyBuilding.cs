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
        public ModifyBuilding()
        {
            InitializeComponent();
        }

        private void ModifyBuilding_Load(object sender, EventArgs e)
        {
            Table.DataSource = DataBase.GetDataSouce("SELECT * FROM Buildings");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*if (comboBox1.Text == "All") { dataSet.Buildings.DefaultView.RowFilter = "Gender LIKE '*'"; }
            else { dataSet.Buildings.DefaultView.RowFilter = "Gender = '" + comboBox1.Text + "'"; }
            Table.DataSource = dataSet.Buildings.DefaultView;
            NameInput.Text = "";*/
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*if (NameInput.Text == "") { dataSet.Buildings.DefaultView.RowFilter = "Name LIKE '*'"; }
            else { dataSet.Buildings.DefaultView.RowFilter = "Name LIKE '*" + NameInput.Text + "*'"; }
            Table.DataSource = dataSet.Buildings.DefaultView;
            comboBox1.Text = "All";*/
        }
    }
}
