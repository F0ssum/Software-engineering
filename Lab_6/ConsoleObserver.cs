using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab_6
{
    public class ConsoleObserver : IObserver
    {
        public void Update()
        {
            Console.WriteLine("Коммнада: 123");
        }
    }
}