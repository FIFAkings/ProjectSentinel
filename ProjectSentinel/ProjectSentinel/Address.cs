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
        private int zipcode, houseNumber;

        public string Street { get { return this.street; } set { this.street = value; } }
        public string City { get { return this.city; } set { this.city = value; } }
        public string Country { get { return this.country; } set { this.country = value; } }
        public int HouseNumber { get { return this.houseNumber; } set { this.houseNumber = value; } }
        public int Zipcode { get { return this.zipcode; } set { this.zipcode = value; } }


        public Address(string str, string cty, string ctry, int numb, int zip)
        {
            // this.addressId = Ovaj dio koda ću nadopuniti naknadno
            this.street = str;
            this.city = cty;
            this.country = ctry;
            this.houseNumber = numb;
            this.zipcode = zip;
        }

        public void changeAddress(string str, string cty, string ctry, int numb, int zip)
        {
            this.street = str;
            this.city = cty;
            this.country = ctry;
            this.houseNumber = numb;
            this.zipcode = zip;
        }

        public void addAddressToDatabase()
        {
            String cn = "URI=file:ProjectSentinel.db";
            SqliteConnection databaseConnection = new SqliteConnection(cn);
            databaseConnection.Open();
            SqliteCommand sqlAddressTableCommand = databaseConnection.CreateCommand();
            sqlAddressTableCommand.CommandText = @"CREATE TABLE IF NOT EXISTS ADDRESS (id integer primary key autoincrement, street varchar(33) not null, city varchar(58) not null, country varchar(111) not null, houseNumber integer not null, zipcode integer not null);";
            sqlAddressTableCommand.ExecuteNonQuery();
            sqlAddressTableCommand.Dispose();
            SqliteCommand sqlInsertAddressCommand = databaseConnection.CreateCommand();
            sqlInsertAddressCommand.CommandText = "INSERT INTO ADDRESS (street, city, country, houseNumber, zipcode) VALUES ('"+this.street+"', '"+this.city+"', '"+this.country+"', '"+this.houseNumber+"', '"+this.zipcode+"');";
            sqlInsertAddressCommand.ExecuteNonQuery();
            sqlInsertAddressCommand.Dispose();
            databaseConnection.Close();
        }

       public int getAddressDatabaseRecordID() {
            int id = 0;
            String cn = "URI=file:ProjectSentinel.db";
            SqliteConnection databaseConnection = new SqliteConnection(cn);
            databaseConnection.Open();
            SqliteCommand sqlReadCommand = databaseConnection.CreateCommand();
            sqlReadCommand.CommandText = "SELECT ID FROM ADDRESS WHERE ID=(SELECT MAX(ID) FROM ADDRESS);";
            SqliteDataReader reader = sqlReadCommand.ExecuteReader();
            while (reader.Read()) { id = Convert.ToInt32(reader.GetValue(0)); }
            sqlReadCommand.Dispose();
            databaseConnection.Close();
            return id;
        }

    }
}
