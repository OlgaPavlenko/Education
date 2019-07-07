using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseJune8AddTxtFile
{
    class Program
    {
        static void Main(string[] args)
        {
            var car1 = new Car<DieselEngine<int>>(new DieselEngine<int>());
            var car2 = new Car<ElectroEngine>(new ElectroEngine());
            var car3 = new Car<BaseEngine<int>>(new BaseEngine<int>());

            car1.Engine.PrintType();
            car2.Engine.PrintType();
            car3.Engine.PrintType();
        }
    }

    public class Car<TEngine> where TEngine: BaseEngine<int>
    {
        public TEngine Engine { get; set; }

        public Car(TEngine engine)
        {
            this.Engine = engine;
        }
    }

    public class DieselEngine: BaseEngine<string>
    {
        public void PrintType()
        {
            Console.WriteLine("Diesel engine");
        }

    }
        public class ElectroEngine : BaseEngine<int>
        {
            public void PrintType()
            {
                Console.WriteLine("Electro engine");
            }
        }
    public class BaseEngine<T>
    {
        public T Id { get; set; }

        public void PrintId()
        {
            Console.WriteLine(Id);
        }
    }

    

    }
