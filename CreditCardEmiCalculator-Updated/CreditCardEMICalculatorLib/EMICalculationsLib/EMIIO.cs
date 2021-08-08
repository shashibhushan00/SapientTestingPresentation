using System;
using System.Collections.Generic;
using System.Text;
using IOLib;

namespace EMILib
{
    public class EMIIO
    {
        static public void PrintEMIDetails(EMIDataModel emiDetails, IPrint destination)
        {
            string output = "";
            output += ($"Emi per mounth :  {emiDetails.EmiAmt} \n");
            output += ($"Interest Amount per mounth : " + emiDetails.InterestAmt + "\n");
            output += ($"Principal Amount per mounth : " + emiDetails.PrincleAmt + "\n");
            output += ($"Total amount to be payed : " + emiDetails.TotalAmt + "\n");

            destination.Print(output);
        }
    }
}
