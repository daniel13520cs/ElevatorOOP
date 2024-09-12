using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Door
    {
        public DoorState State = DoorState.Close;
        public Door() { }
        public bool IsOpen()
        {
            return State == DoorState.Open;
        }
    }
}
