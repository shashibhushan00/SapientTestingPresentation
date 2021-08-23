using System;
using System.Collections.Generic;
using System.Text;

namespace DebtCode
{
    class LineReader
    {
        public static List<string> ReadLineFromStream(System.IO.Stream stream)
        {
            var lines = new List<string>();
            using (var reader = new System.IO.StreamReader(stream))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    lines.Add(line);
                }
            }
            return lines;
        }
    }
}
