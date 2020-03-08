using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy
{
    class ProxyEbook : IEbook
    {
        private readonly string _fileName;

        private IEbook _realEbook;
        public ProxyEbook(string fileName)
        {
            _fileName = fileName;
        }

        public string GetFileName()
        {
            return _fileName;
        }

        public void Show()
        {
            if (_realEbook == null)
                _realEbook = new RealEbook(_fileName);

            _realEbook.Show();
        }
    }
}
