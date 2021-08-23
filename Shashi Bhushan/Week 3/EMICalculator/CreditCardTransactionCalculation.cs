using System;
using System.Collections.Generic;
using System.Text;

namespace CreditCardEMICalculator
{
    public static class CreditCardTransactionCalculation
    {
        public static void TotalAmountPayable(TransactionDetails transactionDetails)
        {
            double totAmount = transactionDetails.Tenure * transactionDetails.emiPayable;
            transactionDetails.totalAmountPayable = totAmount;
        }
        public static void TotalInterestPayable(TransactionDetails transactionDetails)
        {
            double interest =  transactionDetails.Tenure * transactionDetails.emiPayable - transactionDetails.TransactionAmount;
            transactionDetails.totalInterestAmount = interest;
        }
        public static void CalculateEMIAmount(TransactionDetails transactionDetail)
        {
            var amount = transactionDetail.TransactionAmount;
            var tenure = transactionDetail.Tenure;
            var roi = transactionDetail.rateOfInterest;

            double roiPerMonth =  roi / 1200;
            double interestAmountPerMonth = amount * roiPerMonth;

            double exponent = Math.Pow(roiPerMonth + 1, tenure);
            double fraction = exponent / (exponent - 1);
            double product = amount * roiPerMonth * fraction;
            double emiPayable = Math.Round(product, 2);

            transactionDetail.emiPayable = emiPayable;
        }
    }
}
