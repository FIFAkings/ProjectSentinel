using System;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ProjectSentinel
{
    public partial class LoginActivity : Form
    {
        User appUser = new User();
        public LoginActivity()
        {
            InitializeComponent();
            this.Show();
        }

        private void userRegisterButtonLoginActivity_Click(object sender, EventArgs e)
        {
            RegisterActivity ra = new RegisterActivity();
            this.Hide();
            ra.Show();
            
        }

        public static void AuxiliaryThreadingMethod(User user)
        {
            Application.Run(new MainScreenActivity(user));
        }

        private void userLoginButtonLoginActivity_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Convert.ToBase64String(SimpleCrypto.GenerateSaltedHash(Encoding.ASCII.GetBytes(userPasswordInputLoginActivity.Text), SimpleCrypto.Salt)), User.loadPasswordFromDatabase(userUsernameInputLoginActivity.Text));
            if (Convert.ToBase64String(SimpleCrypto.GenerateSaltedHash(Encoding.ASCII.GetBytes(userPasswordInputLoginActivity.Text), SimpleCrypto.Salt)) == User.loadPasswordFromDatabase(userUsernameInputLoginActivity.Text))
            {
                appUser.loadUserFromDatabase(User.getUserDatabaseRecordLoginId(userUsernameInputLoginActivity.Text));
                Thread thread = new Thread(() => AuxiliaryThreadingMethod(appUser));
                thread.Start();
                this.Close();
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Username or Password do not match our records. Try again or register.", "Failed to Log In | Project Sentinel");
            }
            
        }
    }
}

