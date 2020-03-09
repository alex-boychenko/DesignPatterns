using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var storage = new ImageStorage();

            storage.Store("picture.jpeg", new JpegCompressor());
            storage.Store("picture.png", new PngCompressor());

            Console.ReadKey();
        }
    }
}
