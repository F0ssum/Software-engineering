using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab_6
{
    public class Programm
    {
        static void Main(string[] args)
        {
            ConcreteObservable observable = new ConcreteObservable();
            ConsoleObserver observer = new ConsoleObserver();
            observable.AddObserver(observer);
            while(true)
            {
                Console.WriteLine("Введите команду");
                string command = Console.ReadLine();
                if (command == "123")
                {
                    observable.NotifyObservers();
                    Console.WriteLine("Вы ввели правильную команду");
                    break;
                }
            }

        }
    }
}