﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectSentinel
{
    public partial class MainScreenActivity : Form
    {
        public MainScreenActivity()
        {
            InitializeComponent();
            this.Show();
        }

        public MainScreenActivity(User user, Institution institution, Address userAddress)
        {
            User appUser = user;
            Institution userInstitution = institution;
            Address address = userAddress;
        }



        private void MainScreenActivity_Load(object sender, EventArgs e)
        {

        }

        private void userLogoutbuttonMainScreenActivity_Click(object sender, EventArgs e)
        {
            LoginActivity ma = new LoginActivity();
            ma.Show();
            this.Hide();
        }

        private void MainScreenActivity_Load_1(object sender, EventArgs e)
        {

        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            /*SettingsActivity sa = new SettingsActivity();
            sa.Show();
            this.Close();*/
        }

        private void MyProfileButon_Click(object sender, EventArgs e)
        {
           /* MyProfileActivity mpa = new MyProfileActivity();
            mpa.Show();
            this.Close();*/
        }

        private void NewsButton_Click(object sender, EventArgs e)
        {
           /* NewsActivity n = new NewsActivity();
            n.Show();
            this.Close();*/
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ToDoButton_Click(object sender, EventArgs e)
        {
            SidePanel1.Height = ToDoButton.Height;
            SidePanel1.Top = ToDoButton.Top;
            ToDoControl.BringToFront();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            SidePanel1.Height = HomeButton.Height;
            SidePanel1.Top = HomeButton.Top;
            HomeControl.BringToFront();
        }

        private void HomeControl_Load(object sender, EventArgs e)
        {

        }

        private void FlashcardButton_Click(object sender, EventArgs e)
        {

        }
    }
}
