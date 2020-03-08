using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy
{
    public class RealEbook : IEbook
    {
        private readonly string _fileName;
        public RealEbook(string fileName)
        {
            _fileName = fileName;
            Load();
        }
        private void Load()
        {
            Console.WriteLine($"Loading the ebook {_fileName}");
        }

        public void Show()
        {
            Console.WriteLine($"Showing the ebook {_fileName}");
        }

        public string GetFileName()
        {
            return _fileName;
        }
    }
}
