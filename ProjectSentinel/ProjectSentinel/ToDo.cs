using Mono.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSentinel
{
    public class ToDo
    {

        private string description;
        private bool done;
        private int priorityLevel;
        private DateTime dateToFinish;


        public string Description { get { return this.description; } set { this.description = value; } }
        public bool Done { get { return this.done; } set { this.done = value; } }
        public int PriorityLevel { get { return this.priorityLevel; } set { this.priorityLevel = value; } }
        public DateTime DateToFinish { get { return this.dateToFinish; } set { this.dateToFinish = value; } }

       

        public ToDo()
        {
            this.done = false;
        }

        public ToDo(string desc, int priority)
        {
            this.description = desc;
            this.priorityLevel = priority;
            this.done = false;
        }

        public ToDo(string desc, int priority, DateTime date)
        {
            this.description = desc;
            this.priorityLevel = priority;
            this.dateToFinish = date;
            this.done = false;
        }

        public void addToDoToDatabase(int userId)
        {
            String cn = "URI=file:ProjectSentinel.db";
            SqliteConnection databaseConnection = new SqliteConnection(cn);
            databaseConnection.Open();
            SqliteCommand sqlToDoTableCommand = databaseConnection.CreateCommand();
            sqlToDoTableCommand.CommandText = @"CREATE TABLE IF NOT EXISTS TODO (id integer primary key autoincrement, description varchar (937) not null, priority integer not null, dateToFinish datetime, user_id, foreign key (user_id) references user(id));";
            sqlToDoTableCommand.ExecuteNonQuery();
            sqlToDoTableCommand.Dispose();
            SqliteCommand sqlInsertToDoCommand = databaseConnection.CreateCommand();
            sqlInsertToDoCommand.CommandText = "INSERT INTO TODO (description, priority, dateToFinish, user_id) VALUES ('" + this.description + "', '" + this.priorityLevel + "', '" + this.dateToFinish + "', '" + userId + "');";
            sqlInsertToDoCommand.ExecuteNonQuery();
            sqlInsertToDoCommand.Dispose();
            databaseConnection.Close();
        }

        public List<ToDo> returnToDoListForCurrentUser(int userId)
        {
            List<ToDo> list = new List<ToDo>();
            String cn = "URI=file:ProjectSentinel.db";
            SqliteConnection databaseConnection = new SqliteConnection(cn);
            databaseConnection.Open();
            SqliteCommand sqlReadCommand = databaseConnection.CreateCommand();
            sqlReadCommand.CommandText = "SELECT * FROM TODO WHERE USER_ID='" + userId + "';";
            SqliteDataReader reader = sqlReadCommand.ExecuteReader();
            while (reader.Read())
            {
                this.description = reader.GetString(1);
                this.priorityLevel = reader.GetInt32(2);
                this.dateToFinish = Convert.ToDateTime(reader.GetString(3));
                list.Add(this);
            }
            sqlReadCommand.Dispose();
            reader.Close();
            databaseConnection.Close();


            return list;
        }

    }
}
