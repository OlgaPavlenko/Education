using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JadeSmith
{
    class Program
    {
        static void Main(string[] args)
        {
            Smith();
        }

        public static void Smith()
        {
            string notSmith = "How can mirrors be real if our eyes aren't real";
            string smith = String.Empty;
            string[] words = notSmith.Split(new char[] { ' ' });

            foreach (var item in words)
            {
                string tempword = string.Empty;
                char[] arrayItem = item.ToCharArray();
                arrayItem[0] = char.ToUpper(arrayItem[0]);
                tempword = new string(arrayItem);
                smith += tempword + " ";
            }
            Console.WriteLine(smith);
        }
    }
}
