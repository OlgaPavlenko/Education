using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PrscticeJune8
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Windows\System32";
            var directoryInfo = new DirectoryInfo(path);
            int count = 0;
            foreach (var item in directoryInfo.GetDirectories())
            {
                count++;
            }
            Console.WriteLine(count);
        }
    }
}
