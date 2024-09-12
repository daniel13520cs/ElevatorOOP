using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Buttons
{
    internal class HallButton : Button
    {
        public int CurFloor { get; set; }
        public override bool IsPressed { get; set; } = false;
        private Direction Sign { get; set; }
        public HallButton(Direction dir, int floor) {
            Sign = dir;
            CurFloor = floor;
        }
        public override void PressButton()
        {
            IsPressed = true;
            ElevatorSystem.GetInstance().CallElavator(CurFloor);
            UnPressButton();
        }
        public void PressButton(Passenger passenger, int curFloor)
        {
            IsPressed = true;
            ElevatorSystem.GetInstance().Dispatcher(new Request(passenger, curFloor));
        }
        public void UnPressButton()
        {
            IsPressed = !IsPressed;
        }
    }
}
