using System;
using System.Collections.Generic;
using System.Text;

namespace Chain_of_responsibility
{
    public class Logger : Handler
    {
        public Logger(Handler handler) : base(handler)
        {
        }

        public override bool DoHandle(HttpRequest httpRequest)
        {
            Console.WriteLine("log");

            return false;
        }
    }
}
