using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure_11_05_19
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure figure = new Circle(2, 3, 15);
            Figure figure1 = new Circle(1, 4, 12);
            Figure figure2 = new Circle(3, 4, 18);
            Figure figure3 = new Square(2, 3, 15);
            Figure figure4 = new Square(1, 4, 12);
            Figure figure5 = new Square(3, 4, 18);
            Figure figure6 = new Triangle(2, 3, 15, 5);
            Figure figure7 = new Triangle(1, 4, 12, 2);
            Figure figure8 = new Triangle(3, 4, 18, 3);
            Figure figure9 = new Triangle(3, 4, 25, 4);
            Figure[] figures = new Figure[] { figure, figure1, figure2, figure3, figure4, figure5, figure6, figure7, figure8, figure9 };

            foreach (var item in figures)
            {
                if (item is Circle)
                {
                    Circle circle = (Circle)item;
                    circle.Draw();
                }

                if (item is Square square)
                {
                    square.Draw();
                }

                if (item is Triangle triangle)
                {
                    triangle = item as Triangle;
                    triangle.Draw();
                }
            }
        }
    }
}
