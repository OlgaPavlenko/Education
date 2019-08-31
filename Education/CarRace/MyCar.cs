using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRace
{
    public class MyCar
    {
        public MyCar(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public int X { get; set; }
        public int Y { get; set; }

        public void DrawMyCar(int x, int y)
        {
            X = x;
            Y = y;

            lock (Program.myLocker)
            {
                Console.SetCursorPosition(x, y - 4);
                Console.Write("  ^^^");
                Console.SetCursorPosition(x, y - 3);
                Console.Write("{>| |<}");
                Console.SetCursorPosition(x, y - 2);
                Console.Write("  | |");
                Console.SetCursorPosition(x, y - 1);
                Console.Write("{>| |<}");
            }
        }

        public void MakeMyCarInvisible(int x, int y)
        {
            lock (Program.myLocker)
            {
                Console.SetCursorPosition(x, y - 4);
                Console.WriteLine("      ");
                Console.SetCursorPosition(x, y - 3);
                Console.WriteLine("       ");
                Console.SetCursorPosition(x, y - 2);
                Console.WriteLine("      ");
                Console.SetCursorPosition(x, y - 1);
                Console.WriteLine("       ");
            }
        }
    }
}
