using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CarRace
{
    public class EnemyCar
    {
        private int leftPositionX = 4;
        private int rightPositionX = 15;
        private int currentPosX;

        public int X { get; set; }
        public int Y { get; set; }

        public EnemyCar(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void DrawEnemyCar(int x, int y)
        {
            X = x;
            Y = y;

            lock (Program.myLocker)
            {
                if ((y - 3) >= 0 && (y - 3) < 30)
                {
                    Console.SetCursorPosition(x, y - 3);
                    Console.Write("       ");
                }

                if ((y - 2) >= 0 && (y - 2) < 30)
                {
                    Console.SetCursorPosition(x, y - 2);
                    Console.Write("{>| |<}");
                }

                if ((y - 1) >= 0 && (y - 1) < 30)
                {
                    Console.SetCursorPosition(x, y - 1);
                    Console.Write("  | |  ");
                }

                if (y >= 0 && y < 30)
                {
                    Console.SetCursorPosition(x, y);
                    Console.Write("{>| |<}");
                }
            }
        }

        public bool MoveDownOneStep()
        {
            this.DrawEnemyCar(this.currentPosX, this.Y);
            this.Y++;

            if (this.Y > 34)
            {
                RandomStart();
                return true;
            }
            return false;
        }

        public void RandomStart()
        {
            Random r = new Random();
            int p = r.Next(0, 2);

            if (p == 0)
                this.currentPosX = this.leftPositionX;
            else
                this.currentPosX = this.rightPositionX;

            this.Y = 0;
        }
    }
}