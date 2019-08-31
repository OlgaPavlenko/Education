using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            payTheDebtOff();
        }

        public static decimal EnterTheSum()
        {
            Console.WriteLine("Enter the sum:");
            return Convert.ToDecimal(Console.ReadLine());
        }

        public static void payTheDebtOff()
        {
            decimal temp = 0;
            int count = 0;
            decimal ostatok = 0;
            bool lastPaymant = false;

            while (true)
            {
                decimal sum = EnterTheSum();

                if (sum < ostatok)
                {
                    Console.WriteLine("Add more money!!!!");
                    continue;
                }
                
                temp += sum;
                count++;
                
                if (count == 6)
                {
                    ostatok = 700 - temp;
                    Console.WriteLine($"Attention!!!! You shood pay {ostatok} next time!!!");
                    lastPaymant = true;
                }

                else if (temp >= 700)
                {
                    Console.WriteLine("You Paid The Debt Off!!! Congrads");
                    break;
                }
            }
        }
    }
}
