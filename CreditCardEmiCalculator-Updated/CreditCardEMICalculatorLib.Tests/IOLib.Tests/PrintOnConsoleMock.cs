using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IOLib;

namespace IOLib.Tests
{
    class PrintOnConsoleMock : IPrint
    {
        public int timesPrintCalled = 0;
        public void Print(string s)
        {
            timesPrintCalled++;
        }
    }
}
