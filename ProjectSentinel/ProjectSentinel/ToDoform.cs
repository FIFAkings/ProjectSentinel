using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectSentinel
{
    public partial class ToDoForm : Form
    {
        ToDo toDo;
        User user;

        public ToDoForm()
        {
            InitializeComponent();
        }

        public ToDoForm(User user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                toDo = new ToDo(textBox1.Text, 1, FinishDateToDoForm.Value);
            else if (radioButton2.Checked)
                toDo = new ToDo(textBox1.Text, 2, FinishDateToDoForm.Value);
            else
                toDo = new ToDo(textBox1.Text, 3, FinishDateToDoForm.Value);
            toDo.addToDoToDatabase(user);
            this.Close();
        }
    }
}
