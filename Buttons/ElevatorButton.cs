using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Buttons
{
    internal class ElevatorButton : Button
    {
        public override bool IsPressed { get; set; } = false;
        private int DestinationFloor { get; set; }
        private int ElevatorID { get; set; }
        public ElevatorButton(int ElevatorID, int DestinationFloor) {
            this.ElevatorID = ElevatorID;
            this.DestinationFloor = DestinationFloor;
        }
        public ElevatorButton(int ElevatorID)
        {
            this.ElevatorID = ElevatorID;
        }

        public override void PressButton()
        {
            IsPressed = true;
            ElevatorSystem.GetInstance().CallElavator(this.ElevatorID, DestinationFloor);
            UnPressButton();
        }
        public void PressButton(Passenger passenger, int dstFloor)
        {
            IsPressed = true;
            ElevatorSystem.GetInstance().Dispatcher(new Request(passenger, dstFloor));
        }
        public void UnPressButton()
        {
            IsPressed = !IsPressed;
        }
        
    }
}
