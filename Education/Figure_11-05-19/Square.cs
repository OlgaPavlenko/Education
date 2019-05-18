using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure_11_05_19
{
    public class Square : Figure
    {
        private int sideLength;

        public int SideLength
        {
            get
            {
                return sideLength;
            }

            set
            {
                if (value > 0)
                {
                    sideLength = value;
                }
            }
        }

        public void Draw()
        {
            Console.WriteLine($"Drawed square with sideLength: {sideLength}");
        }

        public Square (int X, int Y, int sideLength)
            :base(X, Y)
        {
            this.SideLength = sideLength;
        }
    }
}
