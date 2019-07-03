using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    class Program
    {
        static void Main(string[] args)
        {
            CarCollection<Car> carCollection = new CarCollection<Car>();
            carCollection.Add("Ford", 2018);
            carCollection.Add("Volga", 1982);
            carCollection.Add("Niva", 1970);
            carCollection.Contains("Volga");
            Console.WriteLine(carCollection.ToString());
        }
    }
}
