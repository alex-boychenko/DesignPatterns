using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator
{
    public class BrowseHistory
    {
        public List<string> Urls = new List<string>();

        public void Push(string url)
        {
            Urls.Add(url);
        }

        public void Pop()
        {
            var lastIndex = Urls.Count - 1;

            Urls.RemoveAt(lastIndex);
        }

        public IIterator CreateIterator()
        {
            return new ListIterator(this);
        }
    }
}
