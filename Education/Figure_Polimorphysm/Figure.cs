using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure_Polimorphysm
{
    public class Figure
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Figure(double X, double Y)
        {
            this.X = X;
            this.Y = Y;
        }
    }
}
