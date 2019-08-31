using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CarRace
{
    class Program
    {
        public static object myLocker = new object();

        static void Main(string[] args)
        {
            Creator.Execute();
            Console.ReadKey();
        }
    }
}
