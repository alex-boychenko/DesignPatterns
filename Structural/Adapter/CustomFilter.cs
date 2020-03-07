using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class CustomFilter : IFilter
    {
        public void Apply()
        {
            Console.WriteLine("A custom filter is applying!");
        }
    }
}
