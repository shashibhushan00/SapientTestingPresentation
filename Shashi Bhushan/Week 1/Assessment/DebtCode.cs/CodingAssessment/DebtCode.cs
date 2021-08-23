using System;
using System.Collections.Generic;
using System.Xml;

namespace DebtCode
{
    public class TradeProcessor
    {
        public void ProcessTrades(System.IO.Stream stream)
        {
            // read rows
            var lines = new List<string>();
            lines = LineReader.ReadLineFromStream(stream);

            var trades = new List<TradeRecord>();
            trades = RecordReader.ReadTradeRecordFromStreamFile(stream, lines);

            XMLDocWriter.WriteXMLDoc(trades);
            
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            TradeProcessor _tradeProcessor = new TradeProcessor();
            _tradeProcessor.ProcessTrades(new System.IO.StreamReader("TradeRecords.csv").BaseStream);
        }
    }
}
