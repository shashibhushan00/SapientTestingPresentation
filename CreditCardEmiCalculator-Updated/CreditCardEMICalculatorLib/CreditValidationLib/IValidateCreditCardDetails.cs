using System;
using System.Collections.Generic;
using System.Text;

namespace CreditValidationLib
{
    public interface IValidateCreditDetails
    {
        public bool IsTransactionAmtValid(double transactionAmt);
        public bool IsTenureValid(int tenure);
        public bool IsInterestRateValid(double interestRate);

    }
}
