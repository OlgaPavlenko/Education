using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mammal_Polimorphism
{
    class Mammal
    {
        private int age;
        private int weight;

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }

        public int Weight
        {
            get
            {
                return weight;
            }
            set
            {
                weight = value;
            }
        }

        public Mammal(int age)
        {
            weight = 1;
            this.Age = age;
        }

        public virtual void Eat(int foodAmount)
        {
            if (Age < 12)
            {
                Console.WriteLine("Mammal eating milk");
            }

            else
            {
                Console.WriteLine("Mammal eating other food");
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
