using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleOddSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of the row");
            int row = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            sum = row * row * row;

            Console.WriteLine($"Sum of the numbers of {row} row is: {sum}");
        }
    }
}
