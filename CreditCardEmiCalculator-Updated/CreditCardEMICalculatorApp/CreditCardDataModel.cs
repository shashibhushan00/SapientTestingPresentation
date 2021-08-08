using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreditCardModelLib;
using IOLib;

namespace CreditCardEMICalculatorApp
{
    public class CreditCardInput
    {
        static public CreditCardDataModel InuptFromConsole(ITakeIput inuptDestination)
        {
            double transactionAmt = Convert.ToDouble(inuptDestination.Read());
            int tenure = Convert.ToInt32(inuptDestination.Read());
            double interestRate = Convert.ToDouble(inuptDestination.Read());
            return new CreditCardDataModel(transactionAmt, tenure, interestRate);
        }
    }
}
