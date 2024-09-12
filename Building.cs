using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Building
    {
        public Dictionary<int, Floor> floors { get; set; } = new();
        public Dictionary<int, ElevatorCar> elevators { get; set; } = new();

        private static Building building { get; set; }
        private Building(int numFloors, int numElevators) {
            try
            {
                for (int i = 0; i < numFloors; i++)
                {
                    if (!floors.ContainsKey(i + 1))
                    {
                        floors.Add(i + 1, new Floor(i + 1));
                    }
                    //floors[i + 1] = new Floor(i + 1);
                }
                for (int i = 0; i < numElevators; i++)
                {
                    if (!elevators.ContainsKey(i + 1))
                    {
                        elevators.Add(i, new ElevatorCar());
                    }
                    //elevators[i] = new ElevatorCar();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        public static Building GetInstance()
        {
            if (building == null)
            {
                building = new Building(15,1);
            }
            return building;
        }
        
    }
}
