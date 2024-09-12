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
        public ElevatorButton() {
        }
        public override void PressButton()
        {
            IsPressed = true;
            ElevatorSystem.GetInstance().CallElavator(DestinationFloor);
            UnPressButton();
        }
        public void UnPressButton()
        {
            IsPressed = !IsPressed;
        }
        
    }
}
