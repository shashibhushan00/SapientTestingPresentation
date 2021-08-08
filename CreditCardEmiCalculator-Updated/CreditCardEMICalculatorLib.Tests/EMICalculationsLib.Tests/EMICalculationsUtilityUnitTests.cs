using System;
using Xunit;
using EMILib;

namespace EMICalculationsLib.Tests
{
    public class EMICalculationsUtilityUnitTests
    {
        [Fact]
        public void EMIAmout_PrincipleAmtTenureAndInterestRateGiven_ReturnsMonthlyEMIAmount()
        {
            //Arrange
            double principle = 1000;
            int tenure = 12;
            double interestRate = 12;
            double epsilon = 0.001;
            
            //Act
            double actualValue = EMICalculationsUtility.EMIAmout(principle, tenure, interestRate);
            
            //Assert
            Assert.True(Math.Abs(actualValue - 88.8487) < epsilon);
        }
    }
}
