using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Matrix
{
    class Program
    {
        public static Object objLocker = new object();

        static void Main(string[] args)
        {
            // verticalSymbolClass.DownSymbolAsync();
            //Console.ReadKey();
            Console.CursorVisible = false;
            Console.SetBufferSize(120, 30);
            Console.SetWindowSize(120, 30);

            for (int i = 0; i < 120; i += 5)
            {
                VerticalSymbolClass verticalSymbolClass = new VerticalSymbolClass(i);
                Thread t = new Thread(verticalSymbolClass.DownSymbol);
                t.Start();
            }
            Thread.Sleep(3000);
            for (int i = 0; i < 120; i += 5)
            {
                VerticalSymbolClass verticalSymbolClass = new VerticalSymbolClass(i);
                Thread t = new Thread(verticalSymbolClass.DownSymbol);
                t.Start();
            }

            //for (int i = 0; i < 110; i += 5)
            //{
            //    VerticalSymbolClass verticalSymbolClass = new VerticalSymbolClass(i);
            //    Task task = new Task(verticalSymbolClass.DownSymbolAsync);
            //    task.Start();
            //   //await task;
            //}
        }
    }
}
