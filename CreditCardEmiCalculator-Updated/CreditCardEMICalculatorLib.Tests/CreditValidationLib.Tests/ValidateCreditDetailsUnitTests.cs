using System;
using Xunit;
using CreditValidationLib;

namespace CreditValidationLib.Tests
{
    public class ValidateCreditDetailsUnitTests
    {
        [Fact]
        public void IsInterestRateValid_NegativeInterestRateGiven_ReturnsFalse()
        {
            //Arrange
            IValidateCreditDetails creditDetails = new ValidateCreditDetails();
            double interestRate = -15.2;
            bool expected = false;
            //Act
            bool actual = creditDetails.IsInterestRateValid(interestRate);
            //Asssert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void IsInterestRateValid_NonNegativeInterestRateGiven_ReturnsTrue()
        {
            //Arrange
            IValidateCreditDetails creditDetails = new ValidateCreditDetails();
            double interestRate = 13.2;
            bool expected = true;
            //Act
            bool actual = creditDetails.IsInterestRateValid(interestRate);
            //Asssert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void IsTenureValid_NegativeTenureGiven_ReturnsFalse()
        {
            //Arrange
            IValidateCreditDetails creditDetails = new ValidateCreditDetails();
            int tenure = -1 * new Random().Next(100);
            bool expected = false;
            //Act
            bool actual = creditDetails.IsTenureValid(tenure);
            //Asssert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void IsTenureValid_NonNegativeTenureGiven_ReturnsTrue()
        {
            //Arrange
            IValidateCreditDetails creditDetails = new ValidateCreditDetails();
            int tenure = new Random().Next(1000);
            bool expected = true;
            //Act
            bool actual = creditDetails.IsTenureValid(tenure);
            //Asssert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void IsTransactionAmtValid_NegativeTransactionAmtGiven_ReturnsFalse()
        {
            //Arrange
            IValidateCreditDetails creditDetails = new ValidateCreditDetails();
            double transactionAmt = -100.25;
            bool expected = false;
            //Act
            bool actual = creditDetails.IsTransactionAmtValid(transactionAmt);
            //Asssert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void IsTransactionAmtValid_NonNegativeTransactionAmtGiven_ReturnsTrue()
        {
            //Arrange
            IValidateCreditDetails creditDetails = new ValidateCreditDetails();
            double transactionAmt = 100.22;
            bool expected = true;
            //Act
            bool actual = creditDetails.IsTransactionAmtValid(transactionAmt);
            //Asssert
            Assert.Equal(expected, actual);
        }        

    }
}
