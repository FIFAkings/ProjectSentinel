using System;
using Mono.Data.Sqlite;

namespace ProjectSentinel
{
    static class DefaultDatabaseValues
    {
        public static void fillDatabaseWithDefaultInstitutionAddresses()
        {
            String cn = "URI=file:ProjectSentinel.db";
            SqliteConnection databaseConnection = new SqliteConnection(cn);
            databaseConnection.Open();
            SqliteCommand sqlAddressTableCommand = databaseConnection.CreateCommand();
            sqlAddressTableCommand.CommandText = @"CREATE TABLE IF NOT EXISTS ADDRESS (id integer primary key autoincrement, street varchar(99) not null, city varchar(77) not null, country varchar(111) not null, houseNumber integer not null, zipcode integer not null);";
            sqlAddressTableCommand.ExecuteNonQuery();
            sqlAddressTableCommand.Dispose();
            SqliteCommand sqlInsertAddressCommand = databaseConnection.CreateCommand();
            sqlInsertAddressCommand.CommandText = "INSERT INTO ADDRESS (street, city, country, houseNumber, zipcode) VALUES ('Trg Svetog Trojstva', 'Osijek', 'Croatia', '3', '31000');";
            sqlInsertAddressCommand.ExecuteNonQuery();
            sqlInsertAddressCommand.CommandText = "INSERT INTO ADDRESS (street, city, country, houseNumber, zipcode) VALUES ('Zagrebačka ulica', 'Pula', 'Croatia', '30', '51200');";
            sqlInsertAddressCommand.ExecuteNonQuery();
            sqlInsertAddressCommand.CommandText = "INSERT INTO ADDRESS (street, city, country, houseNumber, zipcode) VALUES ('Trg doktora Žarka Dolinara', 'Koprivnica', 'Croatia', '1', '48000');";
            sqlInsertAddressCommand.ExecuteNonQuery();
            sqlInsertAddressCommand.CommandText = "INSERT INTO ADDRESS (street, city, country, houseNumber, zipcode) VALUES ('Ulica branitelja Dubrovnika', 'Dubrovnik', 'Croatia', '41', '20000');";
            sqlInsertAddressCommand.ExecuteNonQuery();
            sqlInsertAddressCommand.CommandText = "INSERT INTO ADDRESS (street, city, country, houseNumber, zipcode) VALUES ('Trg braće Mažuranić', 'Rijeka', 'Croatia', '10', '51000');";
            sqlInsertAddressCommand.ExecuteNonQuery();
            sqlInsertAddressCommand.CommandText = "INSERT INTO ADDRESS (street, city, country, houseNumber, zipcode) VALUES ('Livanjska ulica', 'Split', 'Croatia', '5', '21000');";
            sqlInsertAddressCommand.ExecuteNonQuery();
            sqlInsertAddressCommand.CommandText = "INSERT INTO ADDRESS (street, city, country, houseNumber, zipcode) VALUES ('Ulica Mihovila Pavlinovića', 'Zadar', 'Croatia', '1', '23000');";
            sqlInsertAddressCommand.ExecuteNonQuery();
            sqlInsertAddressCommand.CommandText = "INSERT INTO ADDRESS (street, city, country, houseNumber, zipcode) VALUES ('Trg Republike Hrvatske', 'Zagreb', 'Croatia', '14', '10000');";
            sqlInsertAddressCommand.ExecuteNonQuery();
            sqlInsertAddressCommand.Dispose();
            databaseConnection.Close();
        }

        public static void fillDatabaseWithDefaultInstituions()
        {
            String cn = "URI=file:ProjectSentinel.db";
            SqliteConnection databaseConnection = new SqliteConnection(cn);
            databaseConnection.Open();
            SqliteCommand sqlInstitutionTableCommand = databaseConnection.CreateCommand();
            sqlInstitutionTableCommand.CommandText = @"CREATE TABLE IF NOT EXISTS INSTITUTION (id integer primary key autoincrement, institutionName varchar(33) not null, address_id integer not null, institutionEstablished datetime not null, FOREIGN KEY (address_id) REFERENCES ADDRESS(ID));";
            sqlInstitutionTableCommand.ExecuteNonQuery();
            sqlInstitutionTableCommand.Dispose();
            SqliteCommand sqlInsertInstitutionCommand = databaseConnection.CreateCommand();
            sqlInsertInstitutionCommand.CommandText = "INSERT INTO INSTITUTION (institutionName, address_id, institutionEstablished) VALUES ('Sveučilište J. J. Strossmayera Osijek', 1, '" + new DateTime(1975, 5, 31) + "');";
            sqlInsertInstitutionCommand.ExecuteNonQuery();
            sqlInsertInstitutionCommand.CommandText = "INSERT INTO INSTITUTION (institutionName, address_id, institutionEstablished) VALUES ('Sveučilište Jurja Dobrile u Puli', 2, '" + new DateTime(2006, 9, 29) + "');";
            sqlInsertInstitutionCommand.ExecuteNonQuery();
            sqlInsertInstitutionCommand.CommandText = "INSERT INTO INSTITUTION (institutionName, address_id, institutionEstablished) VALUES ('Sveučilište Sjever', 3, '" + new DateTime(2015, 5, 29) + "');";
            sqlInsertInstitutionCommand.ExecuteNonQuery();
            sqlInsertInstitutionCommand.CommandText = "INSERT INTO INSTITUTION (institutionName, address_id, institutionEstablished) VALUES ('Sveučilište u Dubrovniku', 4, '" + new DateTime(2003, 10, 1) + "');";
            sqlInsertInstitutionCommand.ExecuteNonQuery();
            sqlInsertInstitutionCommand.CommandText = "INSERT INTO INSTITUTION (institutionName, address_id, institutionEstablished) VALUES ('Sveučilište u Rijeci', 5, '" + new DateTime(1973, 5, 17) + "');";
            sqlInsertInstitutionCommand.ExecuteNonQuery();
            sqlInsertInstitutionCommand.CommandText = "INSERT INTO INSTITUTION (institutionName, address_id, institutionEstablished) VALUES ('Sveučilište u Splitu', 6, '" + new DateTime(1974, 6, 15) + "');";
            sqlInsertInstitutionCommand.ExecuteNonQuery();
            sqlInsertInstitutionCommand.CommandText = "INSERT INTO INSTITUTION (institutionName, address_id, institutionEstablished) VALUES ('Sveučilište u Zadru', 7, '" + new DateTime(2002, 7, 4) + "');";
            sqlInsertInstitutionCommand.ExecuteNonQuery();
            sqlInsertInstitutionCommand.CommandText = "INSERT INTO INSTITUTION (institutionName, address_id, institutionEstablished) VALUES ('Sveučilište u Zagrebu', 8, '" + new DateTime(1669, 9, 23) + "');";
            sqlInsertInstitutionCommand.ExecuteNonQuery();
            sqlInsertInstitutionCommand.Dispose();
            databaseConnection.Close();
        }
    }
}
