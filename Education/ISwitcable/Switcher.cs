using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISwitchable
{
    class Switcher
    {
        public void Execute()
        {
            Lamp lamp = new Lamp();
            Tv tv = new Tv();

            Console.WriteLine("If you want to tern On - enter 1, If you want to tern Off");
            string choise = Console.ReadLine();
            if (choise == "1" || choise == "2")
            {
                switch (choise)
                {
                    case "1":
                        lamp.On();
                        tv.On();
                        break;
                    case "2":
                        lamp.Off();
                        tv.Off();
                        break;
                    default:
                        lamp.Off();
                        tv.Off();
                        break;
                }
            }
            else
            {
                Console.WriteLine("You shoud do correct choise!!");
            }
        }
    }
}
