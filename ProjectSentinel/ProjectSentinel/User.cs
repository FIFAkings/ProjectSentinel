using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
