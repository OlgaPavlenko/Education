using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Calculator
    {
        public void CalculationPerform()
        {
            Subtraction subtraction = new Subtraction();
            Multi multi = new Multi();
            DevideOperation devideOperation = new DevideOperation();
            SumOperation sumOperation = new SumOperation();

            Console.WriteLine(subtraction.Calculate(2, 3));
            Console.WriteLine(multi.Calculate(2, 3));
            Console.WriteLine(devideOperation.Calculate(2, 3));
            Console.WriteLine(sumOperation.Calculate(2, 3));
        }
    }
}
