using EMICalculator.Models;
using MathUtilities;

namespace EMICalculator.Logic
{
    public static class EMIDetailsCalculator
    {
        public static void UpdateEMIDetails(this CardEMIDetails emiDetails, CreditDetails credit)
        {
            emiDetails.CalculateEMI(credit);
            emiDetails.CalculateTotalAmountPayable(credit);
            emiDetails.CalculateTotalInterest(credit);
        }

        public static void CalculateEMI(this CardEMIDetails emiDetails, CreditDetails credit)
        {
            decimal principal = credit.TransactionAmount;
            decimal ratePerMonth = credit.RateOfInterestPA / 1200;
            int months = credit.TenureInMonths;

            decimal exponent = DecimalMath.DecimalPow(ratePerMonth + 1, months);
            emiDetails.MonthlyEMI = CalculateEMIFromDetails(principal, ratePerMonth, exponent);
        }

        public static void CalculateTotalAmountPayable(this CardEMIDetails emiDetails, CreditDetails credit)
        {
            if (emiDetails.MonthlyEMI == -1)
            {
                emiDetails.CalculateEMI(credit);
            }
            decimal amount = emiDetails.MonthlyEMI * credit.TenureInMonths;
            emiDetails.TotalAmountPayable = System.Math.Round(amount, 2);
        }

        public static void CalculateTotalInterest(this CardEMIDetails emiDetails, CreditDetails credit)
        {
            if (emiDetails.TotalAmountPayable == -1)
            {
                emiDetails.CalculateTotalAmountPayable(credit);
            }
            decimal principal = credit.TransactionAmount;
            decimal amount = emiDetails.TotalAmountPayable - principal;
            emiDetails.TotalInterestAmount = System.Math.Round(amount, 2);
        }

        private static decimal CalculateEMIFromDetails(decimal principal, decimal rate, decimal exponent)
        {
            decimal fraction = exponent / (exponent - 1);
            decimal product = principal * rate * fraction;
            return System.Math.Round(product, 2);
        }
    }
}