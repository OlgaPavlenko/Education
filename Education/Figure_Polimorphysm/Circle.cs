using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure_Polimorphysm
{
    class Circle : Figure
    {
        private double radius;

        public double Radius
        {
            get
            {
                return radius;
            }

            set
            {
                if (value > 0)
                {
                    radius = value;
                }
            }
        }

        public void Draw()
        {
            Console.WriteLine($"Drawed circle with radius: {radius}");
        }

        public Circle(int X, int Y, double radius)
            : base(X, Y)
        {
            this.Radius = radius;
        }
    }
}
