using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //DelDupls();
            //CountSymbol();
            //JoinStrings();
            //DelDoubleSpaces();
            BetweenQuestionMark();
        }

        public static void DelDupls()
        {
            string stroka = "ddsf adfaf sdfadfghe";
            string result = String.Empty;

            for (int i = 0; i < stroka.Length; i++)
            {
                bool doupl = false;

                for (int j = 0; j < result.Length; j++)
                {

                    if (stroka[i] == result[j])
                    {
                        doupl = true;
                        break;
                    }
                }

                if (doupl == false)
                {
                    result += stroka[i];
                }
            }
            Console.WriteLine(result);
        }

        public static void CountSymbol()
        {
            string stroka = "ddsf adfaf sdfadfghe";
            char symbol = 'p';
            int count = 0;

            for (int i = 0; i < stroka.Length; i++)
            {
                if (stroka[i] == symbol)
                {
                    count++;
                }

                else if (stroka[i] != symbol)
                {
                    continue;
                }
            }
            Console.WriteLine(count);
        }

        public static void JoinStrings()
        {
            string stroka = "againg and again";
            string subStroka = "do it ";

            stroka = stroka.Insert(0, subStroka);
            Console.WriteLine(stroka);
        }

        public static void DelDoubleSpaces()
        {
            string stroka = "Sdfaf  Afafga Dfgagd  Adfgadfga  Adg";
            string result = string.Empty;
            
            string[] words = stroka.Split(new char[] { });

            foreach (string item in words)
            {
                if (item == string.Empty)
                {
                    continue;
                }

                else
                {
                    result += item + " ";
                }
            }
            Console.WriteLine(result);
        }

        public static void BetweenQuestionMark()
        {
            string stroka = "aagafg agdadga ? dafga adfgagf afadfg? afdafagdfga";
            int startPoint = stroka.IndexOf("?");
            string startStroka = stroka.Substring(startPoint);
            int endPoint = startStroka.IndexOf("?");
            string endStroka = startStroka.Substring(endPoint);
            Console.WriteLine(endStroka);
        }
    }
}
