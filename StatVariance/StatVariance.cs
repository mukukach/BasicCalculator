using System;
using StatisticalCalculatorOperations;

namespace StatVariance
{
    public class StatVariance: IStatVariance
    {
        public dynamic result;

        public double Findvariance(double[] ArrayValues)
        {
            return result = Variance.Findvariance(ArrayValues);
        }
    }
}
