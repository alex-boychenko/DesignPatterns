using System;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            var history = new BrowseHistory();

            history.Push("page 1");
            history.Push("page 2");
            history.Push("page 3");

            var iterator = history.CreateIterator();

            while (iterator.HasNext())
            {
                Console.WriteLine(iterator.Current());

                iterator.Next();
            }

            Console.ReadKey();

        }
    }
}
