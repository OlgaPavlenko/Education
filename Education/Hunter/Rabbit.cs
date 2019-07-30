using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hunter
{
    public class Rabbit
    {
         private int X { get; set; }
         private int Y { get; set; }

        public event HuntingDelegate RabbitEvent;

        protected virtual void OnJump(object sender, HuntingEventArgs e)
        {
            this.RabbitEvent?.Invoke(sender, e);
        }

        public void DoJump()
        {
            Random r = new Random();
            this.X = r.Next(0, 20);
            this.Y = r.Next(30, 50);
            Console.WriteLine("Rabbit moved to new position");
            this.OnJump(this, new HuntingEventArgs(this.X, this.Y));
        }
    }
}
