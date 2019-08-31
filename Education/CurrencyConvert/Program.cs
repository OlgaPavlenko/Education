using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose the currency: 1 - $; 2 - €; 3 - ₴");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter amount of $ you want to exchange:");
                    decimal sumOfDollars = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("Enter the exchange rate:");
                    decimal rate = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine($"Result is: {sumOfDollars * rate}");
                    break;
                case 2:
                    Console.WriteLine("Enter amount of € you want to exchange:");
                    decimal sumOfEuros = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("Enter the exchange rate:");
                    decimal rateEuros = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine($"Result is: {sumOfEuros * rateEuros}");
                    break;
                case 3:
                    Console.WriteLine("Enter amount of ₴ you want to exchange:");
                    decimal sumOfGriunas = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("Enter the exchange rate:");
                    decimal rateGriunas = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine($"Result is: {sumOfGriunas * rateGriunas}");
                    break;
            }
        }
    }
}
