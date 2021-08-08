using System;
using System.Collections.Generic;
using System.Text;

namespace CreditValidationLib
{
   public class ValidateCreditDetails : IValidateCreditDetails
    {
        public bool IsTransactionAmtValid(double transactionAmt)
        {    
            return ( transactionAmt>=0);
        }

        public bool IsTenureValid(int tenure)
        {
            return tenure > 0;
        }

        public bool IsInterestRateValid(double interestRate)
        {
            return interestRate > 0;
        }

    }
}
