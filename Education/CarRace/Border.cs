using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CarRace
{
    public class Border
    {
        private int k = 0;

        public Border(int x1, int x2)
        {
            this.X1 = x1;
            this.X2 = x2;
        }

        public int X1 { get; set; }
        public int X2 { get; set; }

        public void DownBorderOneStep()
        {
            for (int i = 0; i < 30; i++)
            {
                if (k < 3)
                {
                    lock (Program.myLocker)
                    {
                        Console.SetCursorPosition(this.X1, i);
                        Console.Write("||");
                        Console.SetCursorPosition(this.X2, i);
                        Console.Write("||");
                        k++;
                    }
                }

                else
                {
                    lock (Program.myLocker)
                    {
                        Console.SetCursorPosition(this.X1, i);
                        Console.Write("  ");
                        Console.SetCursorPosition(this.X2, i);
                        Console.Write("  ");
                        k = 0;
                    }
                }
            }
            k++;
        }

        public void Separator()
        {
            for (int i = 0; i < 30; i++)
            {
                lock (Program.myLocker)
                {
                    Console.SetCursorPosition(28, i);
                    Console.Write("¦");
                }
            }
        }
    }
}

