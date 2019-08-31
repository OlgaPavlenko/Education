using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CarRace
{
    public class Creator
    {
        public static int Lives = 3;

        public const int Counter = 19;

        public static Border border = new Border(0, 24);

        public static MyCar myCar = new MyCar(4, 29);

        public static KeyBoard key = new KeyBoard();

        public static EnemyCar enemyCarFirst = new EnemyCar(4, 0);

        public static EnemyCar enemyCarSecond = new EnemyCar(4, 0);

        public static int threadSpeed = 70;

        public static int score = 0;

        public static void Execute()
        {
            Console.CursorVisible = false;
            Console.SetWindowSize(50, 30);
            Console.SetBufferSize(50, 30);

            border.Separator();

            var t1 = new Task(key.ReadMoveMyCar);
            t1.Start();

            // draw objects
            myCar.DrawMyCar(4, 29);
            enemyCarFirst.RandomStart();
            Thread.Sleep(200);
            enemyCarSecond.RandomStart();
            Names.DrwNames();

            int counterForSecondCar = 0;
            int borderTimeOut = 0;
            bool isFinished;

            while (true)
            {
                // if in one raw find collisions
                if (((myCar.X == enemyCarFirst.X) && (
                    enemyCarFirst.Y == 26 ||
                    enemyCarFirst.Y == 27 ||
                    enemyCarFirst.Y == 28 ||
                    enemyCarFirst.Y == 29 ||
                    enemyCarFirst.Y - 4 == 26 ||
                    enemyCarFirst.Y - 4 == 27 ||
                    enemyCarFirst.Y - 4 == 28 ||
                    enemyCarFirst.Y - 4 == 29
                    )) || (
                    (myCar.X == enemyCarSecond.X) &&
                    (
                    enemyCarSecond.Y == 26 ||
                    enemyCarSecond.Y == 27 ||
                    enemyCarSecond.Y == 28 ||
                    enemyCarSecond.Y == 29 ||
                    enemyCarSecond.Y - 4 == 26 ||
                    enemyCarSecond.Y - 4 == 27 ||
                    enemyCarSecond.Y - 4 == 28 ||
                    enemyCarSecond.Y - 4 == 29)
                    )
                    )

                {
                    Console.Beep();
                    Thread.Sleep(1000);
                    Creator.DrawCarCrash();
                    myCar.DrawMyCar(4, 29);
                    enemyCarFirst.RandomStart();
                    Thread.Sleep(100);
                    enemyCarSecond.RandomStart();
                    counterForSecondCar = 0;

                    Creator.Lives--;

                    if (Creator.Lives == 0)
                    {
                        Console.Clear();
                        Console.SetCursorPosition(20, 14);
                        Console.Write("GAME OVER");

                        Console.SetCursorPosition(20, 16);
                        Console.Write($"Score: {Creator.score}");
                        Console.SetCursorPosition(0, 29);
                        break;
                    }
                }

                isFinished = enemyCarFirst.MoveDownOneStep();

                counterForSecondCar++;

                if (counterForSecondCar >= Counter)
                {
                    isFinished = enemyCarSecond.MoveDownOneStep();
                }

                if (isFinished == true)
                {
                    score += 10;
                }

                Names.DrwNames();

                if (borderTimeOut == 2)
                {
                    border.DownBorderOneStep();
                    borderTimeOut = 0;
                }

                borderTimeOut++;
                Thread.Sleep(threadSpeed);
            }
        }

        public static void DrawCarCrash()
        {
            lock (Program.myLocker)
            {
                for (int i = 0; i < 30; i++)
                {
                    Console.SetCursorPosition(4, i);
                    Console.Write(new string(' ', 20));
                }
            }
        }
    }
}

