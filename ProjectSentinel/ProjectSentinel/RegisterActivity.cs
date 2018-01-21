using System;
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
            var t = new Timer() { Interval = 333 };
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

        /*private void userInstitutionComboBoxRegisterActivity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (userInstitutionComboBoxRegisterActivity.Text == "Sveučilište u Zagrebu") { userAcademicInstitution.InstitutionName = "Sveučilište u Zagrebu"; userAcademicInstitution.InstitutionAddress.City = "Zagreb"; userAcademicInstitution.InstitutionAddress.Country = "Croatia"; userAcademicInstitution.InstitutionAddress.Street = "Trg Republike Hrvatske"; userAcademicInstitution.InstitutionAddress.HouseNumber = 14; userAcademicInstitution.InstitutionAddress.Zipcode = 10000; userAcademicInstitution.InstitutionEstablished = new DateTime(1669, 9, 23);}
            else if (userInstitutionComboBoxRegisterActivity.Text == "Sveučilište J. J. Strossmayera Osijek") { userAcademicInstitution.InstitutionName = "Sveučilište J. J. Strossmayera Osijek"; userAcademicInstitution.InstitutionAddress.City = "Osijek"; userAcademicInstitution.InstitutionAddress.Country = "Croatia"; userAcademicInstitution.InstitutionAddress.Street = "Trg Svetog Trojstva"; userAcademicInstitution.InstitutionAddress.HouseNumber = 3; userAcademicInstitution.InstitutionAddress.Zipcode = 31000; userAcademicInstitution.InstitutionEstablished = new DateTime(1975, 5, 31);}
            else if (userInstitutionComboBoxRegisterActivity.Text == "Sveučilište u Dubrovniku") { userAcademicInstitution.InstitutionName = "Sveučilište u Dubrovniku"; userAcademicInstitution.InstitutionAddress.City = "Dubrovnik"; userAcademicInstitution.InstitutionAddress.Country = "Croatia"; userAcademicInstitution.InstitutionAddress.Street = "Ulica branitelja Dubrovnika"; userAcademicInstitution.InstitutionAddress.HouseNumber = 41; userAcademicInstitution.InstitutionAddress.Zipcode = 20000; userAcademicInstitution.InstitutionEstablished = new DateTime(2003, 10, 1); }
            else if (userInstitutionComboBoxRegisterActivity.Text == "Sveučilište Jurja Dobrile u Puli") { userAcademicInstitution.InstitutionName = "Sveučilište Jurja Dobrile u Puli"; userAcademicInstitution.InstitutionAddress.City = "Pula"; userAcademicInstitution.InstitutionAddress.Country = "Croatia"; userAcademicInstitution.InstitutionAddress.Street = "Zagrebačka ulica"; userAcademicInstitution.InstitutionAddress.HouseNumber = 30; userAcademicInstitution.InstitutionAddress.Zipcode = 52100; userAcademicInstitution.InstitutionEstablished = new DateTime(2006, 9, 29); }
            else if (userInstitutionComboBoxRegisterActivity.Text == "Sveučilište u Rijeci") { userAcademicInstitution.InstitutionName = "Sveučilište u Rijeci"; userAcademicInstitution.InstitutionAddress.City = "Rijeka"; userAcademicInstitution.InstitutionAddress.Country = "Croatia"; userAcademicInstitution.InstitutionAddress.Street = "Trg braće Mažuranića"; userAcademicInstitution.InstitutionAddress.HouseNumber = 10; userAcademicInstitution.InstitutionAddress.Zipcode = 51000; userAcademicInstitution.InstitutionEstablished = new DateTime(1973, 5, 17); }
            else if (userInstitutionComboBoxRegisterActivity.Text == "Sveučilište u Zadru") { userAcademicInstitution.InstitutionName = "Sveučilište u Zadru"; userAcademicInstitution.InstitutionAddress.City = "Zadar"; userAcademicInstitution.InstitutionAddress.Country = "Croatia"; userAcademicInstitution.InstitutionAddress.Street = "Ulica Mihovila Pavlinovića"; userAcademicInstitution.InstitutionAddress.HouseNumber = 1; userAcademicInstitution.InstitutionAddress.Zipcode = 23000; userAcademicInstitution.InstitutionEstablished = new DateTime(2002, 7, 4); }
            else if (userInstitutionComboBoxRegisterActivity.Text == "Sveučilište u Splitu") { userAcademicInstitution.InstitutionName = "Sveučilište u Splitu"; userAcademicInstitution.InstitutionAddress.City = "Split"; userAcademicInstitution.InstitutionAddress.Country = "Croatia"; userAcademicInstitution.InstitutionAddress.Street = "Livanjska ulica"; userAcademicInstitution.InstitutionAddress.HouseNumber = 5; userAcademicInstitution.InstitutionAddress.Zipcode = 21000; userAcademicInstitution.InstitutionEstablished = new DateTime(1974, 6, 15); }
            else { userAcademicInstitution.InstitutionName = "Sveučilište Sjever"; userAcademicInstitution.InstitutionAddress.City = "Koprivnica"; userAcademicInstitution.InstitutionAddress.Country = "Croatia"; userAcademicInstitution.InstitutionAddress.Street = "Trg doktora Žarka Dolinara"; userAcademicInstitution.InstitutionAddress.HouseNumber = 1; userAcademicInstitution.InstitutionAddress.Zipcode = 48000; userAcademicInstitution.InstitutionEstablished = new DateTime(2015, 5, 29); }
        }*/

        private void userRegisterButtonBack_Click(object sender, EventArgs e)
        {
            LoginActivity ra = new LoginActivity();
            Application.ThreadExit += (s, es) =>
            {
                Application.Run(ra);
            };
            this.Close();
        }

        private void userRegisterButtonRegisterActivity_Click(object sender, EventArgs e)
        {
            /*user.Username = userUserNameInputRegisterActivity.Text.ToString();
            user = new User(userUserNameInputRegisterActivity.Text.ToString(), userFirstNameInputRegisterActivity.Text.ToString(), userLastNameInputRegisterActivity.Text.ToString())
            user.UserPassword = userPasswordInputRegisterActivity.Text.ToString();
            user.UserFirstName = userFirstNameInputRegisterActivity.Text.ToString();
            user.UserLastName = userLastNameInputRegisterActivity.Text.ToString();
            user.UserAddress.Street = userAddress.Street = userAddressStreetInputRegisterActivity.Text.ToString();
            user.UserAddress.City = userAddress.City = userAddressCityInputRegisterActivity.Text.ToString();
            user.UserAddress.Country = userAddress.Country = userAddressCountryInputRegisterActivity.Text.ToString();
            user.UserAddress.HouseNumber = userAddress.HouseNumber = (ushort)Int32.Parse(userHouseNumberNumericRegisterActivity.Value.ToString());
            user.UserAddress.Zipcode = userAddress.Zipcode = (uint)Int32.Parse(userAddressZipcodeInputRegisterActivity.Text.ToString());
            user.UserPhoneNumber = userPhoneNumberInputRegisterActivity.Text.ToString();
            user.UserDateOfBirth = userDOBInputRegisterActivity.Value.Date;
            user.UserInstitution.InstitutionAddress = userAcademicInstitution.InstitutionAddress;
            user.UserInstitution.InstitutionName = userAcademicInstitution.InstitutionName;
            user.UserInstitution.InstitutionEstablished = userAcademicInstitution.InstitutionEstablished;*/
            userAddress = new Address(userAddressStreetInputRegisterActivity.Text, userAddressCityInputRegisterActivity.Text, userAddressCountryInputRegisterActivity.Text, (ushort)Int32.Parse(userHouseNumberNumericRegisterActivity.Value.ToString()), Int32.Parse(userAddressZipcodeInputRegisterActivity.Text.ToString()));
            userAddress.addAddressToDatabase();
            //userAcademicInstitution.setInstitutionName(Convert.ToInt32(userInstitutionComboBoxRegisterActivity.SelectedIndex));
            userAcademicInstitution = new Institution(Institution.getInstitutionName(userInstitutionComboBoxRegisterActivity.SelectedIndex), Institution.getInstitutionAddress(userInstitutionComboBoxRegisterActivity.SelectedIndex), Institution.getInstitutionFoundingDate(userInstitutionComboBoxRegisterActivity.SelectedIndex));
            //userAcademicInstitution.addInstitutionToDatabase(2);
            user = new User(userUserNameInputRegisterActivity.Text, userFirstNameInputRegisterActivity.Text, userLastNameInputRegisterActivity.Text, userPasswordInputRegisterActivity.Text, userPhoneNumberInputRegisterActivity.Text, userEmailInputRegisterActivity.Text, userDOBInputRegisterActivity.Value, userAddress, userAcademicInstitution);
            user.addUserToDatabase(userAddress.getAddressDatabaseRecordID(), userInstitutionComboBoxRegisterActivity.SelectedIndex+1);

            this.Close();
            user.LoggedIn = true;
            Properties.Settings.Default.UserLoggedInBetweenSessions = true;
            Properties.Settings.Default.Save();
            MainScreenActivity activity = new MainScreenActivity(user, userAcademicInstitution, userAddress);
            Application.ThreadExit += (s, es) =>
            {
                Application.Run(activity);
            };
            this.Close();
        }
    }
}
