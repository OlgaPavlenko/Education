using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Subtraction : Operation
    {
        public override double Calculate(double firstNumber, double secondNumber)
        {
            return firstNumber - secondNumber;
        }
    }
}
