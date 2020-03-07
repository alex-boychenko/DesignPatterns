using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class ContentMonitor
    {
        public void Monitor(IFilter filter)
        {
            filter.Apply();
        }
    }
}
