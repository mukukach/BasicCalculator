using System;
using StatisticalCalculatorOperations;

namespace StatMode
{
    public class StatMode: IStatMode
    {
        public double result;
        public double Findmode(int[] x)
        {
            return result = Mode.Findmode(x);
        }
    }
}
