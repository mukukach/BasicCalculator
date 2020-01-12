using System;
using StatisticalCalculatorOperations;

namespace StatMean
{
    public class StatMean : IStatMean

    {
        public dynamic result;
        public double Meanvalue(double[] ArrayValues)
        {

            return result = Mean.MeanValue(ArrayValues);
        }
    }
}
