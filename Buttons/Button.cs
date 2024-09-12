using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Buttons
{
    abstract internal class Button
    {
        public abstract bool IsPressed { get; set; }
        public abstract void PressButton();
    }
}
