using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab_6
{
    public class Input
    {
        private readonly IList<IObserver> observers = new List<IObserver>();

        public void AddObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void Notify(string command)
        {
            for (var i = 0; i < observers.Count; i++)
            {
                observers[i].OnInput(command);
            }
        }
    }

    public interface IObserver
    {
        void OnInput(string command);
    }

    public class ConsoleObserver : IObserver
    {
        public void OnInput(string command)
        {
            Console.WriteLine("Команда: {0}", command);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var input = new Input();
            input.AddObserver(new ConsoleObserver());

            input.Notify("exit");
        }
    }
}
