using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace TelCo.ColorCoder
{
    class PrintAllPairColorCodes
    {
        public static Color[] MajorColor = ColorMap.colorMapMajor;
        public static Color[] MinorColor = ColorMap.colorMapMinor;

        private static int majSize = MajorColor.Length;
        private static int minSize = MinorColor.Length;

        public static void PrintAllColorCodes(IWritable print)
        {
            int i = 1;
            for(int maj = 0;maj < majSize;maj++)
            {
                //Console.Write("{0}. {1} -> ", i++, majColor);
                for(int min = 0;min < minSize;min++)
                {
                    print.PrintALine($"MajorColor : " + MajorColor[maj] + ", MinorColor : " + MinorColor[min] + ", PairNo : " + i++);
                }
                //Console.WriteLine();
            }
        }

    }
}
