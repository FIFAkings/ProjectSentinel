using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSentinel
{
    class Faculty
    {

        private Institution university;
        private string facultyName;

        public Institution University
        {
            get { return this.university; }
            set { this.university = value; }
        }
        public string FacultyName
        {
            get { return this.facultyName; }
            set { this.facultyName = value; }
        }

        public Faculty(Institution uni, string name)
        {
            this.university = uni;
            this.facultyName = name;
        }

    }
}
