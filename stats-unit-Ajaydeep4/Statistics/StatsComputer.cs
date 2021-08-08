using System;
using System.Collections.Generic;

namespace StatisticsLib
{   
    public class StatsComputer
    {
        public StatsDataModel CalculateStatistics(List<double> numbers)
        {
            double max, min, average;
            if (numbers.Count == 0)
                return new StatsDataModel();
            max = numbers[0];
            min = numbers[0];
            average = 0;
            foreach(float number in numbers)
            {
                if (Double.NaN.Equals(number))
                    return new StatsDataModel();
                if (number > max)
                    max = number;
                if (number < min)
                    min = number;
                average += number;
            }
            average /= numbers.Count;
            return new StatsDataModel(average, max, min);
        }
    }   
}

