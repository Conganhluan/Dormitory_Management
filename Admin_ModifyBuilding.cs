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
            // TODO: This line of code loads data into the 'dataSet.Buildings' table. You can move, or remove it, as needed.
            this.buildingsTableAdapter.Fill(this.dataSet.Buildings);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*if (comboBox1.Text == "All") { dataSet.Buildings.DefaultView.};
            dataSet.Buildings.DefaultView.RowFilter = "Gender = '" + comboBox1.Text + "'";
            Table.DataSource = dataSet.Buildings.DefaultView;*/
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //dataSet.Buildings.DefaultView.RowFilter = "Gender";
        }
    }
}
