using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPongCustom
{
    class Ping
    {
        public event PingPongDelegate NewPing;

        protected virtual void OnNewPing(PingPongEventArgs e)
        {
            this.NewPing?.Invoke(e);
        }

        public void MadePing()
        {
            Console.WriteLine("I Made ping");
            System.Threading.Thread.Sleep(1000);
            this.OnNewPing(new PingPongEventArgs(DateTime.Now));
        }
    }
}
