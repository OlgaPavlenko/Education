using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mammal_Polimorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Terrestrial terrestrialLittle = new Terrestrial(6);
            Terrestrial terrestrialBig = new Terrestrial(16);
            Subterranean subterraneanLittle = new Subterranean(8);
            Subterranean subterraneanBig = new Subterranean(25);
            Aquatic aquaticlittle = new Aquatic(3);
            Aquatic aquaticBig = new Aquatic(22);
            Arboreal arborealLittle = new Arboreal(10);
            Arboreal arborealBig = new Arboreal(27);
            Arial arialLittle = new Arial(11);
            Arial arialBig = new Arial(44);
            Mammal[] mammals = new Mammal[] { terrestrialLittle, terrestrialBig, subterraneanLittle, subterraneanBig, aquaticlittle, aquaticBig, arborealLittle, arborealBig, arialLittle, arialBig };
            Feeder feeder = new Feeder();
            feeder.Feed(mammals);
        }
    }
}
