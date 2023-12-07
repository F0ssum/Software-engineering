using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab_5
{
    public class PastDateException : Exception
    {
         public PastDateException(string message) : base(message)
        {

        }
    }
}