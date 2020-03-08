using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    public class SonyTV : IDevice
    {
        public void SetChannel(int number)
        {
            Console.WriteLine("SonyTV: SetChannel");
        }

        public void TurnOff()
        {
            Console.WriteLine("SonyTV: TurnOff");
        }

        public void TurnOn()
        {
            Console.WriteLine("SonyTV: TurnOn");
        }
    }
}
