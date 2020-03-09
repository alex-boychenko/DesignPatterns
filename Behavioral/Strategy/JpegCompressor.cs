using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class JpegCompressor : ICompressor
    {
        public void Compress(string fileName)
        {
            Console.WriteLine($"JpegCompressor: Compress({fileName})");
        }
    }
}
