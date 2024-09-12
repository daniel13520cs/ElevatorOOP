using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Request
    {
        private Passenger Passenger {  get; set; }
        private Direction Direction { get; set; }
        private int CurFloor {  get; set; }
        private int DstFloor {  get; set; }
        public Request(Passenger Passenger, Direction dir, int dstFloor)
        {
            this.Passenger = Passenger;
            Direction = dir;
            DstFloor = dstFloor;
        }
    }
}
