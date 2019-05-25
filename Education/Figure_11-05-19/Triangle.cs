using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure_11_05_19
{
    public class Triangle : Figure
    {
        private double height;
        private double baseLength;

        public double Height
        {
            get
            {
                return height;
            }

            set
            {
                if (value > 0)
                {
                    height = value;
                }
            }
        }

        public double BaseLength
        {
            get
            {
                return baseLength;
            }

            set
            {
                if (value > 0)
                {
                    baseLength = value;
                }
            }
        }

        public void Draw()
        {
            Console.WriteLine($"Drawed triangle with height: {height} and baselength: {baseLength}");
        }

        public Triangle(int X, int Y, double height, double baseLength)
            : base(X, Y)
        {
            this.Height = height;
            this.baseLength = baseLength;
        }
    }
}
