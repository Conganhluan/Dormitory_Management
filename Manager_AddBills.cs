﻿using System;
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
    public partial class AddBills : DMForm
    {
        public AddBills()
        {
            InitializeComponent();
            Information.Text = "Welcome back " + Program.manager.GetName();
        }

        private void HomePic_Click(object sender, EventArgs e)
        {
            DMForm nextForm = new ViewInfoManager();
            Navigate(ref nextForm);
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

        private void ReviewRequests_Click(object sender, EventArgs e)
        {
            DMForm nextForm = new ReviewRequests();
            Navigate(ref nextForm);
        }

        private void LogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DMForm startScreen = new StartScreen();
            Navigate(ref startScreen);
        }

        private void AddStudentsButton_Click(object sender, EventArgs e)
        {
            Program.manager.AddBills(filepath.Text);
        }

        private void BigLogo_Click(object sender, EventArgs e)
        {
            DMForm mainScreen = new ManagerMainScreen();
            Navigate(ref mainScreen);
        }
    }
}
