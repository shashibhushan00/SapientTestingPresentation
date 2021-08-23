using System;
using System.Collections.Generic;
using System.Text;

namespace DebtCode
{
    class TradeRecord
    {
        public string SourceCurrency { get; set; }

        public string DestinationCurrency { get; set; }

        public float Lots { get; set; }

        public decimal Price { get; set; }
    }
}
