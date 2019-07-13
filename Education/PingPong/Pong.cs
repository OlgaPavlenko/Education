using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPong
{
    public class Pong
    {
        public event EventHandler NewPong;
        protected virtual void OnNewPong(EventArgs e)
        {
            this.NewPong?.Invoke(this, e);
        }
        public void MadePong()
        {
            Console.WriteLine("I Made pong");
            System.Threading.Thread.Sleep(1000);
            this.OnNewPong(new EventArgs());
        }
    }
}

