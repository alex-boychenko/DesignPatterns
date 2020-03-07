using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    public class NotificationService
    {

        public void Send(string message, string target)
        {
            var server = new NotificationServer();

            var connection = server.Connect("ipAddress");
            var authToken = server.Authenticate("appId", "key");

            server.Send(authToken, message, target);

            connection.Disconnect();
        }
    }
}
