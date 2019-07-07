using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defered
{
    public class Employee
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Gender { get; set; }

        public Employee(string firstName, string lastName, string gender)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Gender = gender;
        }

        public Employee()
        {
        }

        public void Defered()
        {
            var employees = new EmployeeList().GetEmployees().ToList();
            var maleEmployees = employees.Where(e => e.Gender == "M").ToList();
            Display(maleEmployees);
            employees.Add(new Employee { FirstName = "Rob", LastName = "Starck", Gender = "M" });
            Display(maleEmployees);
        }

        public void Display(IEnumerable<Employee> employees)
        {
            foreach (var employee in employees)
            {
                Console.WriteLine("{0}, {1}", employee.LastName, employee.FirstName);
                Console.WriteLine("---------------------------------");
            }
        }
    }
}
