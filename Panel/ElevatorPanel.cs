using ConsoleApp2.Buttons;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Panel
{
    internal class ElevatorPanel
    {
        private Dictionary<int,ElevatorButton> Buttons = new();
        private ElevatorButton OPEN = new ElevatorButton();
        private ElevatorButton CLOSE = new ElevatorButton();
        public ElevatorPanel(int supportFloors)
        {
            for (int i = 0; i < supportFloors; i++)
            {
                Buttons.Add(i + 1, new ElevatorButton());
            }
        }

    }
}
