using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human
{
    class Program
    {
        static void Main(string[] args)
        {
            Ukrainian ukr = new Ukrainian("Вася");
            American amer = new American("Rob");
            ukr.SayHello();
            amer.SayHello();
        }
    }
}
