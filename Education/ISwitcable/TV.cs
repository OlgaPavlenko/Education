using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISwitchable
{
    class Tv : ISwitchable
    {
        private bool state;

        public void On()
        {
            this.state = true;
            Console.WriteLine("TV is terning ON!");
        }

        public void Off()
        {
            this.state = false;
            Console.WriteLine("TV is terning OFF!");
        }

        public override string ToString()
        {
            if (this.state == true)
            {
                return $"TV is On";
            }
            else
            {
                return $"TV is Off";
            }
        }
    }
}
