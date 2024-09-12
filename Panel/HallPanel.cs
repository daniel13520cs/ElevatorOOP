using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp2.Buttons;

namespace ConsoleApp2.Panel
{
    internal class HallPanel
    {
        private int Floor {  get; set; }
        public HallButton UP { get; set; }
        public HallButton DOWN { get; set; }
        public HallPanel(int floor) {
            this.Floor = floor;
            UP = new HallButton(Direction.UP, Floor);
            DOWN = new HallButton(Direction.DOWN, Floor);
        }

    }
}
