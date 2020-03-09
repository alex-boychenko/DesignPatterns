using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    public class Chart : IObserver
    {
        public void Update()
        {
            Console.WriteLine("Chart got updated");
        }
    }
}
