using Mono.Data.Sqlite;
using System;
using System.Text;
using System.Threading;
using System.Windows.Forms;


namespace ProjectSentinel
{
    public partial class RegisterActivity : Form
    {
        Institution userAcademicInstitution;
        Address userAddress;
        User user;
        public static byte[] SaltArray = SimpleCrypto.getSalt();

        public RegisterActivity()
        {
            InitializeComponent();
        }

        private void RegisterActivity_Load(object sender, EventArgs e)
        {

        }

        private void userHouseNumberNumericRegisterActivity_ValueChanged(object sender, EventArgs e)
        {
            var t = new System.Windows.Forms.Timer() { Interval = 333 };
            if (userHouseNumberNumericRegisterActivity.Value >= 1000000000)
            {
                //changed my mind, didn't change the object name (this has nothing to do with Silicon Valley)
                mildlyEntertainingSiliconValleyReferenceLabelRegisterActivity.Text = "Hopefully not. \nSM: INGbTATMOUx(^)E.";
                t.Tick += (s, ea) =>
                {
                    mildlyEntertainingSiliconValleyReferenceLabelRegisterActivity.Hide();
                    t.Stop();
                };
                t.Start();
            }


        }

        private void userRegisterButtonBack_Click(object sender, EventArgs e)
        {
            LoginActivity ra = new LoginActivity();
            ra.Show();
            this.Close();
        }

        public static void AuxiliaryThreadingMethod(User user)
        {
            Application.Run(new MainScreenActivity(user));
        }

        private void userRegisterButtonRegisterActivity_Click(object sender, EventArgs e)
        {
            //Properties.Settings.Default.ApplicationFirstRun = true;
            if (Properties.Settings.Default.ApplicationFirstRun)
            {
                if (userPasswordInputRegisterActivity.Text == userRepeatPasswordInputRegisterActivity.Text)
                {
                    if (isValidEmail(userEmailInputRegisterActivity.Text))
                    {
                        registerAndLogIn();
                    }
                    else
                    {
                        var messageBox = MessageBox.Show("Email is not valid.", "Failed to Register | Project Sentinel");
                    }
                }
                else { var messageBox = MessageBox.Show("Passwords do not match.", "Failed to Register | Project Sentinel"); }      
            }
            else
            {
                if (userPasswordInputRegisterActivity.Text == userRepeatPasswordInputRegisterActivity.Text)
                {
                    if (isValidEmail(userEmailInputRegisterActivity.Text))
                    {
                        if (emailExists(userEmailInputRegisterActivity.Text))
                        {
                            if (usernameExists(userUserNameInputRegisterActivity.Text))
                            {
                                registerAndLogIn();
                            }
                            else
                            {
                                var messageBox = MessageBox.Show("Username already exists. Choose another username.", "Failed to Register | Project Sentinel");
                            }
                        }
                        else
                        {
                            var messageBox = MessageBox.Show("Email address already in use. Go back to log in your account.", "Failed to Register | Project Sentinel");

                        }
                    }
                    else
                    {
                        var messageBox = MessageBox.Show("Email is not valid.", "Failed to Register | Project Sentinel");
                    }
                }
                else
                {
                    var messageBox = MessageBox.Show("Passwords do not match.", "Failed to Register | Project Sentinel");
                }
            }
        }

        void registerAndLogIn()
        {
            userAddress = new Address(userAddressStreetInputRegisterActivity.Text, userAddressCityInputRegisterActivity.Text, userAddressCountryInputRegisterActivity.Text, (ushort)Int32.Parse(userHouseNumberNumericRegisterActivity.Value.ToString()), Int32.Parse(userAddressZipcodeInputRegisterActivity.Text.ToString()));
            userAddress.addAddressToDatabase();
            userAcademicInstitution = new Institution(Institution.getInstitutionName(userInstitutionComboBoxRegisterActivity.SelectedIndex), Institution.getInstitutionAddress(userInstitutionComboBoxRegisterActivity.SelectedIndex), Institution.getInstitutionFoundingDate(userInstitutionComboBoxRegisterActivity.SelectedIndex));
            user = new User(userUserNameInputRegisterActivity.Text, userFirstNameInputRegisterActivity.Text, userLastNameInputRegisterActivity.Text, Convert.ToBase64String(SimpleCrypto.GenerateSaltedHash(Encoding.ASCII.GetBytes(userPasswordInputRegisterActivity.Text), SimpleCrypto.getSalt())), userPhoneNumberInputRegisterActivity.Text, userEmailInputRegisterActivity.Text, userDOBInputRegisterActivity.Value, userAddress, userAcademicInstitution);
            user.addUserToDatabase(userAddress.getAddressDatabaseRecordID(), userInstitutionComboBoxRegisterActivity.SelectedIndex + 1);
            user.LoggedIn = true;
            Properties.Settings.Default.UserLoggedInBetweenSessions = user.LoggedIn;
            Properties.Settings.Default.LoggedUserId = User.getUserDatabaseRecordID();
            Properties.Settings.Default.Save();
            Properties.Settings.Default.Reload();
            //Properties.Settings.Default.Upgrade();
            /*Application.ThreadExit += (s, es) =>
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                var thread = new System.Threading.Thread(ThreadStart);
                thread.TrySetApartmentState(ApartmentState.STA);
                thread.Start();
                Application.Run(new MainScreenActivity());
                this.Close();
                //MainScreenActivity activity = new MainScreenActivity(user);
                //Application.Run(activity);
                //activity.Show();
            };*/
            //ThreadStart threadStart = new ThreadStart();
            Thread thread = new Thread(() => AuxiliaryThreadingMethod(user));
            thread.Start();
            this.Close();
            Application.Exit();
        }

        bool usernameExists(string username)
        {
            String cn = "URI=file:ProjectSentinel.db";
            SqliteConnection databaseConnection = new SqliteConnection(cn);
            databaseConnection.Open();
            SqliteCommand command = databaseConnection.CreateCommand();
            command.CommandText = "SELECT COUNT(*) FROM USER WHERE username='" + username + "';";
            var result = command.ExecuteScalar();
            if (result != null)
            {
                databaseConnection.Close();
                command.Dispose();
                return true;
            }
            else
            {
                command.Dispose();
                databaseConnection.Close();
                return false;
            }       
        }

        bool emailExists(string email)
        {
            String cn = "URI=file:ProjectSentinel.db";
            SqliteConnection databaseConnection = new SqliteConnection(cn);
            databaseConnection.Open();
            SqliteCommand command = databaseConnection.CreateCommand();
            command.CommandText = "SELECT COUNT(*) FROM USER WHERE userEmail='" + email + "';";
            var result = command.ExecuteScalar();
            if (result != null)
            {
                databaseConnection.Close();
                command.Dispose();
                return true;
            }
            else
            {
                command.Dispose();
                databaseConnection.Close();
                return false;
            }
        }

        // This method is fairly limited in its function, permitting some invalid strings to pass as valid, but it is better than having no control at all.
        bool isValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}

