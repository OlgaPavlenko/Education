using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPong
{
    class Ping
    {
        public event EventHandler NewPing;
        protected virtual void OnNewPing(EventArgs e)
        {
            this.NewPing?.Invoke(this, e);
        }
        public void MadePing()
        {
            Console.WriteLine("I Made ping");
            System.Threading.Thread.Sleep(1000);
            this.OnNewPing(new EventArgs());
        }
    }
}
