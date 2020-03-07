using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    public class Connection
    {
        private readonly string _ipAddress;

        public Connection(string ipAddress)
        {
            _ipAddress = ipAddress;
            Console.WriteLine("Connected");
        }

        public void Disconnect()
        {
            Console.WriteLine("Disconnected");
        }
    }
}
