using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISwitchable
{
    class Lamp : ISwitchable
    {
        private bool state;

        public void On()
        {
            this.state = true;
            Console.WriteLine("The lamp is terning ON!");
        }

        public void Off()
        {
            this.state = false;
            Console.WriteLine("The lamp is terning OFF!");
        }

        public override string ToString()
        {
            if (this.state == true)
            {
                return $"Lamp is On";
            }
            else
            {
                return $"Lamp is Off";
            }
        }
    }
}
