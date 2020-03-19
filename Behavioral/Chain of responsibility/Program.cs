using System;

namespace Chain_of_responsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            //authenticator -> logger -> compressor

            var compressor = new Compressor(null);
            var logger = new Logger(compressor);
            var authenticator = new Authenticator(logger);

            var webServer = new WebServer(authenticator);
            webServer.Handle(new HttpRequest { UserName = "admin", Password = "123"});


            Console.ReadKey();
        }
    }
}
