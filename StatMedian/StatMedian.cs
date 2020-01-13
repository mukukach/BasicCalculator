using System;
using StatisticalCalculatorOperations;

namespace StatMedian
{
    
    public class StatMedian : IStatMedian
    {
        public double result;

        public dynamic MeanValue(double[] ArrayValues)
        {
            return result = Mean.MeanValue(ArrayValues);
        }
    }
}
