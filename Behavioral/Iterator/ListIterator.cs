using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator
{
    public class ListIterator : IIterator
    {
        private readonly BrowseHistory _history;
        private int _size = 0;
        public ListIterator(BrowseHistory history)
        {
            _history = history;
        }

        public string Current()
        {
            return _history.Urls[_size];
        }

        public bool HasNext()
        {
            return _size < _history.Urls.Count;
        }

        public void Next()
        {
            _size++;
        }
    }
}
