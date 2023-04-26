﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DormitoryManagment
{
    public partial class AddStudents : DMForm
    {
        public AddStudents()
        {
            InitializeComponent();
            Information.Text = Program.manager.GetName() + " - Students Adding";
            ProgressBar.Value = 0;
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

        private void AddStudentsButton_Click(object sender, EventArgs e)
        {
            Program.manager.AddStudentList(filepath.Text, ref ProgressBar);
        }

        private void ManageStudents_Click(object sender, EventArgs e)
        {
            DMForm nextForm = new ManageStudent();
            Navigate(ref nextForm);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Do nothing here
        }

        private void ReviewRequests_Click(object sender, EventArgs e)
        {
            DMForm nextForm = new ReviewRequests();
            Navigate(ref nextForm);
        }

        private void BigLogo_Click(object sender, EventArgs e)
        {
            DMForm mainScreen = new ManagerMainScreen();
            Navigate(ref mainScreen);
        }
    }
}
