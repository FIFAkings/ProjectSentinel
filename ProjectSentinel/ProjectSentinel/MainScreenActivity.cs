using System;
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
        }

        public MainScreenActivity(User user, Institution institution, Address userAddress)
        {
            User appUser = user;
            Institution userInstitution = institution;
            Address address = userAddress;
            InitializeComponent();
        }



        private void MainScreenActivity_Load(object sender, EventArgs e)
        {

        }

        private void userLogoutbuttonMainScreenActivity_Click(object sender, EventArgs e)
        {
            LoginActivity ma = new LoginActivity();
            ma.Show();
            this.Close();
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
