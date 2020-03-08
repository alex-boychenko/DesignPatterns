using System;
using System.Collections.Generic;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            var library = new Library();

            var fileNames = new List<string> { "C#", "You don't know JS" };

            foreach (var fileName in fileNames)
                library.Add(new ProxyEbook(fileName));


            library.OpenEbook("You don't know JS");
            library.OpenEbook("C#");

            Console.ReadKey();
        }
    }
}
