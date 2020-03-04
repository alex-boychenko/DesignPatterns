using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class CompressedStream : IStream
    {
        private readonly IStream _stream;
        public CompressedStream(IStream stream)
        {
            _stream = stream;
        }
        public void Write(string data)
        {
            _stream.Write(Compress(data));
        }

        private string Compress(string data)
        {
            return data + " compressed";
        }
    }
}
