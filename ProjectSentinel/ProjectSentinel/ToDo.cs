using Mono.Data.Sqlite;
using System.Data.SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public void addToDoToDatabase(User user)
        {
            String cn = "URI=file:ProjectSentinel.db";
            SqliteConnection databaseConnection = new SqliteConnection(cn);
            databaseConnection.Open();
            SqliteCommand sqlToDoTableCommand = databaseConnection.CreateCommand();
            sqlToDoTableCommand.CommandText = @"CREATE TABLE IF NOT EXISTS TODO (id integer primary key autoincrement, description varchar (937) not null, priority integer not null, dateToFinish datetime, user_id, foreign key (user_id) references user(id));";
            sqlToDoTableCommand.ExecuteNonQuery();
            sqlToDoTableCommand.Dispose();
            SqliteCommand sqlInsertToDoCommand = databaseConnection.CreateCommand();
            sqlInsertToDoCommand.CommandText = "INSERT INTO TODO (description, priority, dateToFinish, user_id) VALUES ('" + this.description + "', '" + this.priorityLevel + "', '" + this.dateToFinish + "', '" + Properties.Settings.Default.LoggedUserId + "');";
            sqlInsertToDoCommand.ExecuteNonQuery();
            sqlInsertToDoCommand.Dispose();
            databaseConnection.Close();
            MessageBox.Show("Dear "+user.Username+ ", this task has been added to your to do list successfully! Add a new task or go back.", "You're doing great, "+user.UserFirstName+"! | Project Sentinel");
        }

        public static List<ToDo> returnToDoListForCurrentUser(int userId)
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
                    ToDo task = new ToDo();
                    task.Description = reader.GetString(1);
                    task.PriorityLevel = reader.GetInt32(2);
                    task.DateToFinish = Convert.ToDateTime(reader.GetString(3));
                    list.Add(task);
                }

            
            
            sqlReadCommand.Dispose();
            reader.Close();
            databaseConnection.Close();


            return list;
        }

    }
}
