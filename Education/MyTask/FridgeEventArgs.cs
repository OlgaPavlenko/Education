using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTask
{

    public class FridgeEventArgs : EventArgs
    {
        public DoorState UpperDoor { get; private set; }
        public DoorState LowerDoor { get; private set; }
        public PowerState FridgePowerState { get; private set; }

        public FridgeEventArgs(DoorState upperDoor, DoorState lowerDoor, PowerState fridgePowerState)
        {
            this.UpperDoor = upperDoor;
            this.LowerDoor = lowerDoor;
            this.FridgePowerState = fridgePowerState;
        }
    }
}