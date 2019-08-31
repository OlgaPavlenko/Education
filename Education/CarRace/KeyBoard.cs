using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRace
{
    public class KeyBoard
    {
        public void ReadMoveMyCar()
        {
            while (true)
            {
                var selection = Console.ReadKey(true).Key;
                string selString = Convert.ToString(selection);
                //Console.Write(selection);
                switch (selString)
                {
                    case "LeftArrow":
                        Creator.myCar.MakeMyCarInvisible(15, 29);
                        Creator.myCar.DrawMyCar(4, 29);
                        break;

                    case "RightArrow":
                        Creator.myCar.MakeMyCarInvisible(4, 29);
                        Creator.myCar.DrawMyCar(15, 29);
                        break;

                    default:

                        break;
                }
            }
        }
    }
}