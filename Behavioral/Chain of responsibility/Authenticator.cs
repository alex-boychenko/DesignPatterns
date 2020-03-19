using System;
using System.Collections.Generic;
using System.Text;

namespace Chain_of_responsibility
{
    public class Authenticator : Handler
    {
        public Authenticator(Handler handler) : base(handler)
        {
        }

        public override bool DoHandle(HttpRequest httpRequest)
        {
            var isValid = httpRequest.UserName == "admin" && httpRequest.Password == "123";

            Console.WriteLine("authentication");

            return !isValid;
        }
    }
}
