using EMICalculator.Logic;
using EMICalculator.Models;
using Microsoft.AspNetCore.Mvc;

namespace EMIWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EMICalculatorController : ControllerBase
    {
        [HttpGet]
        public CardEMIDetails GetEMI(decimal principal, decimal roi, int tenure)
        {
            CreditDetails credit = new CreditDetails
            {
                TransactionAmount = principal,
                RateOfInterestPA = roi,
                TenureInMonths = tenure
            };

            CardEMIDetails emi = new CardEMIDetails();
            emi.UpdateEMIDetails(credit);
            return emi;
        }
    }
}
