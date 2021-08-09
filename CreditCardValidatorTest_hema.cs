using System;
using Xunit;
using ClassLibraryProjects.CreditCardValidatorLibrary;

namespace ClassLibraryProjects.CrediCardValidator.Tests
{
    public class CreditCardValidatorTest
    {
        [Fact]
        public static void GivenCreditCardLengthLessThanThirteenReturnFalse()
        {
            //Arrange
            var cardNumber="477689320214";
            var expected_valid_flag=false;
            
            //Act
            var valid_flag = CreditCardValidator.ValidateCreditCardLength(cardNumber);
            //Assert  
            Assert.Equal(expected_valid_flag, valid_flag);  

        }

        [Fact]
        public static void GivenCreditCardLengthGreaterThanSixteenReturnFalse()
        {
            //Arrange
            var cardNumber="47768932021456787";
            var expected_valid_flag=false;
            
            //Act
            var valid_flag = CreditCardValidator.ValidateCreditCardLength(cardNumber);
            //Assert  
            Assert.Equal(expected_valid_flag, valid_flag);  

        }

        [Fact]
        public static void GivenCredCardNumberStartsWithFourReturnVisaType()
        {
            //Arrange
            var cardNumber= "4776893202149136";
            var expected_card_type="visa";

            //Act
            var car_type=IssuedInstitueIdentifier.IdentifyCardType(cardNumber);

            //Assert
            Assert.Equal(expected_card_type, car_type);


        }

        [Fact]
        public static void GivenCredCardNumberStartsWithFiveReturnMasterType()
        {
            //Arrange
            var cardNumber= "5368312374012874";
            var expected_card_type="master";

            //Act
            var car_type=IssuedInstitueIdentifier.IdentifyCardType(cardNumber);

            //Assert
            Assert.Equal(expected_card_type, car_type);


        }

        [Fact]
        public static void GivenCredCardNumberStartsWithSixReturnDiscoverType()
        {
            //Arrange
            var cardNumber= "6011407190286410";
            var expected_card_type="discover";

            //Act
            var car_type=IssuedInstitueIdentifier.IdentifyCardType(cardNumber);

            //Assert
            Assert.Equal(expected_card_type, car_type);


        }

        [Fact]
         public static void GivenValidCredCardNumberReturnTrue()
        {
            //Arrange
            string cardNumber= "5184289896755309";
            var expected_result=true;

            //Act
            var result=CreditCardLuhnChecker.LuhnCheck(cardNumber);

            //Assert
            Assert.Equal(expected_result, result);


        }

        [Fact]
         public static void GivenCredCardNumberStartsWithSevenReturnPetroleumType()
        {
            //Arrange
            var cardNumber= "7184289896755309";
            var expected_industry_type="Petroleum";

            //Act
            var industry_type=MajorIndustryIdentifier.IdentifyMajorIndustry(cardNumber);

            //Assert
            Assert.Equal(expected_industry_type, industry_type);


        }


        
    }
}
