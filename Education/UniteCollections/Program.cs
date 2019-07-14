using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniteCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] employee1 = { "Ivan Rylkov", "Victoriia Peretiat'ko", "Semen Shtanoprud", "Evgeniy Kozobrod", "Dmitrii Dergavin" };
            string[] employee2 = { "Ivan Rylkov", "Eleno Pisarenko", "Victoriia Peretiat'ko", "Semen Shtanoprud", "Evgeniy Kozobrod" };

            IEnumerable<string> employeeUn = employee1.Cast<string>().Concat(employee2);
            IEnumerable<string> employeeWithoutDupls = employee1.Cast<string>().Union(employee2);
            IEnumerable<string> employeeOnlyDupls = employee1.Cast<string>().Intersect(employee2);
            employeeOnlyDupls.ToList().Add("Epty Mopty");

            foreach (var item in employeeOnlyDupls)
            {
                Console.WriteLine(item);
            }
        }
    }
}

