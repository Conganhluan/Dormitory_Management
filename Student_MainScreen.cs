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
using System.Xml.Linq;

namespace DormitoryManagment
{
    public partial class StudentMainScreen : DMForm
    {
        public StudentMainScreen()
        {
            InitializeComponent();
            Information.Text = "Welcome back " + Program.student.GetName();
            Type.Text = Program.student.r.Type.ToString() + " people";
            Number.Text = Program.student.r.RoomNum;
            BuildingName.Text = Program.student.r.Building;
            Bill.Text = Program.student.r.Bill.ToString("#, ##0.##") + " VNĐ";
            int lateTime = (DateTime.Today - Program.student.r.BillTime).Days;
            Late.Text = lateTime.ToString() + " day";
            if (lateTime > 1) Late.Text += "s";
            Penalty.Text = (Program.student.r.Bill * lateTime * 0.01).ToString("#, ##0.##") + " VNĐ";
        }

        private void StudentMainScreen_Load(object sender, EventArgs e)
        {

        }

        private void PAYBILL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Program.student.PayRequest();
        }

        private void HomePic_Click(object sender, EventArgs e)
        {
            DMForm nextForm = new ViewInfoStudent();
            Navigate(ref nextForm);
        }

        private void LogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DMForm startScreen = new StartScreen();
            Navigate(ref startScreen);
        }
    }
}
