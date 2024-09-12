using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Algorithm
{
    internal class FIFO : IElevatorAlgorithm
    {
        public void Process(Queue<Request> Requests)
        {
            while (Requests.Count > 0)
            {
                Request request = Requests.Dequeue();
                ElevatorSystem.GetInstance().CallElavator(request.DstFloor);
            }
        }
    }
}
