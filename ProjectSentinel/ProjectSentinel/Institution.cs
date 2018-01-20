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
    }
}
