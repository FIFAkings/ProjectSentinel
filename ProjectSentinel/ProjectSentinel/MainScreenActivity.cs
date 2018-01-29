﻿using System;
using System.Windows.Forms;
using System.Threading;

namespace ProjectSentinel
{
    public partial class MainScreenActivity : Form
    {
        User appUser = new User();
        public MainScreenActivity()
        {
            InitializeComponent();
            this.Show();
            appUser.loadUserFromDatabase(Properties.Settings.Default.LoggedUserId);
            HomeControlMainScreenActivity.BringToFront();
            this.FormClosing += MainScreenActivity_FormClosing;
        }

        public MainScreenActivity(User user)
        {
            appUser = user;
            InitializeComponent();
            this.FormClosing += MainScreenActivity_FormClosing;
        }

        public static void AuxiliaryThreadingMethod()
        {
            Application.Run(new LoginActivity());
        }

        private void MainScreenActivity_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void userLogoutbuttonMainScreenActivity_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.UserLoggedInBetweenSessions = false;
            Properties.Settings.Default.Save();
            Properties.Settings.Default.Reload();
            //Properties.Settings.Default.Upgrade();
            ThreadStart threadStart = new ThreadStart(AuxiliaryThreadingMethod);
            Thread thread = new Thread(threadStart);
            thread.Start();
            this.Close();
            Application.Exit();
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
            MessageBox.Show(appUser.Username, "USER TEST!!!");
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
            SidePanel1.Height = ToDoButtonMainScreenActivity.Height;
            SidePanel1.Top = ToDoButtonMainScreenActivity.Top;
            ToDoControlMainScreenActivity.BringToFront();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            SidePanel1.Height = HomeButtonMainScreenActivity.Height;
            SidePanel1.Top = HomeButtonMainScreenActivity.Top;
            HomeControlMainScreenActivity.BringToFront();
            
        }

        private void HomeControl_Load(object sender, EventArgs e)
        {

        }

        private void FlashcardButton_Click(object sender, EventArgs e)
        {
            SidePanel1.Height = FlashcardButtonMainScreenActivity.Height;
            SidePanel1.Top = FlashcardButtonMainScreenActivity.Top;
            FlashcardControlMainScreenActivity.BringToFront();
        }

        private void ToDoControl_Load(object sender, EventArgs e)
        {

        }
    }
}
