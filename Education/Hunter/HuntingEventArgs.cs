﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hunter
{
    public class HuntingEventArgs : EventArgs
    {
        public int X { get; private set; }
        public int Y { get; private set; } 

        public HuntingEventArgs(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
    }
}
