using System;
using CreditValidationLib;
//Should use our defined floating point type, so that if we 
// want to change double to float or long double it is very easy.
//eg using mydouble = double;
// and variables - public mydouble x;
// was not able to find a way to do in c#.

namespace CreditCardModelLib
{
    public class CreditCardDataModel
    {
        public double TransactionAmt { get; private set; }
        public int Tenure { get; private set; }
        public double InterestRate { get; private set; }
        
        public CreditCardDataModel(double transactionAmt, int tenure, double interestRate)
        {
            try 
            {
                    this.TransactionAmt = transactionAmt;
                    this.Tenure = tenure;
                    this.InterestRate = interestRate;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }

}
