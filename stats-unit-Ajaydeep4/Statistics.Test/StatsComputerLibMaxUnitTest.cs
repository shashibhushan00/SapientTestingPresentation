using System;
using Xunit;
using StatisticsLib;
using AlertsLib;

using System.Collections.Generic;
namespace StatisticsLib.Test
{
    public class StatsComputerLibMaxUnitTest
    {
        [Fact]
        public void ReportsMax()
        {
            var statsComputer = new StatsComputer();
            var max = statsComputer.GetMax(
                new List<double> { 1.5, 8.9, 3.2, 4.5 });
            float epsilon = 0.001F;
            Assert.True(Math.Abs(max - 8.9) <= epsilon);
        }
        [Fact]
        public void ReportsNaNForEmptyInput()
        {
            var statsComputer = new StatsComputer();
            var max = statsComputer.GetMax(
                new List<double> { });
            Assert.True(Double.NaN.Equals(max));
        }
        [Fact]
        public void ReportsNaNIfInputContainsNaN()
        {
            var statsComputer = new StatsComputer();
            var max = statsComputer.GetMax(
                new List<double> { 1.5, 8.9, double.NaN, 4.5 });
            Assert.True(Double.NaN.Equals(max));
        }

    }

}
