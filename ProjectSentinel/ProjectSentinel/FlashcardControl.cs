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
    public partial class FlashcardControl : UserControl
    {
        public FlashcardControl()
        {
            InitializeComponent();
        }

        private void Create_Click(object sender, EventArgs e)
        {
            FlashcardForm ra = new FlashcardForm();
            ra.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FlashcardForm ra = new FlashcardForm();
            ra.ShowDialog();
        }
    }
}
