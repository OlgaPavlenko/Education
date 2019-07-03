using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyList
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> list = new MyList<int>();
            list.Add(5);
            list.Add(10);
            list.Add(8);
            list.Add(3);
            list.Add(2);
            list.Add(0);
            list.Contains(8);
            Console.WriteLine(list);
            list.Clear();
        }
    }
}
