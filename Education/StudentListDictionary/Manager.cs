using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentListDictionary
{
    public class Manager
    {
        public List<Student> StudentList { get; set; }

        public Manager()
        {
            this.StudentList = new List<Student>();
        }

        public void AddStudent(Student student)
        {
            this.StudentList.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            this.StudentList.Remove(student);
        }

        public void DisplayStudentsInfo()
        {
            Console.Clear();
            Console.WriteLine(new string('*', 60));
            Console.WriteLine("\n" + String.Format("{0, -3} {1, -10} {2, -10} {3, -10} {4, -5}", "Name", "Surname", "Course", "Group", "Faculty"));
            int count = 0;

            foreach (var item in StudentList)
            {
                count++;
                Console.WriteLine(String.Format("{0, -3} {1, -10} {2, -10} {3, -10} {4, -5}", item.Name, item.Surname, item.Course, item.Group, item.Faculty));
                Console.WriteLine($"We have " + count + " students");
            }
        }
    }
}
