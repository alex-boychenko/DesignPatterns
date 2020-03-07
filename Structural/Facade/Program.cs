using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            var notificationService = new NotificationService();

            notificationService.Send("message", "email");

            Console.ReadKey();
        }
    }
}
