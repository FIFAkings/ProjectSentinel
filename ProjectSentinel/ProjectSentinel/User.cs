using System;
using Mono.Data.Sqlite;

namespace ProjectSentinel
{
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
        public String UserPassword { get { return this.userPassword; } set { this.userPassword = value; } }
        public String UserPhoneNumber { get { return this.userPhoneNumber; } set { this.userPhoneNumber = value; } }
        public String UserEmail { get { return this.userEmail; } set { this.userEmail = value; } }
        public DateTime UserDateOfBirth { get { return this.userDateOfBirth; } set { this.userDateOfBirth = value; } }
        public int UserAge { get { return this.userAge; } set { this.userAge = value; } }
        public Address UserAddress { get { return this.userAddress; } set { this.userAddress = value; } }
        public Institution UserInstitution { get { return this.userInstitution; } set { this.userInstitution = value; } }
        public bool LoggedIn { get { return this.loggedIn; } set { this.loggedIn = value; } }

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
            sqlUserTableCommand.CommandText = @"CREATE TABLE IF NOT EXISTS USER (id integer primary key autoincrement, username varchar(33) unique not null, userEmail varchar(77) not null, userFirstName varchar(111), userLastName varchar(333), userPhoneNumber varchar(21), userDateOfBirth datetime, address_id integer not null, institution_id integer not null, foreign key (address_id) references address(id), foreign key (institution_id) references institution(id));";
            sqlUserTableCommand.ExecuteNonQuery();
            sqlUserTableCommand.Dispose();
            SqliteCommand sqlInsertUserCommand = databaseConnection.CreateCommand();
            sqlInsertUserCommand.CommandText = "INSERT INTO USER (username, userEmail, userFirstName, userLastName, userPhoneNumber, userDateOfBirth, address_id, institution_id) VALUES ('"+this.username+"', '"+this.userEmail+"', '"+this.userFirstName+"', '"+this.userLastName+"', '"+this.userPhoneNumber+"', '"+this.userDateOfBirth+"', '"+addressId+"', '"+institutionId+"');";
            sqlInsertUserCommand.ExecuteNonQuery();
            sqlInsertUserCommand.Dispose();
            databaseConnection.Close();
        }
        
    }
}
