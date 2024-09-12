using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Algorithm
{
    internal class LIFO : IElevatorAlgorithm
    {
        public void Process(Queue<Request> Requests)
        {
            Stack<Request> Stack = new Stack<Request>();
            
            while (Requests.Count > 0)
            {
                Request request = Requests.Dequeue();
                Stack.Push(request);
            }
            while (Stack.Count > 0)
            {
                Request request = Stack.Pop();
                ElevatorSystem.GetInstance().CallElavator(request.DstFloor);
            }
        }
    }
}
