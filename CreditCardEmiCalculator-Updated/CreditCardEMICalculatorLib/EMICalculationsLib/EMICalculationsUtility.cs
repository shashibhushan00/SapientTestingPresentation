using System;
using System.Collections.Generic;
using System.Text;

namespace EMILib
{
    static public class EMICalculationsUtility
    {
        static public double MonthlyInterestRateInDecimal(double interestRate)
        {
            return interestRate / 12 / 100;
        }
        static public double InterestAmountPerMonth(double transactionAmt, double interestRate)
        {
            return (transactionAmt * MonthlyInterestRateInDecimal(interestRate));
        }
        static public double EMIAmout(double transactionAmt, int tenure, double interestRate)
        {
            return (InterestAmountPerMonth(transactionAmt, interestRate))*( Math.Pow(1 + MonthlyInterestRateInDecimal(interestRate), tenure) / ( Math.Pow(1 + MonthlyInterestRateInDecimal(interestRate), tenure) - 1)) ;
        }
        static public double PrincipalPayablePerMonth(double transactionAmt, int tenure, double interestRate)
        {
            return (EMIAmout(transactionAmt, tenure, interestRate) - InterestAmountPerMonth(transactionAmt, interestRate));
        }
        static public double TotalAmountPayble(double transactionAmt, int tenure, double interestRate)
        {
            return tenure * EMIAmout(transactionAmt, tenure, interestRate);
        }
        static public double TotalInterestPayble(double transactionAmt, int tenure, double interestRate)
        {
            return tenure * InterestAmountPerMonth(transactionAmt, interestRate);
        }

    }
}
