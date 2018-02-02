using System;
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
            TopPanel1.Hide();
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
            SidePanel1.Hide();
            TopPanel1.Show();
            TopPanel1.Width = SettingsButtonMainScreenActivity.Width;
            TopPanel1.Left = SettingsButtonMainScreenActivity.Left;
            MyProfileControlMainScreenActivity.BringToFront();
        }

        private void MyProfileButton_Click(object sender, EventArgs e)
        {
            SidePanel1.Hide();
            TopPanel1.Show();
            TopPanel1.Width = MyProfileButtonMainScreenActivity.Width;
            TopPanel1.Left = MyProfileButtonMainScreenActivity.Left;
            SettingsControlMainScreenActivity.BringToFront();
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
            SidePanel1.Show();
            TopPanel1.Hide();
            SidePanel1.Height = ToDoButtonMainScreenActivity.Height;
            SidePanel1.Top = ToDoButtonMainScreenActivity.Top;
            ToDoControlTestMainScreenActivity1.BringToFront();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            SidePanel1.Show();
            TopPanel1.Hide();
            SidePanel1.Height = HomeButtonMainScreenActivity.Height;
            SidePanel1.Top = HomeButtonMainScreenActivity.Top;
            HomeControlMainScreenActivity.BringToFront();

        }

        private void HomeControl_Load(object sender, EventArgs e)
        {

        }

        private void FlashcardButton_Click(object sender, EventArgs e)
        {
            SidePanel1.Show();
            TopPanel1.Hide();
            SidePanel1.Height = FlashcardButtonMainScreenActivity.Height;
            SidePanel1.Top = FlashcardButtonMainScreenActivity.Top;
            FlashcardControlMainScreenActivity.BringToFront();
        }

        private void ToDoControl_Load(object sender, EventArgs e)
        {

        }

        private void CourseButtonMainScreenActivity_Click(object sender, EventArgs e)
        {
            SidePanel1.Show();
            TopPanel1.Hide();
            SidePanel1.Height = CourseButtonMainScreenActivity.Height;
            SidePanel1.Top = CourseButtonMainScreenActivity.Top;
            CourseControlMainScreenActivity.BringToFront();
        }

        private void ToDoControlTestMainScreenActivity_Load(object sender, EventArgs e)
        {

        }

        private void ScheduleButtonMainScreenActivity_Click(object sender, EventArgs e)
        {
            SidePanel1.Show();
            TopPanel1.Hide();
            SidePanel1.Height = ScheduleButtonMainScreenActivity.Height;
            SidePanel1.Top = ScheduleButtonMainScreenActivity.Top;
            ScheduleControlMainScreenActivity.BringToFront();
        }
    }
}
