using System;
using System.Collections.Generic;

namespace CreditCardEMICalculator
{
    class InitiateTransaction
    {
        public static void DisplayTransactionDetails(TransactionDetails obj)
        {
            Console.WriteLine("Monthly EMI              :  Rs.   {0}", obj.emiPayable);
            Console.WriteLine("Total Interest Amount    :  Rs.   {0}", obj.totalInterestAmount);
            Console.WriteLine("Total Amount Payable     :  Rs.   {0}", obj.totalAmountPayable);
        }
        static void InputTransactionDetails()
        {
            var principalAmt = Convert.ToDouble(Console.ReadLine());
            var tenure = Convert.ToInt32(Console.ReadLine());
            var roi = Convert.ToDouble(Console.ReadLine());

            TransactionDetails transactionObj = new TransactionDetails(principalAmt, tenure, roi);
            
            TransactionCalculationUtility.CalculationUtility(transactionObj);

            InitiateTransaction.DisplayTransactionDetails(transactionObj);
        }
        static void Main(string[] args)
        {
            InitiateTransaction.InputTransactionDetails();
        }
    }
}
