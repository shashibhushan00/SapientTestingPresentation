using System;
using System.Collections.Generic;
using System.Text;

namespace StatisticsLib
{
    public class StatsDataModel
    {
        public double average;
        public double max;
        public double min;
        public StatsDataModel(double _average = Double.NaN, double _max = Double.NaN, double _min = Double.NaN)
        {
            this.average = _average;
            this.max = _max;
            this.min = _min;
        }
    }
}
