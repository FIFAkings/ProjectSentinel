using System;
using Mono.Data.Sqlite;

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

        public static string getInstitutionName(int registerComboBoxIndex)
        {
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
        }

        public static Address getInstitutionAddress(int registerComboBoxIndex)
            {
                Address institutionAddress;
                switch (registerComboBoxIndex)
                {
                    case 1:
                        institutionAddress = new Address("Zagrebačka ulica", "Pula", "Croatia", 30, 51200);
                        return institutionAddress;
                    case 2:
                        institutionAddress = new Address("Trg doktora Žarka Dolinara", "Koprivnica", "Croatia", 1, 48000);
                        return institutionAddress;
                    case 3:
                        institutionAddress = new Address("Ulica branitelja Dubrovnika", "Dubrovnik", "Croatia", 41, 20000);
                        return institutionAddress;
                    case 4:
                        institutionAddress = new Address("Trg braće Mažuranić", "Rijeka", "Croatia", 10, 51000);
                        return institutionAddress;
                    case 5:
                        institutionAddress = new Address("Livanjska ulica", "Split", "Croatia", 5, 21000);
                        return institutionAddress;
                    case 6:
                        institutionAddress = new Address("Ulica Mihovila Pavlinovića", "Zadar", "Croatia", 1, 23000);
                        return institutionAddress;
                    case 7:
                        institutionAddress = new Address("Trg Republike Hrvatske", "Zagreb", "Croatia", 14, 10000);
                        return institutionAddress;
                    default:
                        institutionAddress = new Address("Trg Svetog Trojstva", "Osijek", "Croatia", 3, 31000);
                        return institutionAddress;
                }
        }

        public static DateTime getInstitutionFoundingDate(int registerComboBoxIndex)
        {
            DateTime foundingDate;
            switch (registerComboBoxIndex)
            {
                case 1:
                    foundingDate = new DateTime(2006, 9, 29);
                    return foundingDate;
                case 2:
                    foundingDate = new DateTime(2015, 5, 29);
                    return foundingDate;
                case 3:
                    foundingDate = new DateTime(2003, 10, 1);
                    return foundingDate;
                case 4:
                    foundingDate = new DateTime(1973, 5, 17);
                    return foundingDate;
                case 5:
                    foundingDate = new DateTime(1974, 6, 15);
                    return foundingDate;
                case 6:
                    foundingDate = new DateTime(2002, 7, 4);
                    return foundingDate;
                case 7:
                    foundingDate = new DateTime(1669, 9, 23);
                    return foundingDate;
                default:
                    foundingDate = new DateTime(1975, 5, 31);
                    return foundingDate;
            }
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
