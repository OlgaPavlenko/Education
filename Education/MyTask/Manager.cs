using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTask
{
    public delegate void RefrigeratorDelegate(object sender, FridgeEventArgs e);

    public static class Manager
    {
        public static void Execute()
        {
            Refrigerator refrigerator = new Refrigerator();

            refrigerator.FrigeEvent += DoSomeChanges;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(refrigerator.ToString());
                refrigerator.ChangeFridgePowerState();
                //refrigerator.ChangeUpperDoorState();
                //refrigerator.ChangeLowerDoorState();
                System.Threading.Thread.Sleep(5000);
            }
        }

        public static void DoSomeChanges(object sender, FridgeEventArgs e)
        {
            Console.WriteLine($"Sender: {sender.GetType().Name}, Power: {e.FridgePowerState}, Upper Door: {e.UpperDoor}, Lower Door: {e.LowerDoor}");
        }
    }
}
