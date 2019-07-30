using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Hunter
{
    public delegate void HuntingDelegate(object sender, HuntingEventArgs e);

    public static class Manager
    {
        public static void Execute()
        {
            Rabbit rabbit = new Rabbit();
            Hunter hunter = new Hunter();

            rabbit.RabbitEvent += hunter.Say;

            for (int i = 0; i < 10; i++)
            {
                rabbit.DoJump();
                System.Threading.Thread.Sleep(3000);
            }
        }
    }
}
