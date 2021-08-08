using System;

namespace IOLib
{
    public class ReadFromConsole : ITakeIput
    {
        public string Read()
        {
            return Console.ReadLine();
        }
    }
}
