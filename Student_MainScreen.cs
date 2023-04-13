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
        private int payCount = 0;
        public StudentMainScreen()
        {
            InitializeComponent();
            Information.Text = "Welcome back " + Program.student.GetName();
            Type.Text = Program.student.r.Type.ToString();
            Number.Text = Program.student.r.RoomNum;
            BuildingName.Text = Program.student.r.Building;
            Bill.Text = Program.student.r.Bill.ToString() + " VNĐ";
            int lateTime = (DateTime.Today - Program.student.r.BillTime).Days;
            Late.Text = lateTime.ToString();
            Penalty.Text = (Program.student.r.Bill * lateTime * 0.01).ToString() + " VNĐ";
        }

        private void StudentMainScreen_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Program.student.PayRequest();
            if (payCount==0)
            {
                MessageBox.Show("Request to pay the bill is sent\nWhen the manager accept your request, the bill will be updated!",
                            "Request Sent", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Your request to pay is sent\nIt's not necessary to pay anymore!", "Caution");
            }
            payCount++;
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
