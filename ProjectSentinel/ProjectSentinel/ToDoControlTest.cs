using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectSentinel
{
    public partial class ToDoControlTest : UserControl
    {
       User user = new User();
       List<ToDo> tasks = new List<ToDo>();
       ToDo task = new ToDo();
       int objectStartPosX, objectStartPosY, objectsAdded = 0;

        public ToDoControlTest()
        {
            InitializeComponent();
           user.loadUserFromDatabase(Properties.Settings.Default.LoggedUserId);
        }

        private void TodayButtonToDoControlTest_Click(object sender, EventArgs e)
        {
            loadTasksToControl();
        }

        private void Next7DaysButtonToDoControlTest_Click(object sender, EventArgs e)
        {
            loadTasksSevenDaysToControl();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ToDoForm ra = new ToDoForm(user);
            ra.ShowDialog();
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ToDoForm ra = new ToDoForm(user);
            ra.ShowDialog();
        }

        private void loadTasksToControl()
        {
            CheckBox checkBox = null;
            DateTime date = DateTime.Today;
            tasks = ToDo.returnToDoListForCurrentUser(Properties.Settings.Default.LoggedUserId);
            objectStartPosY = Convert.ToInt32(TodayButtonToDoControlTest.Location.Y);

            foreach (var task in tasks.ToList())
            {
                if (task.DateToFinish.Date == date.Date)
                {
                    objectStartPosX = Convert.ToInt32(TodayButtonToDoControlTest.Location.X);
                    checkBox = new CheckBox();
                    checkBox.Name = "taskChkbox" + objectsAdded.ToString();
                    checkBox.Text = task.Description;
                    checkBox.Width = 300;
                    checkBox.Location = new Point(objectStartPosX += 300, objectStartPosY);
                    this.Controls.Add(checkBox);
                    objectStartPosY += 25;
                    objectsAdded++;
                }
            }
            if (checkBox == null) MessageBox.Show("You have no unfinished tasks for today.", "Congratulations! | Project Sentinel");
        }

        private void loadTasksSevenDaysToControl()
        {
            CheckBox checkBox = null;
            DateTime date = DateTime.Today;
            date = date.AddDays(7);
            tasks = ToDo.returnToDoListForCurrentUser(Properties.Settings.Default.LoggedUserId);
            objectStartPosY = Convert.ToInt32(TodayButtonToDoControlTest.Location.Y);

            foreach (var task in tasks.ToList())
            {
                if (task.DateToFinish.Date > DateTime.Today.Date && task.DateToFinish.Date <= date.Date)
                {
                    objectStartPosX = Convert.ToInt32(TodayButtonToDoControlTest.Location.X);
                    checkBox = new CheckBox();
                    checkBox.Name = "taskChkbox" + objectsAdded.ToString();
                    checkBox.Text = task.Description;
                    checkBox.Width = 300;
                    checkBox.Location = new Point(objectStartPosX += 300, objectStartPosY);
                    this.Controls.Add(checkBox);
                    objectStartPosY += 25;
                    objectsAdded++;
                }
            }
            if (checkBox == null) MessageBox.Show("You have no unfinished tasks for today.", "Congratulations! | Project Sentinel");
        }

    }
}
