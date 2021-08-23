namespace EMICalculator.Models
{
    public class CardEMIDetails
    {
        public decimal MonthlyEMI { get; set; } = -1;
        public decimal TotalInterestAmount { get; set; } = -1;
        public decimal TotalAmountPayable { get; set; } = -1;
    }
}
