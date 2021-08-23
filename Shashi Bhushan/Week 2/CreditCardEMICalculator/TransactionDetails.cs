using System;
using System.Collections.Generic;
using System.Text;

namespace CreditCardEMICalculator
{
    public class TransactionDetails
    {
        public double TransactionAmount;
        public int Tenure;
        public double rateOfInterest;
        public double emiPayable;
        public double totalInterestAmount;
        public double totalAmountPayable;

        public TransactionDetails(double transactionAmt, int tenure, double roi)
        {
            TransactionAmount = transactionAmt;
            Tenure = tenure;
            rateOfInterest = roi;
        }
    }
}
