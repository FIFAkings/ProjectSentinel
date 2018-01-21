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
    public class Institution
    {
        private string institutionName;
        private Address institutionAddress;
        private DateTime institutionEstablished;

        public string InstitutionName { get { return this.institutionName; } set { this.institutionName = value; } }
        public Address InstitutionAddress { get { return this.institutionAddress; } set { this.institutionAddress = value; } }
        public DateTime InstitutionEstablished { get { return this.institutionEstablished; } set { this.institutionEstablished = value; } }


        public Institution() { }

        public Institution(string instName, Address instAddress, DateTime instEst)
        {
            this.institutionName = instName;
            this.institutionAddress = instAddress;
            this.institutionEstablished = instEst;
        }

        public void addInstitutionToDatabase(int addressId)
        {
            String cn = "URI=file:ProjectSentinel.db";
            SqliteConnection databaseConnection = new SqliteConnection(cn);
            databaseConnection.Open();
            SqliteCommand sqlInstitutionTableCommand = databaseConnection.CreateCommand();
            sqlInstitutionTableCommand.CommandText = @"CREATE TABLE IF NOT EXISTS INSTITUTION (id integer primary key autoincrement, institutionName varchar(33) not null, address_id integer not null, institutionEstablished datetime not null, FOREIGN KEY (address_id) REFERENCES ADDRESS(ID));";
            sqlInstitutionTableCommand.ExecuteNonQuery();
            sqlInstitutionTableCommand.Dispose();
            SqliteCommand sqlInsertInstitutionCommand = databaseConnection.CreateCommand();
            sqlInsertInstitutionCommand.CommandText = "INSERT INTO INSTITUTION (institutionName, address_id, institutionEstablished) VALUES ('" + this.institutionName + "', '" + addressId + "', '" + this.institutionEstablished + "');";
            sqlInsertInstitutionCommand.ExecuteNonQuery();
            sqlInsertInstitutionCommand.Dispose();
            databaseConnection.Close();
        }

        public static string getInstitutionName(int registerComboBoxIndex) {
            string institutionName;
            switch (registerComboBoxIndex)
            {
                case 1:
                    institutionName = "Sveučilište Jurja Dobrile u Puli";
                    return institutionName;
                case 2:
                    institutionName = "Sveučilište Sjever";
                    return institutionName; 
                case 3:
                    institutionName = "Sveučilište u Dubrovniku";
                    return institutionName;
                case 4:
                    institutionName = "Sveučilište u Rijeci";
                    return institutionName;
                case 5:
                    institutionName = "Sveučilište u Splitu";
                    return institutionName;
                case 6:
                    institutionName = "Sveučilište u Zadru";
                    return institutionName;
                case 7:
                    institutionName = "Sveučilište u Zagrebu";
                    return institutionName;
                default:
                    institutionName = "Sveučilište J. J. Strossmayera Osijek";
                    return institutionName;
            }
        /*
            String cn = "URI=file:ProjectSentinel.db";
            SqliteConnection databaseConnection = new SqliteConnection(cn);
            databaseConnection.Open();
            SqliteCommand sqlReadCommand = databaseConnection.CreateCommand();
            sqlReadCommand.CommandText = "SELECT ID FROM INSTITUTION WHERE ID=(SELECT MAX(ID) FROM INSTITUTION);";
            SqliteDataReader reader = sqlReadCommand.ExecuteReader();
            while (reader.Read()) { id = Convert.ToInt32(reader.GetValue(0)); }
            sqlReadCommand.Dispose();
            databaseConnection.Close();
        */
        }
    }
}
