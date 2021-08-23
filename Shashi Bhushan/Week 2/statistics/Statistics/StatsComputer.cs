using System;
using System.Collections.Generic;

namespace StatisticsLib
{   
    public class StatsComputer
    {
        public double GetMax(List<double> numbers)
        {
            double max;
            if (numbers.Count == 0)
                return Double.NaN;
            max = numbers[0];
            foreach (float number in numbers)
            {
                if (Double.NaN.Equals(number))
                    return Double.NaN;
                if (number > max)
                    max = number;
            }
            return max;
        }
        public double GetMin(List<double> numbers)
        {
            double min;
            if (numbers.Count == 0)
                return Double.NaN;
            min = numbers[0];
            foreach (float number in numbers)
            {
                if (Double.NaN.Equals(number))
                    return Double.NaN;
                if (number < min)
                    min = number;
            }
            return min;
        }
        public double GetAverage(List<double> numbers)
        {
            double avg=0;
            if (numbers.Count == 0)
                return Double.NaN;
            foreach (float number in numbers)
            {
                if (Double.NaN.Equals(number))
                    return Double.NaN;
                avg += number;
            }
            return avg/numbers.Count;
        }

        public StatsDataModel CalculateStatistics(List<double> numbers)
        {
            return new StatsDataModel(GetAverage(numbers), GetMax(numbers), GetMin(numbers));
        }
    }   
}

