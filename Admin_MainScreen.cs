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
    public partial class AdminMainScreen : DMForm
    {
        public AdminMainScreen()
        {
            InitializeComponent();
        }

        private void AddBuilding_Click(object sender, EventArgs e)
        {
            DMForm nextForm = new AddBuilding();
            Navigate(ref nextForm);
        }

        private void ModifyBuilding_Click(object sender, EventArgs e)
        {
            DMForm nextForm = new ModifyBuilding();
            Navigate(ref nextForm);
        }

        private void AddUsers_Click(object sender, EventArgs e)
        {
            DMForm nextForm = new AddUsers();
            Navigate(ref nextForm);
        }

        private void RemoveUsers_Click(object sender, EventArgs e)
        {
            DMForm nextForm = new RemoveUsers();
            Navigate(ref nextForm);
        }

        private void HomePic_Click(object sender, EventArgs e)
        {
            DMForm changePass = new ChangePass(Program.admin, "Admin");
            Navigate(ref changePass);
        }

        private void LogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DMForm startScreen = new StartScreen();
            Navigate(ref startScreen);
        }
    }
}