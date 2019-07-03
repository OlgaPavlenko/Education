using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    public class Car : ICar
    {
        public string Name { get; set; }
        public int Year { get; set; }
    }
}