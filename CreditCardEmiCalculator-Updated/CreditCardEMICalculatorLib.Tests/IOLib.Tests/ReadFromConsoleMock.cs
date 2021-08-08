using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IOLib;
namespace IOLib.Tests
{
    class ReadFromConsoleMock : ITakeIput
    {
        public int timesReadFromConsoleCalled = 0;
        public string Read()
        {
            timesReadFromConsoleCalled++;
            return "read";
        }
    }
}
