using System;
using System.Collections.Generic;
using System.Text;

namespace CreditCardEMICalculator
{
    public class TransactionDetails
    {
        public double TransactionAmount { get; set; }
        public int Tenure { get; set; }
        public double rateOfInterest { get; set; }
        public double emiPayable { get; set; }
        public double totalInterestAmount { get; set; }
        public double totalAmountPayable { get; set; }

        public TransactionDetails(double transactionAmt, int tenure, double roi)
        {
            TransactionAmount = transactionAmt;
            Tenure = tenure;
            rateOfInterest = roi;
        }
    }
}
