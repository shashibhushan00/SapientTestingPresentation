using System;
using System.Collections.Generic;
using System.Text;
using EMILib;
using IOLib;
using CreditValidationLib;
using CreditCardModelLib;
namespace CreditCardModelExtensionsLib
{
    static public class CreditCardDataModelExtensions
    {
        static public EMIDataModel GetEMIDetails(this CreditCardDataModel creditCard, IValidateCreditDetails validator)
        {
            try
            {
                validator.IsTransactionAmtValid(creditCard.TransactionAmt);
                validator.IsTenureValid(creditCard.Tenure);
                validator.IsInterestRateValid(creditCard.InterestRate);
            }
            catch (Exception)
            {

                throw;
            }
            EMIDataModel emiDetails = new EMIDataModel
            {
                EmiAmt = EMICalculationsUtility.EMIAmout(creditCard.TransactionAmt, creditCard.Tenure, creditCard.InterestRate),
                InterestAmt = EMICalculationsUtility.InterestAmountPerMonth(creditCard.TransactionAmt, creditCard.InterestRate),
                PrincleAmt = EMICalculationsUtility.PrincipalPayablePerMonth(creditCard.TransactionAmt, creditCard.Tenure, creditCard.InterestRate),
                TotalAmt = EMICalculationsUtility.TotalAmountPayble(creditCard.TransactionAmt, creditCard.Tenure, creditCard.InterestRate)
            };
            return emiDetails;
        }

    }
}
