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
            //BetweenQuestionMark();
            //FindWord();
            //WordsReverse();
            LongerShorterWord();
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
            string stroka = "sfasf/sf? chto-to ponyatnoe glazzu ?fga";
            int startPoint = stroka.IndexOf("?");
            string tempStroka = string.Empty;

            string startStroka = stroka.Substring(startPoint + 1);
            for (int i = 0; i < startStroka.IndexOf("?"); i++)
            {
                if (!(startStroka[i] == ' '))
                {
                    tempStroka += startStroka[i];
                }

                else if (startStroka[i] == ' ')
                {
                    continue;
                }
            }
            Console.WriteLine(tempStroka);
        }

        public static void FindWord()
        {
            string stroka = "sfasf/sf? chto-to ponyatnoe glazzu ?fga";
            int wordPosision = 1;
            string[] words = stroka.Split(new char[] { });

            for (int i = 0; i < words.Length; i++)
            {
                if (i == wordPosision)
                {
                    Console.WriteLine(words[wordPosision].First());
                }
            }
        }

        public static void WordsReverse()
        {
            string stroka = "sfasf/sf? chto-to ponyatnoe glazzu ?fga";
            string[] words = stroka.Split(new char[] { });
            string[] temp = new string[words.Length];
            string result = string.Empty;

            for (int j = words.Length - 1; j >= 0; j--)
            {
                result += words[j] + " ";
            }
            Console.WriteLine(result);
        }

        public static void LongerShorterWord()
        {
            string stroka = "s chot ponyatnoe glazzu fga";
            string[] words = stroka.Split(new char[] { });
            string min = words[0];
            string max = string.Empty;

            for (int i = 0; i < words.Length - 1; i++)
            {
                if (max.Length < words[i+1].Length)
                {
                    max = words[i];
                }
                else if (min.Length > words[i + 1].Length)
                {
                    min = words[i + 1];
                }
            }
            Console.WriteLine(max);
            Console.WriteLine(min);
        }
    }
}
