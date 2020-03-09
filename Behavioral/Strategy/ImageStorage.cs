using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class ImageStorage
    {

        public void Store(string fileName, ICompressor compressor)
        {
            compressor.Compress(fileName);
        }
    }
}
