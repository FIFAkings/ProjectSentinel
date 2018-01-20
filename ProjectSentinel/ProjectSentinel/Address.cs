using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mono.Data.Sqlite;
using System.Data.SQLite;

namespace ProjectSentinel
{
    public class Address
    {

        private string street, city, country;
        private ushort houseNumber;
        private uint zipcode;
        private ulong addressId;

        public string Street { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public ushort HouseNumber { get; set; }
        public uint Zipcode { get; set; }


        public Address(string str, string cty, string ctry, ushort numb, uint zip)
        {
            // this.addressId = Ovaj dio koda ću nadopuniti naknadno
            this.street = str;
            this.city = cty;
            this.country = ctry;
            this.houseNumber = numb;
            this.zipcode = zip;
        }

        public void changeAddress(string str, string cty, string ctry, ushort numb, uint zip)
        {
            this.street = str;
            this.city = cty;
            this.country = ctry;
            this.houseNumber = numb;
            this.zipcode = zip;
        }

        public void addUserToDatabase()
        {
            String cn = "URI=file:ProjectSentinel.db";
            SqliteConnection databaseConnection = new SqliteConnection(cn);
            databaseConnection.Open();
            SqliteCommand sqlUserTableCommand = databaseConnection.CreateCommand();
            sqlUserTableCommand.CommandText = @"CREATE TABLE IF NOT EXISTS ADDRESS (id integer primary key autoincrement, street varchar(33) not null, city varchar(58) not null, country varchar(111) not null, houseNumber integer not null, zipcode integer not null);";
            sqlUserTableCommand.ExecuteNonQuery();
            sqlUserTableCommand.Dispose();
            SqliteCommand sqlInsertUserCommand = databaseConnection.CreateCommand();
            sqlInsertUserCommand.CommandText = "INSERT INTO ADDRESS (street, city, country, houseNumber, zipcode) VALUES ('"+this.street+"', '"+this.city+"', '"+this.country+"', '"+this.houseNumber+"', '"+this.zipcode+"');";
            sqlInsertUserCommand.ExecuteNonQuery();
            sqlInsertUserCommand.Dispose();
            databaseConnection.Close();
        }

    }
}
