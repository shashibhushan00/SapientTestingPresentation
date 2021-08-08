using System;
using System.Collections.Generic;
using Xunit;
using AlertsLib;
namespace StatisticsLib.Test
{
    public class StatisticsAlertUnitTests
    {
        [Fact]
        public void RaisesAlertsIfMaxIsMoreThanThreshold()
        {
            var emailAlert = new EmailAlert();
            var ledAlert = new LEDAlert();
            IAlerter[] alerters = { emailAlert, ledAlert };
            List<IAlerter> alertersList = new List<IAlerter>(alerters);
            const double maxThreshold = 10.2;
            var statsAlerter = new StatsAlerter(maxThreshold, alertersList);
            statsAlerter.CheckAndAlert(new List<double> { 0.2, 11.9, 4.3, 8.5 });

            Assert.True(emailAlert.emailSent);
            Assert.True(ledAlert.ledGlows);
        }
    }

}
