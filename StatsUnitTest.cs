using System;
using Xunit;
using Statistics;
using System.Collections.Generic;

namespace Statistics.Test
{
    public class StatsUnitTest
    {
        [Fact]
        public void ReportsAverageMinMax()
        {
            var StatisticsComputer = new StatisticsComputer();
            var computedStats = StatisticsComputer.CalculateStatistics(
                new List<double>{1.5, 8.9, 3.2, 4.5});
            double epsilon = 0.001F;
            Assert.True(Math.Abs(computedStats.average - 4.525) <= epsilon);
            Assert.True(Math.Abs(computedStats.max - 8.9) <= epsilon);
            Assert.True(Math.Abs(computedStats.min - 1.5) <= epsilon);
        }
        [Fact]
        public void ReportsNaNForEmptyInput()
        {
            var StatisticsComputer = new StatisticsComputer();
            var computedStats = StatisticsComputer.CalculateStatistics(
                new List<double>{});
            //All fields of computedStats (average, max, min) must be
            //Double.NaN (not-a-number), as described in
            //https://docs.microsoft.com/en-us/dotnet/api/system.double.nan?view=netcore-3.1

	    Assert.True(Double.IsNaN(computedStats.average));
	    Assert.True(Double.IsNaN(computedStats.max));
	    Assert.True(Double.IsNaN(computedStats.min));

		

        }
        [Fact]
        public void RaisesAlertsIfMaxIsMoreThanThreshold()
        {
            var emailAlert = new EmailAlerter();
            var ledAlert = new LedAlerter();
            IAlerter[] alerters = {emailAlert, ledAlert};

            const double maxThreshold = 10.2;
            var statsAlerter = new StatisticsAlerter(maxThreshold, alerters);
            statsAlerter.CheckAndAlert(new List<double>{0.2, 11.9, 4.3, 8.5});
            Assert.True(emailAlert._emailSent);
            Assert.True(ledAlert._ledGlowed);
        }
    }
}
