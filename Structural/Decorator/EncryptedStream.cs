using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class EncryptedStream : IStream
    {
        private readonly IStream _stream;
        public EncryptedStream(IStream stream)
        {
            _stream = stream;
        }
        public void Write(string data)
        {
            _stream.Write(Encrypt(data));
        }

        private string Encrypt(string data)
        {
            return data + " encrypted";
        }
    }
}
