using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace DormitoryManagment
{
    public partial class ReviewRequests : DMForm
    {
        static DataTable dataTable = null;
        public ReviewRequests()
        {
            InitializeComponent();
            dataTable = DataBase.GetDataSource("SELECT * FROM Requests");
            dataTable.Columns.Add("isPending", typeof(bool));
            foreach (DataRow row in dataTable.Rows)
            {
                row["isPending"] = false;
            }
            Table.DataSource = dataTable;
            Information.Text = Program.manager.GetName() + " - Request Reviewing";
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

        private void AddStudents_Click(object sender, EventArgs e)
        {
            DMForm nextForm = new AddStudents();
            Navigate(ref nextForm);
        }

        private void ManageStudents_Click(object sender, EventArgs e)
        {
            DMForm nextForm = new ManageStudent();
            Navigate(ref nextForm);
        }

        private void AddBills_Click(object sender, EventArgs e)
        {
            DMForm nextForm = new AddBills();
            Navigate(ref nextForm);
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            Program.manager.ReviewBills(dataTable);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.manager.PrintLateBills();
        }

        private void BigLogo_Click(object sender, EventArgs e)
        {
            DMForm mainScreen = new ManagerMainScreen();
            Navigate(ref mainScreen);
        }
    }
}
