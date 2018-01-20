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
    public partial class RegisterActivity : Form
    {
        public RegisterActivity()
        {
            InitializeComponent();
        }

        private void RegisterActivity_Load(object sender, EventArgs e)
        {

        }

        private void userHouseNumberNumericRegisterActivity_ValueChanged(object sender, EventArgs e)
        {
            var t = new Timer() { Interval = 333 };
            if (userHouseNumberNumericRegisterActivity.Value >= 1000000000) {
                SiliconValleyReferenceLabelRegisterActivity.Text = "Woah dude, this is hardly \na three comma club!";
                t.Tick += (s, ea) =>
                {
                    SiliconValleyReferenceLabelRegisterActivity.Hide();
                    t.Stop();
                };
                t.Start();
            }
                

        }

        private void userInstitutionComboBoxRegisterActivity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void userRegisterButtonBack_Click(object sender, EventArgs e)
        {
            LoginActivity ra = new LoginActivity();
            ra.Show();
            this.Close();
        }

        private void userRegisterButtonRegisterActivity_Click(object sender, EventArgs e)
        {
            
        }
    }
}
