using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printer
{
    class Program
    {
        static void Main(string[] args)
        {
            string letters = "aaaaaaaaaaaaabbbbbbbbbbbbbmmmmmmmmmmmmmmmmmmmxyxxxxz";
            letters.ToLower();
            int counter = 0;
            float errorCount = 0;

            for (int i = 0; i < letters.Length; i++)
            {
                if (letters[i] > 'm')
                {
                    counter++;
                }
            }
            errorCount = counter / letters.Length;
            Console.WriteLine(errorCount);
        }
    }
}
