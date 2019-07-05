using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentListWithDictionary
{
    public class Student
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public string Course { get; set; }

        public string Group { get; set; }

        public string Faculty { get; set; }

        public Student(string name, string surname, string course, string groupe, string faculty)
        {
            this.Name = name;
            this.Surname = surname;
            this.Course = course;
            this.Group = groupe;
            this.Faculty = faculty;
        }

        public Student() { }

        public override string ToString()
        {
            return $"Name { this.Name}, Surname {this.Surname}, Course {this.Course}, Group {this.Group}, Faculty {this.Faculty}";
        }
    }
}

