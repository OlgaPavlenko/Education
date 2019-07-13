using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPongCustom
{
    public class Pong
    {
        public event PingPongDelegate NewPong;
        protected virtual void OnNewPong(PingPongEventArgs e)
        {
            this.NewPong?.Invoke(e);
        }

        public void MadePong()
        {
            Console.WriteLine("I Made pong");
            System.Threading.Thread.Sleep(1000);
            this.OnNewPong(new PingPongEventArgs(DateTime.Now));
        }
    }
}
