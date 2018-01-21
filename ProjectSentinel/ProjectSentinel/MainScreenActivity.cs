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

     

        private void MainScreenActivity_Load(object sender, EventArgs e)
        {

        }
     
        private void userLogoutbuttonMainScreenActivity_Click(object sender, EventArgs e)
        {
            LoginActivity ma = new LoginActivity();
            ma.Show();
            this.Close();
        }
    }
}
