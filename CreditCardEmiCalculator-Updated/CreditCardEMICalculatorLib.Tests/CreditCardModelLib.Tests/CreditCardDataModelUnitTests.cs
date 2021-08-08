using System;
using Xunit;
using CreditCardModelLib;
using CreditValidationLib;

namespace CreditCardEMICalculatorLib.Tests
{
    public class CreditCardDataModelUnitTests
    {
        //Object State based Testing
        [Fact]
        public void CreditCardDataModel_ValidCreditCardDataGiven_CreditCardDataModelObjectCreatedWithGivenData()
        {
            //Arrange
            double transactionAmt = 1000.12;
            int tenure = 12;
            double interestRate = 24.25;
            double epsilon = 0.01;
            
            //Act
            CreditCardDataModel creditCard = new CreditCardDataModel(transactionAmt, tenure, interestRate);

            //Assert
            Assert.True(creditCard.TransactionAmt - transactionAmt < epsilon);
            Assert.True(creditCard.Tenure == tenure);
            Assert.True(creditCard.InterestRate - interestRate < epsilon);

        }
    }
}
