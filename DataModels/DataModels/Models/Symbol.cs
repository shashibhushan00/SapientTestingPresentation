using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataModels.Models
{
    public class Symbol
    {
        [Key]
        public int SymbolId { get; set; }
        public string SymbolName { get; set; }
        public string Country { get; set; }
        public int ThirdPartyApiId { get; set; }

        [ForeignKey("ThirdPartyApiId")]
        public virtual ApiConfiguration ApiConfigurations { get; set; }
        public virtual List<MarketQuote> MarketQuotes { get; set; }
    }
}
