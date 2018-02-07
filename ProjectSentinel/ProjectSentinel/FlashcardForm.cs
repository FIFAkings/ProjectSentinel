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
    public partial class FlashcardForm : Form
    {
        public FlashcardForm()
        {
            InitializeComponent();
        }

        private void FlashcardForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void FrontFlashcardButtonFlashcardForm_Click(object sender, EventArgs e)
        {
            FlashFront.BringToFront();

        }

        private void FrontcardBackFlashcardForm_Click(object sender, EventArgs e)
        {
            FlashBack.BringToFront();
        }
    }
}
