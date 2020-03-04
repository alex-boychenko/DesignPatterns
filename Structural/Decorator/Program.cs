using Decorator;
using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            IStream stream = new EncryptedStream(new CompressedStream(new Stream()));
            stream.Write("stream");

            Console.ReadKey();
        }
    }
}
