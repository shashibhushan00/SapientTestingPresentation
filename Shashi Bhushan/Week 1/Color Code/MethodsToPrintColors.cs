using System;
using System.Collections.Generic;
using System.Text;

namespace TelCo.ColorCoder
{
    class MethodsToPrintColors
    {
        public class PrintContentOnConsole : IWritable
        {
            public void PrintALine(string line)
            {
                Console.WriteLine(line);
            }
        }
        public class TestContentPrintedOnConsole : IWritable
        {
            public int CountOfContentPrintedOnConsole = 0;
            public void PrintALine(string line)
            {
                CountOfContentPrintedOnConsole++;
            }
        }
    }
}
