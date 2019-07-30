using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTask
{
    public class Refrigerator
    {
        private DoorState UpperDoor { get; set; }
        private DoorState LowerDoor { get; set; }
        private PowerState FridgePowerState { get; set; }

        public event RefrigeratorDelegate FrigeEvent;

        public Refrigerator(DoorState upperDoor, DoorState lowerDoor, PowerState fridgePowerState)
        {
            this.UpperDoor = upperDoor;
            this.LowerDoor = lowerDoor;
            this.FridgePowerState = fridgePowerState;
        }

        public Refrigerator()
        {
        }

        public void ChangeUpperDoorState()
        {
            if (UpperDoor == DoorState.Open)
            {
                this.UpperDoor = DoorState.Close;
            }

            else
            {
                this.UpperDoor = DoorState.Open;
            }

            OnChange(this, new FridgeEventArgs(this.UpperDoor, this.LowerDoor, this.FridgePowerState));
        }

        public void ChangeLowerDoorState()
        {
            if (LowerDoor == DoorState.Open)
            {
                this.LowerDoor = DoorState.Close;
            }

            else
            {
                this.LowerDoor = DoorState.Open;
            }

            OnChange(this, new FridgeEventArgs(this.UpperDoor, this.LowerDoor, this.FridgePowerState));
        }

        public void ChangeFridgePowerState()
        {
            if (FridgePowerState == PowerState.On)
            {
                this.FridgePowerState = PowerState.Off;
            }

            else
            {
                this.FridgePowerState = PowerState.On;
            }

            OnChange(this, new FridgeEventArgs(this.UpperDoor, this.LowerDoor, this.FridgePowerState));
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: Power: {this.FridgePowerState}, Upper Door: {this.UpperDoor}, Lower Door: {this.LowerDoor}";
        }

        protected virtual void OnChange(object sender, FridgeEventArgs e)
        {
            this.FrigeEvent?.Invoke(sender, e);
        }
    }
}
