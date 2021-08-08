using System;
using Xunit;
using IOLib;

namespace IOLib.Tests
{
    public class PrintOnConsoleUnitTests
    {
        [Fact]
        public void Print_StringGiven_PrintsStringOnConsole()
        {
            //Was not able to understand how to I check the console read.
            //Tested through Mock
            //Thought of asserting on somthing like -
            //  convert.ToString(console.out == outputString)

            //Arrange
            PrintOnConsoleMock printOnConsoleMock = new();
            string ouputString = "adfsgdh";
            int expected = 1;
            //Assert
            printOnConsoleMock.Print(ouputString);
            //Action
            Assert.True(printOnConsoleMock.timesPrintCalled == expected);
        }
    }
}
