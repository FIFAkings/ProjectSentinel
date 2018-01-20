using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mono.Data.Sqlite;
using System.Data.SQLite;
using System.Security.Cryptography;

namespace ProjectSentinel
{
    public class User
    {

        private String username, userFirstName, userLastName, userPassword, userPhoneNumber, userEmail;
        private DateTime userDateOfBirth;
        private ulong userId;
        private int userAge;
        private Address userAddress;
        private Institution userInstitution;
        private bool loggedIn;

        public String Username { get; set; }
        public String UserFirstName { get; set; }
        public String UserLastName { get; set; }
        public String UserPassword { get; set; }
        public String UserPhoneNumber { get; set; }
        public String UserEmail { get; set; }
        public DateTime UserDateOfBirth { get; set; }
        public ulong UserId { get; set; }
        public int UserAge { get; set; }
        public Address UserAddress { get; set; }
        public Institution UserInstitution { get; set; }
        public bool LoggedIn { get; set; }

        public User()
        {
            loggedIn = false;
        }

        public User(ulong id, String un, String ufn, String uln, String pw, String pn, String email, DateTime dob, Address address, Institution inst)
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
            userId = id;
        }

        private int calculateUserAge(DateTime dateOfBirth)
        {
            int age;
            DateTime today = DateTime.Today;
            age = today.Year - dateOfBirth.Year;
            if (dateOfBirth > today.AddYears(-age)) age = age - 1;
            return age;
        }

        public void addUserToDatabase()
        {
            String cn = "URI=file:ProjectSentinel.db";
            SqliteConnection databaseConnection = new SqliteConnection(cn);
            databaseConnection.Open();
            SqliteCommand sqlUserTableCommand = databaseConnection.CreateCommand();
            sqlUserTableCommand.CommandText = @"CREATE TABLE IF NOT EXISTS USER (id integer primary key autoincrement, username varchar(33) not null, userEmail varchar(77) not null, userFirstName varchar(111), userLastName varchar(333), userPhoneNumber varchar(21), userDateOfBirth datetime, address_id integer, institution_id integer, foreign key (address_id) references address(id), foreign key (institution_id) references institution(id);";
            sqlUserTableCommand.ExecuteNonQuery();
            sqlUserTableCommand.Dispose();
            SqliteCommand sqlInsertUserCommand = databaseConnection.CreateCommand();
            sqlInsertUserCommand.CommandText = "INSERT INTO USER (username, userEmail, userFirstName, userLastName, userPhoneNumber, userDateOfBirth, address_id integer, institution_id integer) VALUES ();";
            sqlInsertUserCommand.ExecuteNonQuery();
            sqlInsertUserCommand.Dispose();
            databaseConnection.Close();
        }
        
    }
}
