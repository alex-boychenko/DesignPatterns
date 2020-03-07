using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class ThirdPartyFilter
    {
        public void Filter()
        {
            Console.WriteLine("A third party filter is applying!");
        }
    }
}
