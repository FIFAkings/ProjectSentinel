using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectSentinel
{
    public partial class ToDoControlTest : UserControl
    {
        User user = new User();

        public ToDoControlTest()
        {
            InitializeComponent();
            user.loadUserFromDatabase(Properties.Settings.Default.LoggedUserId);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ToDoForm ra = new ToDoForm(user);
            ra.ShowDialog();
        }
    }
}
