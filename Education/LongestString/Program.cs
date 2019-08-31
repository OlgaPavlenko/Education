using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LongestString
{
    class Program
    {
        static void Main(string[] args)
        {
            Longest();
        }

        public static void Longest()
        {
            string a = "xyaabbbccccdefww";
            string b = "xxxxyyyyabklmopq";
            string concat = string.Empty;
            string temp = string.Empty;

            concat = a + b;
            Console.WriteLine(concat);

            for (int i = 0; i < concat.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < temp.Length; j++)
                {
                    if (concat[i] == temp[j])
                    {
                        count++;
                    }
                }
                if (count < 1)
                {
                    temp += concat[i];
                }
            }
            char[] result = temp.ToArray();
            Array.Sort(result);

            Console.WriteLine(result);
        }
    }
}
