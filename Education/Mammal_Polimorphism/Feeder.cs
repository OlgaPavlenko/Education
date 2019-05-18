using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mammal_Polimorphism
{
    class Feeder
    {
        public void Feed(Mammal[] mammals)
        {
            foreach (var item in mammals)
            {
                Console.WriteLine("Enter food amount:");
                int foodAmount = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(item);
                item.Eat(foodAmount);
            }

        }
    }
}
