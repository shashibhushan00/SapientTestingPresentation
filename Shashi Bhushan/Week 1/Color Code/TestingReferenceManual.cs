using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Diagnostics;

namespace TelCo.ColorCoder
{
    class TestingReferenceManual
    {
        public static Color[] MajorColor = ColorMap.colorMapMajor;
        public static Color[] MinorColor = ColorMap.colorMapMinor;

        public static int minSize = MinorColor.Length;
        public static int majSize = MajorColor.Length;
        public static void TestReferenceManual()
        {
            int pairNum = 1;
            for (int maj = 0; maj < majSize; maj++)
            {
                //Console.Write("{0}. {1} -> ", i++, majColor);
                for (int min = 0; min < minSize; min++)
                {
                    ColorPair pair = ColorFromPairNumber.GetColorFromPairNumber(pairNum);
                    Debug.Assert(pair.majorColor == MajorColor[maj]);
                    Debug.Assert(pair.minorColor == MinorColor[min]);

                    ColorPair newColorPair = new ColorPair();
                    newColorPair.majorColor = MajorColor[maj];
                    newColorPair.minorColor = MinorColor[min];

                    int getPairNum = PairNumberFromColor.GetPairNumberFromColor(newColorPair);
                    Debug.Assert(pairNum == getPairNum);

                    pairNum++;
                }
                //Console.WriteLine();
            }
        }
    }
}
