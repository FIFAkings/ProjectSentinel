using System;
using Mono.Data.Sqlite;
//using System.Configuration;

namespace ProjectSentinel
{

    //[SettingsSerializeAs(SettingsSerializeAs.Xml)]
    public class User
    {

        private String username, userFirstName, userLastName, userPassword, userPhoneNumber, userEmail;
        private DateTime userDateOfBirth;
        private int userAge;
        private Address userAddress;
        private Institution userInstitution;
        private bool loggedIn;

        public String Username { get { return this.username; } set { this.username = value; } }
        public String UserFirstName { get { return this.userFirstName; } set { this.userFirstName = value; } }
        public String UserLastName { get { return this.userLastName; } set { this.userLastName = value; } }
        public String UserPassword { get { return this.userPassword; }  set { this.userPassword = value; } }
        public String UserPhoneNumber { get { return this.userPhoneNumber; } set { this.userPhoneNumber = value; } }
        public String UserEmail { get { return this.userEmail; } set { this.userEmail = value; } }
        public DateTime UserDateOfBirth { get { return this.userDateOfBirth; } set { this.userDateOfBirth = value; } }
        public int UserAge { get { return this.userAge; } set { this.userAge = value; } }
        public Address UserAddress { get { return this.userAddress; } set { this.userAddress = value; } }
        public Institution UserInstitution { get { return this.userInstitution; } set { this.userInstitution = value; } }
        public bool LoggedIn { get { return this.loggedIn; } set { this.loggedIn = value; } }

        public User() { }

        public User(String un, String ufn, String uln, String pw, String pn, String email, DateTime dob, Address address, Institution inst)
        {
            username = un;
            userFirstName = ufn;
            userLastName = uln;
            userPassword = pw;
            userPhoneNumber = pn;
            userEmail = email;
            userDateOfBirth = dob;
            userAge = calculateUserAge(dob);
            userAddress = address;
            userInstitution = inst;
            loggedIn = false;
        }

        private int calculateUserAge(DateTime dateOfBirth)
        {
            int age;
            DateTime today = DateTime.Today;
            age = today.Year - dateOfBirth.Year;
            if (dateOfBirth > today.AddYears(-age)) age = age - 1;
            return age;
        }

        public void addUserToDatabase(int addressId, int institutionId)
        {
            String cn = "URI=file:ProjectSentinel.db";
            SqliteConnection databaseConnection = new SqliteConnection(cn);
            databaseConnection.Open();
            SqliteCommand sqlUserTableCommand = databaseConnection.CreateCommand();
            sqlUserTableCommand.CommandText = @"CREATE TABLE IF NOT EXISTS USER (id integer primary key autoincrement, username varchar(33) unique not null, userEmail varchar(77) not null, userPassword varchar(999) not null, userFirstName varchar(111), userLastName varchar(333), userPhoneNumber varchar(21), userDateOfBirth datetime, address_id integer not null, institution_id integer not null, foreign key (address_id) references address(id), foreign key (institution_id) references institution(id));";
            sqlUserTableCommand.ExecuteNonQuery();
            sqlUserTableCommand.Dispose();
            SqliteCommand sqlInsertUserCommand = databaseConnection.CreateCommand();
            sqlInsertUserCommand.CommandText = "INSERT INTO USER (username, userEmail, userPassword, userFirstName, userLastName, userPhoneNumber, userDateOfBirth, address_id, institution_id) VALUES ('"+this.username+"', '"+this.userEmail+"', '"+ this.userPassword +"', '"+this.userFirstName+"', '"+this.userLastName+"', '"+this.userPhoneNumber+"', '"+this.userDateOfBirth+"', '"+addressId+"', '"+institutionId+"');";
            sqlInsertUserCommand.ExecuteNonQuery();
            sqlInsertUserCommand.Dispose();
            databaseConnection.Close();
        }
        
