using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Matrix
{
    class VerticalSymbolClass
    {
        public VerticalSymbolClass(int x)
        {
            this.X = x;
        }

        public int X { get; set; }

        public void DownSymbol()
        {
            int j = new Random().Next(1, 8);

            for (int i = 0; i < 50; i++)
            {
                //symbol at current position
                lock (Program.objLocker)
                {
                    if (i >= 0 && i < 30)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.SetCursorPosition(this.X, i);
                        Console.Write((char)(new Random().Next(33, 127)));
                    }
                    //paint second position
                    if (i > 0)
                    {
                        int temp = i - 1;
                        if (temp >= 0 && temp < 30)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.SetCursorPosition(this.X, temp);
                            Console.Write((char)(new Random().Next(33, 127)));
                        }
                    }
                    //paint third position
                    if (i > 1)
                    {
                        int temp = i - 2;
                        if (temp >= 0 && temp < 30)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.SetCursorPosition(this.X, temp);
                            Console.Write((char)(new Random().Next(33, 127)));
                        }
                    }
                    //erase the tail
                    if (i > j)
                    {
                        int temp = i - (j + 1);
                        if (temp >= 0 && temp < 30)
                        {
                            Console.SetCursorPosition(this.X, temp);
                            Console.Write(' ');
                        }
                    }
                }

                Thread.Sleep(200);

                if (i == 30 + j)
                {
                    i = -1;
                    j = new Random().Next(2, 9);
                    continue;
                }
            }
        }

        public async void DownSymbolAsync()
        {
            Task task = new Task(DownSymbol);
            task.Start();
            await task;
        }
    }
}