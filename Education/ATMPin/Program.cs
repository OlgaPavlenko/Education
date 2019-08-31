using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMPin
{
    class Program
    {
        static void Main(string[] args)
        {
            ValidatePin();
        }

        public static void ValidatePin()
        {
            Console.WriteLine("Eneter you pin:");
            string pin = Console.ReadLine();

            if (pin.Length == 4 || pin.Length == 6)
            {
                int number;
                bool success = Int32.TryParse(pin, out number);

                if (success)
                {
                    Console.WriteLine($"Validate {pin} is {success}");
                }

                else
                {
                    Console.WriteLine($"Validate {pin} is {success}");
                }
            }

            else
            {
                Console.WriteLine("Enter 4 or 6 numbers!!");
            }
        }
    }
}
