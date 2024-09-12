﻿using ConsoleApp2.Buttons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class ElevatorSystem
    {
        public static Building Building { get; set; } = Building.GetInstance();
        private Queue<Request> Requests = new Queue<Request>();

        private static ElevatorSystem system = null;
        private ElevatorSystem()
        {
        }
        public static ElevatorSystem GetInstance()
        {
            if (system == null)
            {
                system = new ElevatorSystem();
            }
            return system;
        }

        #region method
        public void monitoring()
        {
            
        }
        public ElevatorCar SelBestElevatorCar()
        {
            return Building.elevators[0];
        }

        public void Dispatcher(Request request)
        {
            Requests.Enqueue(request);
        }
        public void CallElavator (int floor)
        {
            ElevatorCar car = SelBestElevatorCar();
            car.Move(floor);
        }

        #endregion
    }
}
