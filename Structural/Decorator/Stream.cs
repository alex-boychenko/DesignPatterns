using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class Stream : IStream
    {
        public void Write(string data)
        {
            Console.WriteLine(data);
        }
    }
}
