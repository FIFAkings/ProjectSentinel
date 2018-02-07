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
    public partial class MyProfileControl : UserControl
    {
        public MyProfileControl()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void EditButtonMyProfileControl_Click(object sender, EventArgs e)
        {
            MyProfileEditForm ra = new MyProfileEditForm();
            ra.ShowDialog();
        }

  

    }
}

