using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreditCardEMICalculator.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EMICalculatorController : ControllerBase
    {
        [HttpGet]
        [Route("{principal}/{roi}/{tenure}")]
        public IActionResult GetEMI(double principal, double roi, int tenure)
        {
            TransactionDetails obj = new TransactionDetails(principal, tenure, roi);
            CreditCardTransactionCalculation.CalculateEMIAmount(obj);
            CreditCardTransactionCalculation.TotalAmountPayable(obj);
            CreditCardTransactionCalculation.TotalInterestPayable(obj);
            return new JsonResult(obj);
        }
    }
}
