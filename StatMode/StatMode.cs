using System;
using StatisticalCalculatorOperations;

namespace Statmode
{
    public class StatMode: IStatMode
    {
        public double result;
        public double Findmode(double[] x)
        {
            return result = Mode.Findmode(x);
        }
    }
}
