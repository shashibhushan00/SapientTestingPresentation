using System;
using System.Collections.Generic;
using System.Text;

namespace DebtCode
{
    class XMLDocWriter
    {
        public static void WriteXMLDoc(List<TradeRecord> trades)
        {
            System.Xml.XmlWriter _xmlDocWriter = System.Xml.XmlWriter.Create("TradeRecords.xml");
            _xmlDocWriter.WriteStartDocument(true);
            _xmlDocWriter.WriteStartElement("TradeRecords");
            foreach (TradeRecord record in trades)
            {
                _xmlDocWriter.WriteStartElement("TradeRecord");
                _xmlDocWriter.WriteElementString(nameof(record.SourceCurrency), record.SourceCurrency);
                _xmlDocWriter.WriteElementString(nameof(record.DestinationCurrency), record.DestinationCurrency);
                _xmlDocWriter.WriteElementString(nameof(record.Lots), record.Lots.ToString());
                _xmlDocWriter.WriteElementString(nameof(record.Price), record.Price.ToString());
                _xmlDocWriter.WriteEndElement();
            }
            _xmlDocWriter.WriteEndElement();
            _xmlDocWriter.WriteEndDocument();
            _xmlDocWriter.WriteEndDocument();
            _xmlDocWriter.Flush();
            _xmlDocWriter.Close();
            Console.WriteLine("INFO: {0} trades processed", trades.Count);
        }
    }
}
