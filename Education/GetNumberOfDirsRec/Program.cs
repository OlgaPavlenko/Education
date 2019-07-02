using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GetNumberOfDirsRec
{
    class Program
    {
        static void Main(string[] args)
        {
            GetPathes path = new GetPathes();
            path.GetNumberOfDirs("C:\\Users\\o.pavlenko\\.atom");
            path.GetSizeOfDirs("C:\\Users\\o.pavlenko\\.atom");
        }
    }

    class GetPathes
    {
        int count = 0;
        int sum = 0;

        public int GetNumberOfDirs(string dirName)
        {
            if (Directory.Exists(dirName))
            {
                string[] dirs = Directory.GetDirectories(dirName);
                foreach (string s in dirs)
                {
                    count = GetNumberOfDirs(s);
                }
            }
            Console.WriteLine($"Number Of Folders: {count++}");
            return count;
        }

        public int GetSizeOfDirs(string dirName)
        {
            if (Directory.Exists(dirName))
            {
                string[] dirs = Directory.GetDirectories(dirName);
                foreach (string s in dirs)
                {
                    sum += s.Length;
                }
            }
            Console.WriteLine($"Folders Size: {sum}");
            return sum;
        }
    }
}
