using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pupil
{
    class Pupil
    {

        public string name;
        public string secondName;
        public string School { get; set; }
        public string SchoolClass { get; set; }
        public int age;
        public int yearOfBirth;

        public int GetAge(DateTime dateOfBirth)
        {
            int age;
            age = Convert.ToInt32(DateTime.Now.Year - dateOfBirth.Year);
            return age;
        }

        public Pupil(string name, DateTime dateOfBirth, string secondName, string School, string SchoolClass)
        {
            this.yearOfBirth = dateOfBirth.Year;
            this.age = GetAge(dateOfBirth);
            this.name = name;
            this.secondName = secondName;
            this.School = School;
            this.SchoolClass = SchoolClass;
        }
    }
}
