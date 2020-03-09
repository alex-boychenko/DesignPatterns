using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    public class DataSource : IObservable
    {
        private List<IObserver> _observers = new List<IObserver>();

        private int _value;

        public int Value
        {
            set
            {
                _value = value;
                NotifyObservers();
            }
        }

        public void AddObserver(IObserver observer)
        {
            _observers.Add(observer);
        }
        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }
        public void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.Update();
            }
        }
    }
}
