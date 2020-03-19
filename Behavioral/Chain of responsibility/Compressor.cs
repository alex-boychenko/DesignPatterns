using System;
using System.Collections.Generic;
using System.Text;

namespace Chain_of_responsibility
{
    public class Compressor : Handler
    {
        public Compressor(Handler handler) : base(handler)
        {
        }

        public override bool DoHandle(HttpRequest httpRequest)
        {
            Console.WriteLine("compres");

            return false;
        }
    }
}
