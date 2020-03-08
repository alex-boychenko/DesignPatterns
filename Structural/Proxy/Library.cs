using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy
{
    public class Library
    {
        private Dictionary<string, IEbook> Ebooks = new Dictionary<string, IEbook>();

        public void Add(IEbook ebook)
        {
            var fileName = ebook.GetFileName();

            if (!Ebooks.ContainsKey(fileName))
            {
                Ebooks.Add(fileName, ebook);
            }
        }

        public void OpenEbook(string fileName)
        {
            if (!Ebooks.ContainsKey(fileName))
            {
                throw new Exception($"The Ebook {fileName} dosn't exist!");
            }

            var ebook = Ebooks[fileName];

            ebook.Show();
        }
    }
}
