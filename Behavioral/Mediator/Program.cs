using System;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            var dialog = new ArticlesDialogBox();

            dialog.SimulateUserInteraction();

            Console.ReadKey();
        }
    }
}
