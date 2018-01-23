using System;
using System.Threading;
using System.Windows.Forms;


namespace ProjectSentinel
{
    public partial class RegisterActivity : Form
    {
        Institution userAcademicInstitution;
        Address userAddress;
        User user;

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
            if (userHouseNumberNumericRegisterActivity.Value >= 1000000000) {
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
            Application.ThreadExit += (s, es) =>
            {
                Application.Run(ra);
            };
            this.Close();
        }

        public static void AuxiliaryThreadingMethod() { }

        [STAThread]
        private void userRegisterButtonRegisterActivity_Click(object sender, EventArgs e)
        {
            userAddress = new Address(userAddressStreetInputRegisterActivity.Text, userAddressCityInputRegisterActivity.Text, userAddressCountryInputRegisterActivity.Text, (ushort)Int32.Parse(userHouseNumberNumericRegisterActivity.Value.ToString()), Int32.Parse(userAddressZipcodeInputRegisterActivity.Text.ToString()));
            userAddress.addAddressToDatabase();
            userAcademicInstitution = new Institution(Institution.getInstitutionName(userInstitutionComboBoxRegisterActivity.SelectedIndex), Institution.getInstitutionAddress(userInstitutionComboBoxRegisterActivity.SelectedIndex), Institution.getInstitutionFoundingDate(userInstitutionComboBoxRegisterActivity.SelectedIndex));
            user = new User(userUserNameInputRegisterActivity.Text, userFirstNameInputRegisterActivity.Text, userLastNameInputRegisterActivity.Text, userPasswordInputRegisterActivity.Text, userPhoneNumberInputRegisterActivity.Text, userEmailInputRegisterActivity.Text, userDOBInputRegisterActivity.Value, userAddress, userAcademicInstitution);
            user.addUserToDatabase(userAddress.getAddressDatabaseRecordID(), userInstitutionComboBoxRegisterActivity.SelectedIndex+1);
            user.LoggedIn = true;
            Properties.Settings.Default.UserLoggedInBetweenSessions = user.LoggedIn;
            Properties.Settings.Default.Save();
            Properties.Settings.Default.Upgrade();
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
            ThreadStart threadStart = new ThreadStart(AuxiliaryThreadingMethod);
            Thread thread = new Thread(threadStart);
            thread.Start();
            this.Close();

        }
    }
}
