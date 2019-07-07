using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defered
{
    public class EmployeeList
    {
        public List<Employee> GetEmployees()
        {
            return new List<Employee>()
         {
            new Employee("Elena", "Zub", "F"),
            new Employee("Vlad", "Radchenko", "M"),
            new Employee("Kirill", "Novikov", "M")
         };
        }
    }
}
