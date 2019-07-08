using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferentSortCollections
{
    public class EmployeeList
    {
        public List<Employee> GetEmployees()
        {
            return new List<Employee>()
         {
            new Employee("Elena", "Zub", "F", 22, "Intetics"),
            new Employee("Vlad", "Radchenko", "M", 23, "Intetics"),
            new Employee("Kirill", "Novikov", "M", 28, "Intetics"),
            new Employee("Tatiana", "Rygik", "F", 36, "Intetics"),
            new Employee("Olga", "Pavlenko", "F", 35, "Intetics")
         };
        }
    }
}
