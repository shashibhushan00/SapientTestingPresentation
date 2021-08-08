using System;
using System.Collections.Generic;
using System.Text;

namespace IOLib
{
    public class PrintOnConsole: IPrint
    {
        public void Print(string s)
        {
            Console.WriteLine($"{s}");
        }

    }
}
