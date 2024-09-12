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
        public Passenger Passenger {  get; set; }
        public int DstFloor {  get; set; }
        public Request(Passenger Passenger, int dstFloor)
        {
            this.Passenger = Passenger;
            this.DstFloor = dstFloor;
        }
    }
}
