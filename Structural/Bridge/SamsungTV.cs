using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    class SamsungTV : IDevice
    {
        public void SetChannel(int number)
        {
            Console.WriteLine("SamsungTV: SetChannel");
        }

        public void TurnOff()
        {
            Console.WriteLine("SamsungTV: TurnOff");
        }

        public void TurnOn()
        {
            Console.WriteLine("SamsungTV: TurnOn");
        }
    }
}
