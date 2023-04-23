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
    public partial class ViewInfoStudent : DMForm
    {
        public ViewInfoStudent ()
        {
            InitializeComponent();
            Values.Text = Program.student.GetName() + "\n" +
                          Program.student.GetEmail() + "\n" +
                          Program.student.p.BirthDate.ToString("d") + "\n" +
                          Program.student.p.CitizenID + "\n" +
                          Program.student.p.PhoneNumber + "\n" +
                          Program.student.p.Vehice + "\n" +
                          Program.student.p.HomeAddress + "\n" +
                          Program.student.p.School + "\n" +
                          Program.student.p.StudentID;
        }

        private void ChangePass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DMForm nextForm = new ChangePass(Program.student, "Student");
            Navigate(ref nextForm);
        }

        private void SendReport_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DMForm nextForm = new WrongInformation();
            Navigate(ref nextForm);
        }

        private void Return_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DMForm mainScreen = new StudentMainScreen();
            Navigate(ref mainScreen);
        }

        private void LogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DMForm startScreen = new StartScreen();
            Navigate(ref startScreen);
        }
    }
}
