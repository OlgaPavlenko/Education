using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Path
{
    class Program
    {
        static void Main(string[] args)
        {
            FileCreator create = new FileCreator();
            create.writeText();
        }
    }

    class FileCreator
    {
        string path = "C:\\Temp\\";
        string fileName = "userText.txt";

        public string fileCreator()
        {
            string fullPath = path + fileName;
            FileInfo fi = new FileInfo(fullPath);
            return fi.FullName;
        }

        public void writeText()
        {
            File.WriteAllText(fileCreator(), textAdd());
        }

        public string textAdd()
        {
            Console.WriteLine("Enter your text:");
            string text = Console.ReadLine();
            return text;
        }
    }
}
