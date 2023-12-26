using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab_6
{
    public interface IObservable
    {
        void AddObserver (IObserver observer);
        void RemoveObserver(IObserver observer);
        void NotifyObservers();
    }
}