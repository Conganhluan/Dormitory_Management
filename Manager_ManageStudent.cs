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
        DataView dataView;

        public ManageStudent()
        {
            InitializeComponent();
            UpdateTable();
        }

        private void UpdateTable()
        {
            dataView = new DataView(DataBase.GetDataSource("SELECT * FROM Students"));
            //if (Key.Text == "None") dataView.RowFilter = null;
            //else dataView.RowFilter = Key.Text + " LIKE *" + Value.Text + "*"; 
            Table.DataSource = dataView;
        }
    }
}
