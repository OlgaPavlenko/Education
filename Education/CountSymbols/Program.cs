using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Temp\\userText.txt";
            int countLines = 0;

            string[] readTextLines = File.ReadAllLines(path);
            foreach (string s in readTextLines)
            {
                countLines++;
            }

            string readText = File.ReadAllText(path);
            int count = 1;
            for (int i = 0; i < readText.Length; i++)
            {
                if ((readText[i] == ' ') || (readText[i] == '\n'))
                {
                    count++;
                }
            }
            Console.WriteLine($"Number of Lines: {countLines}");
            Console.WriteLine($"Number of Symbols: {readText.Length}");
            Console.WriteLine($"Number of Words: {count}");
        }
    }
}

