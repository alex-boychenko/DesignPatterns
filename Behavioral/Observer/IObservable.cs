using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    interface IObservable
    {
        void AddObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
        void NotifyObservers();
    }
}
