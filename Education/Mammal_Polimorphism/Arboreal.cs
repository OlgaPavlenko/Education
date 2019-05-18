using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mammal_Polimorphism
{
    class Arboreal : Mammal
    {
        public Arboreal(int age)
            : base(age)
        {

        }

        public override void Eat(int foodAmount)
        {
            if (Age < 12)
            {
                Console.WriteLine("Arboreal eating milk");
            }

            else
            {
                Console.WriteLine("Arboreal eating other food");
            }

            for (int i = 1; i < foodAmount; i++)
            {
                if (i % 5 == 0)
                {
                    this.Weight = Weight + 5;
                }
            }

            Console.WriteLine($"Weight is: {Weight}");
        }
    }
}
