using System;
using StatisticalCalculatorOperations;

namespace Statmedian
{
    
    public class StatMedian : IStatMedian
    {
        

        public double FindMedian(double[] sourceNumbers)
        {
            return Median.FindMedian(sourceNumbers);
        }
    }
}
