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
        public Dictionary<int,ElevatorButton> Buttons = new();
        private ElevatorButton OPEN;
        private ElevatorButton CLOSE;
        public int ElevatorID { get; set; }
        public ElevatorPanel(int ElevatorID, int supportFloors)
        {
            this.ElevatorID = ElevatorID;
            for (int i = 0; i < supportFloors; i++)
            {
                Buttons.Add(i + 1, new ElevatorButton(this.ElevatorID, i+1));
            }
            OPEN = new ElevatorButton(this.ElevatorID);
            CLOSE = new ElevatorButton(this.ElevatorID);
        }

    }
}
