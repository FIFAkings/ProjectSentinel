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
    public partial class ToDoControl : UserControl
    {
        User user;

        public ToDoControl()
        {
            InitializeComponent();
        }
        
        public ToDoControl(User user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ToDoForm ra = new ToDoForm(user);
            ra.Show();

        }
    }
}
