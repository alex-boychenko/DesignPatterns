﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator
{
    public interface IIterator
    {
        bool HasNext();

        string Current();

        void Next();
    }
}
