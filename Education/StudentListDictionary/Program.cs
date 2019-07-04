using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentListDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> studentsList = new List<Student>(3);
            Student student1 = new Student("Ivan", "Petrenko", "1", "43", "IF");
            Student student2 = new Student("Peter", "Ivanov", "2", "41", "DU");
            Student student3 = new Student("Zyan", "Kedr", "3", "34", "FA");
            Manager manager = new Manager();
            manager.AddStudent(student1);
            manager.AddStudent(student2);
            manager.AddStudent(student3);
            manager.DisplayStudentsInfo();
        }
    }
}
