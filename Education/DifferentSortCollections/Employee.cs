using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferentSortCollections
{
    public class Employee
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Gender { get; set; }

        public int Age { get; set; }

        public string Company { get; set; }

        public Employee(string firstName, string lastName, string gender, int age, string company)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Gender = gender;
            this.Age = age;
            this.Company = company;
        }

        public Employee()
        {
        }

        public void Defered()
        {
            var employees = new EmployeeList().GetEmployees().ToList();
            var ageEmployees = employees.Where(e => e.Age > 30).ToList();
            var maleEmployees = employees.Where(e => e.Gender == "M").ToList();
            var femaleEmployees = employees.Where(e => e.Gender == "F").ToList();
            var firstSecondNames = employees.Select().ToList();
            Console.WriteLine("Older than 30:");
            Display(ageEmployees);
            Console.WriteLine("\n");
            Console.WriteLine("Only male:");
            Display(maleEmployees);
            Console.WriteLine("\n");
            Console.WriteLine("Only female:");
            Display(femaleEmployees);
            Console.WriteLine("\n");
            Console.WriteLine("Names and Secondnames:");
            Display(firstSecondNames);
            Console.WriteLine("\n");
        }

        public void Display(IEnumerable<Employee> employees)
        {
            foreach (var employee in employees)
            {
                Console.WriteLine("{0}, {1}, {2}, {3}, {4}", employee.LastName, employee.FirstName, employee.Age, employee.Gender, employee.Company);
                Console.WriteLine("---------------------------------");
            }
        }
    }
}
