using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Display
    {
        private Direction Direction { get; set; }
        public Display() {
        }

        #region method
        public void ShowElevatorDisplay(ElevatorCar car)
        {
            Console.WriteLine("Elevator " + car.ID + " Display : Elevator is currently on " + car.CurrentFloor + "th floor. GOING " + car.State.ToString());
        }
        public void ShowHallwayDisplay(Building building, ElevatorCar car)
        {
            foreach (var floor in building.floors.Values)
            {
                if (floor.ID == car.CurrentFloor)
                {
                    Console.WriteLine(floor.ID + "th Hallway Display : Elevator is currently on " + car.CurrentFloor + "th floor");
                }
            }
        }
        #endregion
    }
}
