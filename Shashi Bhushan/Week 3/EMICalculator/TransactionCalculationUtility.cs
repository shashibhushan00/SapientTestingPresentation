using System;
using System.Collections.Generic;
using System.Text;

namespace CreditCardEMICalculator
{
    public class TransactionCalculationUtility
    {
        public static void CalculationUtility(TransactionDetails transactionDetails)
        {
            CreditCardTransactionCalculation.CalculateEMIAmount(transactionDetails);
            CreditCardTransactionCalculation.TotalInterestPayable(transactionDetails);
            CreditCardTransactionCalculation.TotalAmountPayable(transactionDetails);
        }
    }
}
