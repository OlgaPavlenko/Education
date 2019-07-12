using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentListWithDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Student> studentsDictionary = new Dictionary<string, Student>()
            {
                { "Ivan Petrenko", new Student ( "Ivan", "Petrenko", "1", "43", "IF" ) },
                { "Peter Ivanov", new Student ( "Peter", "Ivanov", "2", "41", "DU" ) },
                { "Zyan Kedr", new Student ( "Zyan", "Kedr", "3", "34", "FA") }
            };

            Student getStudent = new Student();
            bool found = studentsDictionary.TryGetValue("Mcghhcgh Ivanov", out getStudent);

            if (found)
            {
                Console.WriteLine(getStudent);
            }
            else
            {
                Console.WriteLine("Value was not found!!!");
            }
        }
    }
}
