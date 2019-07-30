using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hunter
{
    public class Hunter
    {
        public void Say(object sender, HuntingEventArgs e)
        {
            Console.WriteLine($"I saw the {sender.GetType().Name} at: {e.X}, {e.Y}");
        }
    }
}