        public void loadUserFromDatabase(int userId)
        {

            // using Database and its Readers this way is an awful programming practice, but time and consistency of code are forcing us to do it this way

            int auxiliaryAddressId, auxiliaryInstitutionId, auxiliaryInstitutionAddressId;
            auxiliaryAddressId = auxiliaryInstitutionId = auxiliaryInstitutionAddressId = -1;
            String cn = "URI=file:ProjectSentinel.db";
            SqliteConnection databaseConnection = new SqliteConnection(cn);
            databaseConnection.Open();
            SqliteCommand sqlReadCommand = databaseConnection.CreateCommand();
            sqlReadCommand.CommandText = "SELECT * FROM USER WHERE ID='"+ userId +"';";
            SqliteDataReader readerUser = sqlReadCommand.ExecuteReader();
            while (readerUser.Read())
            {
                this.username = readerUser.GetString(1);
                this.userEmail = readerUser.GetString(2);
                this.userPassword = readerUser.GetString(3);
                this.userFirstName = readerUser.GetString(4);
                this.userLastName = readerUser.GetString(5);
                this.userPhoneNumber = readerUser.GetString(6);
                this.userDateOfBirth = Convert.ToDateTime(readerUser.GetString(7));
                auxiliaryAddressId = readerUser.GetInt32(8);
                auxiliaryInstitutionId = readerUser.GetInt32(9);
            }
            readerUser.Close();
            /* We are now entering unnecessarily redundant layers of database interaction, indiciating that our chosen way to do this is not optimal.
             Nonetheless, we'll keep it this way, so we can save time for more demanding tasks awaiting us in the future. */
            sqlReadCommand.CommandText = "SELECT * FROM ADDRESS WHERE ID='" + auxiliaryAddressId + "';";
            SqliteDataReader readerAddress = sqlReadCommand.ExecuteReader();
            while (readerAddress.Read())
            {
                this.userAddress = new Address(); 
                this.userAddress.Street = readerAddress.GetString(1);
                this.userAddress.City = readerAddress.GetString(2);
                this.userAddress.Country = readerAddress.GetString(3);
                this.userAddress.HouseNumber = readerAddress.GetInt32(4);
                this.userAddress.Zipcode = readerAddress.GetInt32(5);
            }
            readerAddress.Close();
            sqlReadCommand.CommandText = "SELECT * FROM INSTITUTION WHERE ID='" + auxiliaryInstitutionId + "';";
            SqliteDataReader readerInstitution = sqlReadCommand.ExecuteReader();
            while(readerInstitution.Read())
            {
                this.userInstitution = new Institution();
                this.userInstitution.InstitutionName = readerInstitution.GetString(1);
                auxiliaryInstitutionAddressId = readerInstitution.GetInt32(2);
                this.userInstitution.InstitutionEstablished = Convert.ToDateTime(readerInstitution.GetString(3));
            }
            readerInstitution.Close();
            sqlReadCommand.CommandText = "SELECT * FROM ADDRESS WHERE ID='" + auxiliaryInstitutionAddressId + "';";
            SqliteDataReader readerInstitutionAddress = sqlReadCommand.ExecuteReader();
            while(readerInstitutionAddress.Read())
            {
                this.userInstitution.InstitutionAddress = new Address();
                this.userInstitution.InstitutionAddress.Street = readerInstitutionAddress.GetString(1);
                this.userInstitution.InstitutionAddress.City = readerInstitutionAddress.GetString(2);
                this.userInstitution.InstitutionAddress.Country = readerInstitutionAddress.GetString(3);
                this.userInstitution.InstitutionAddress.HouseNumber = readerInstitutionAddress.GetInt32(4);
                this.userInstitution.InstitutionAddress.Zipcode = readerInstitutionAddress.GetInt32(5);
            }
            readerInstitutionAddress.Close();
            sqlReadCommand.Dispose();
            databaseConnection.Close();
        }

        public static int getUserDatabaseRecordID()
        {
            int id = -1;
            String cn = "URI=file:ProjectSentinel.db";
            SqliteConnection databaseConnection = new SqliteConnection(cn);
            databaseConnection.Open();
            SqliteCommand sqlReadCommand = databaseConnection.CreateCommand();
            sqlReadCommand.CommandText = "SELECT ID FROM USER WHERE ID=(SELECT MAX(ID) FROM USER);";
            SqliteDataReader reader = sqlReadCommand.ExecuteReader();
            while (reader.Read()) { id = Convert.ToInt32(reader.GetValue(0)); }
            sqlReadCommand.Dispose();
            reader.Close();
            databaseConnection.Close();
            return id;
        }
        }
}

