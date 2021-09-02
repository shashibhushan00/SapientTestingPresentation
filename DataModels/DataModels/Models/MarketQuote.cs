using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModels.Models
{
    public class MarketQuote
    {
        [Key]
        public int MarketQuoteId { get; set; }
        public DateTime CreatedAt { get; set; }
        public int NumberOfShares { get; set; }
        public decimal Price { get; set; }
        public string Region { get; set; }
        public string QuoteType { get; set; }
        public decimal RegularMarketChange { get; set; }
        public decimal RegularMarketChangePercentage { get; set; }
        public decimal RegularMarketDayHigh { get; set; }
        public decimal RegularMarketDayLow { get; set; }
        public long RegularMarketVolume { get; set; }
        public decimal RegularMarketOpen { get; set; }
        public decimal TrailingPE { get; set; }
        public decimal PriceToSales { get; set; }
        public decimal ForwardPE { get; set; }
        public bool Tradable { get; set; }
        public int SymbolId { get; set; }

        [ForeignKey("SymbolId")]
        public virtual Symbol Symbols { get; set; }
    }
}
