using System;
using System.Windows.Forms;
using System.Threading;

namespace ProjectSentinel
{
    public partial class MainScreenActivity : Form
    {
        User appUser;
        public MainScreenActivity()
        {
            InitializeComponent();
            this.Show();
            appUser.loadUserFromTheDatabase(Properties.Settings.Default.LoggedUserId);
            HomeControl.BringToFront();

        }

        public MainScreenActivity(User user)
        {
            appUser = user;
            InitializeComponent();
            
        }

        public static void AuxiliaryThreadingMethod()
        {
            Application.Run(new LoginActivity());
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
            SidePanel1.Height = FlashcardButton.Height;
            SidePanel1.Top = FlashcardButton.Top;
            FlashcardControl.BringToFront();
        }

        private void ToDoControl_Load(object sender, EventArgs e)
        {

        }
    }
}
