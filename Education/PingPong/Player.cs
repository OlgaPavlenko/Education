using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPong
{
    class Player
    {
        public Ping ping { get; set; }

        public Pong pong { get; set; }

        public Player()
        {
            this.ping = new Ping();
            this.pong = new Pong();

            this.pong.NewPong += this.OnPongInvoke;
            this.ping.NewPing += this.OnPingInvoke;
        }

       public void OnPingInvoke(object sender, EventArgs e)
        {
            this.pong.MadePong();
        }

        public void OnPongInvoke(object sender, EventArgs e)
        {
            this.ping.MadePing();
        }

        public void Play()
        {
            this.ping.MadePing();
        }

    }
}
