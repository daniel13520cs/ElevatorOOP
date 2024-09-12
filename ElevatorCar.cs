using ConsoleApp2.Panel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

    internal class ElevatorCar
    {

        public int ID {  get; set; }
        public ElevatorState State { get; set; }
        public ElevatorPanel Panel { get; set; } = new ElevatorPanel(15);
        public Door door { get; set; } = new Door();

        public int CurrentFloor { get; set; } = MAX_FLOOR;

        public Display Display { get; set; } = new();


        public int Capacity { get; set; }
        public const int MAX_CAPCITY = 8;
        public const int MAX_FLOOR = 15;
        public const int MIN_FLOOR = 1;

        public ElevatorCar() {
            
        }

        #region method
        public void OpenDoor()
        {
            door.State = DoorState.Open;
        }
        public void CloseDoor()
        {
            door.State = DoorState.Close;
        }
        public void Move(int floor)
        {
            while (this.CurrentFloor != floor)
            {
                Thread.Sleep(1000);
                if (floor > this.CurrentFloor)
                {
                    State = ElevatorState.Up;
                    this.CurrentFloor++;
                } else
                {
                    State = ElevatorState.Down;
                    this.CurrentFloor--;
                }
                Display.ShowElevatorDisplay(this);
                Display.ShowHallwayDisplay(Building.GetInstance(), this);
            }
            OpenDoor();
        }
        public void Stop()
        {
            State = ElevatorState.Idle;
        }
        #endregion
    }
}
