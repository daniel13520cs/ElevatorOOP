using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Algorithm
{
    internal interface IElevatorAlgorithm
    {
        void Process(Queue<Request> Requests);
    }
}
