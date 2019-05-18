using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mammal_Polimorphism
{
    class Terrestrial : Mammal
    {
        public Terrestrial(int age)
            : base(age)
        {
           
        }

        public override void Eat(int foodAmount)
        {
            if (Age < 12)
            {
                Console.WriteLine("Terrestrial eating milk");
            }

            else
            {
                Console.WriteLine("Terrestrial eating other food");
            }

            for (int i = 1; i < foodAmount; i++)
            {
                if (i % 5 == 0)
                {
                    this.Weight++;
                }
            }

            Console.WriteLine($"Weight is: {Weight}");
        }
    }
}
