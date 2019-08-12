using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vowels
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "aeiou/ ";
            char[] letters = new char[text.Length];
            
            int count = 0;

            for (int i = 0; i < text.Length; i++)
            {
                letters[i] = text[i];

                if ((letters[i] == 'a') || (letters[i] == 'e') || (letters[i] == 'i') || (letters[i] == 'o') || (letters[i] == 'u'))
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
