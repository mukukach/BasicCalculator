using System;
using StatisticalCalculatorOperations;

namespace StatZscore
{
    public class StatZscore : IZscore
    {
        public dynamic result;

        public double ZScore(dynamic score, dynamic values)
        {
            return result = Zscore.ZScore(score, values);
        }
    }
}
