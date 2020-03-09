using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    public class SpreadSheet : IObserver
    {
        public void Update()
        {
            Console.WriteLine("SpreadSheet got notified");
        }
    }
}
