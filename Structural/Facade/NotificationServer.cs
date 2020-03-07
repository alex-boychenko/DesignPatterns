using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    public class NotificationServer
    {
        public Connection Connect(string ipAddress)
        {
            return new Connection(ipAddress);
        }

        public AuthToken Authenticate(string appId, string key)
        {
            return new AuthToken(appId, key);
        }

        public void Send(AuthToken authToken, string message, string target)
        {
            Console.WriteLine($"{message} was sent to {target}");
        }
    }
}
