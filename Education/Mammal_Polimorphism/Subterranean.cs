using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mammal_Polimorphism
{
    class Subterranean : Mammal
    {
        public Subterranean(int age)
           : base(age)
        {

        }

        public override void Eat(int foodAmount)
        {
            if (Age < 12)
            {
                Console.WriteLine("Subterranean eating milk");
            }

            else
            {
                Console.WriteLine("Subterranean eating other food");
            }

            for (int i = 1; i < foodAmount; i++)
            {
                if (i % 5 == 0)
                {
                    this.Weight = Weight + 2;
                }
            }

            Console.WriteLine($"Weight is: {Weight}");
        }
    }
}
