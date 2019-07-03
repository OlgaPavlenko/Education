using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    public class CarCollection<T> : MyList<T> where T : ICar, new()
    {
        public void Add(string name, int year)
        {
            T car = new T();

            car.Name = name;
            car.Year = year;

            base.Add(car);
        }

        public bool Contains(string name)
        {

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Name == name)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
