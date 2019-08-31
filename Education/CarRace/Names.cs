using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRace
{
    public static class Names
    {
        public static void DrwNames()
        {
            lock (Program.myLocker)
            {
                Console.SetCursorPosition(35, 2);
                Console.WriteLine($"SCORE: {Creator.score}");

                Console.SetCursorPosition(35, 4);
                Console.WriteLine($"LIVES: {Creator.Lives}");
            }
        }
    }
}
