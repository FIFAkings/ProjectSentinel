﻿using System;
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
    public partial class LoginActivity : Form
    {
        public LoginActivity()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void userRegisterButtonLoginActivity_Click(object sender, EventArgs e)
        {
            RegisterActivity ra = new RegisterActivity();
            ra.Show();
            this.Hide();
        }

        private void userLoginButtonLoginActivity_Click(object sender, EventArgs e)
        {
            MainScreenActivity ma = new MainScreenActivity();
            ma.Show();
            this.Hide();
        }
    }
}
