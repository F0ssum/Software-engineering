using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab_6
{
    public class ConcreteObservable : IObservable
    {
        private List<IObserver> observers;
        public ConcreteObservable()
        {
            observers = new List<IObserver>();
        }
        public void AddObserver(IObserver observer)
        {
            observers.Add(observer);
        }
        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }
        public void NotifyObservers()
        {
            foreach ( var observer in observers)
            {
                observer.Update();
            }
        }
    }
}