using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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

        public override string ToString()
        {
            return this.LastName + " " + this.FirstName + " " + this.Age + " " + this.Gender + " " + this.Company;
        }


        public void Defered()
        {
            var employees = new EmployeeList().GetEmployees().ToList();
            var employeesAlpha = employees.OrderBy(e => e.FirstName).ToList();
            var ageEmployees = employees.Where(e => e.Age > 30).ToList();
            var maleEmployees = employees.Where(e => e.Gender == "M").ToList();
            var femaleEmployees = employees.Where(e => e.Gender == "F").ToList();
            var firstSecondNames = employees.Select(e => e.FirstName + " " + e.LastName).ToList();
            var femaleEmployeesStartsO = employees.Where(e => e.Gender == "F" && e.FirstName.StartsWith("O") && e.Age > 20).ToList();
            var firstEmployee = employees.First();
            var lastEmployee = employees.Last();
            var lastEmployeeOlder = employees.First(e => e.Age > 25);
            var newOleg = employees.Where(e => e.FirstName == "Oleg");
            Pupil oleg = new Pupil();

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
            foreach (var item in firstSecondNames)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n");

            Console.WriteLine("Female, Older than 20, firstName starts to O:");
            Display(femaleEmployeesStartsO);
            Console.WriteLine("\n");

            Console.WriteLine("Alphabate order:");
            Display(employeesAlpha);
            Console.WriteLine("\n");

            Console.WriteLine("First employee:");
            Console.WriteLine(firstEmployee.ToString());
            Console.WriteLine("\n");

            Console.WriteLine("Last employee:");
            Console.WriteLine(lastEmployee.ToString());
            Console.WriteLine("\n");

            Console.WriteLine("Last employee:");
            Console.WriteLine(lastEmployeeOlder.ToString());
            Console.WriteLine("\n");

            Console.WriteLine("Oleg employee:");
            Display(newOleg);
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

    public class Pupil
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string School { get; set; }

        public Pupil(string firstName, string lastName, string school)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.School = school;
        }

        public Pupil()
        {
        }
    }
}
