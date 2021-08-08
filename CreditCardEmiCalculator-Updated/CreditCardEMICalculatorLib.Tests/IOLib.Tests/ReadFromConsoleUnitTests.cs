using System;
using Xunit;
using IOLib;

namespace IOLib.Tests
{
    public class ReadFromConsoleUnitTests
    {
        [Fact]
        public void Read_VoidGiven_ReturnStringReadFromConsole()
        {
            //Arrange
            ReadFromConsoleMock readFromConsoleMock = new ReadFromConsoleMock();
            string expectedString = "read";
            int expectedTimesCalled = 0;
            //Act
            string actualString = readFromConsoleMock.Read();
            expectedTimesCalled++;
            //Assert
            Assert.Equal(actualString, expectedString);
            Assert.Equal(readFromConsoleMock.timesReadFromConsoleCalled, expectedTimesCalled);
        }
    }
}
