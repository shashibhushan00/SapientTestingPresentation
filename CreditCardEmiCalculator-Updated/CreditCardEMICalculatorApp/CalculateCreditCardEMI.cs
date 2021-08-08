using System;
using System.Collections.Generic;
using System.Text;
using CreditCardModelLib;
using IOLib;
using CreditValidationLib;
using EMILib;
using CreditCardModelExtensionsLib;
namespace CreditCardEMICalculatorApp
{
    class CalculateCreditCardEMI
    {

        static public void Main()
        {
            IPrint printDestination = new PrintOnConsole();
            printDestination.Print($"Enter Transaction Amount, Tenure, Interest Rate");
            CreditCardDataModel creditCard = CreditCardInput.InuptFromConsole(new ReadFromConsole());
            EMIIO.PrintEMIDetails(creditCard.GetEMIDetails(new ValidateCreditDetails() ) , printDestination);            
        }

    }
}
