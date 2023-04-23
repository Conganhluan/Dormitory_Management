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
    public partial class WrongInformation : DMForm
    {
        public WrongInformation()
        {
            InitializeComponent();
            BirthdateInput.Value = Program.student.p.BirthDate;
            CitizenIDInput.Text = Program.student.p.CitizenID;
            PhoneInput.Text = Program.student.p.PhoneNumber;
            VehicleInput.Text = Program.student.p.Vehice;
            HomeAddressInput.Text = Program.student.p.HomeAddress;
        }

        private void Return_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DMForm nextForm = new ViewInfoStudent();
            Navigate(ref nextForm);
        }

        private void LogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DMForm startScreen = new StartScreen();
            Navigate(ref startScreen);
        }

        private void Send_Click(object sender, EventArgs e)
        {
            Program.student.p.BirthDate = BirthdateInput.Value;
            Program.student.p.CitizenID = CitizenIDInput.Text;
            Program.student.p.PhoneNumber = PhoneInput.Text;
            Program.student.p.Vehice = VehicleInput.Text;
            Program.student.p.HomeAddress = HomeAddressInput.Text;
            MessageBox.Show("Change the information successfully!", "Update successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BirthdateInput_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
