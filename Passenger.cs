﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Passenger
    {
        private string Name {  get; set; }
        public int ID { get; set; }
        public Passenger(int ID, string name) {
            this.ID = ID;
            this.Name = name;
        }
        public void PressButton(int floor, Direction dir)
        {
            if (dir == Direction.UP)
            {
                ElevatorSystem.Building.floors[floor].HallPanel.UP.PressButton();
            } else if (dir == Direction.DOWN)
            {
                ElevatorSystem.Building.floors[floor].HallPanel.DOWN.PressButton();
            }
        }

    }
}
