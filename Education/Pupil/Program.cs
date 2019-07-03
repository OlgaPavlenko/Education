using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pupil
{
    class Program
    {
        static void Main(string[] args)
        {
            Pupil[] pupils = new Pupil[2];

            pupils[0] = new Pupil("Rodion", new DateTime(2013, 05, 31), "Pavlenko", "53", "1A");
            pupils[1] = new Pupil("Vita", new DateTime(2010, 02, 23), "Gugug", "153", "3B");

            Console.WriteLine("\n" + String.Format("{0, -10} {1, -10} {2, -10} {3, -5} {4, -8} {5, -7}", "Name", "Surname", "BirthYear", "Age", "School", "Class"));
            foreach (var item in pupils)
            {
                Console.WriteLine(String.Format("{0, -10} {1, -10} {2, -10} {3, -5} {4, -8} {5, -7}", item.name, item.secondName, item.yearOfBirth, item.age, item.School, item.SchoolClass));
            }
        }
    }
}