using System;
using BasicCalculator2;
using Operations;
using Adding;
using Statmean;
using Statmedian;
using Statmode;
using Statvariance;
using Statzscore;
using Standarddev;

namespace StatisticalCalculator
{
    public class StatisticalCalculator : IStatMedian, IStatMean, IStatMode,IStatVariance,IZscore, IStandarddev
    {
        private readonly BasicCalculator CalculatorObj = new BasicCalculator();
        private readonly int DecimalPlace;
        private readonly StatMean meanobj = new StatMean();
        private readonly StatVariance varianceobj = new StatVariance();
        private readonly StatMode modeobj = new StatMode();
        private readonly StatMedian meadianobj = new StatMedian();
        private readonly StandardDev StandardDevobj = new StandardDev();
        private readonly StatZscore zscoreobj = new StatZscore();
        private dynamic result;
        public dynamic Result
        {

            get
            {
                string type = result.GetType().ToString();
                if (type == "System.Int32")
                {
                    return result;
                }
                else
                {
                    return Helpers.Rounding.RoundTwoDecimalPlaces(result);
                }
            }
            set
            {
                result = value;
            }
        }

     
         public double Meanvalue(double[] arrayvalues)
        {
            Result =meadianobj.FindMedian(arrayvalues); 
            return Result;
        }

        public double Findmode(double [] arrayvalues)
        {
            Result = modeobj.Findmode(arrayvalues); 
            return Result;
        }

        public double SD(double[] arrayvalues)
        {
            Result= StandardDevobj.SD(arrayvalues); 
            return Result;
        }

        public double FindMedian(double[] arrayvalues)
        {
            Result = meadianobj.FindMedian(arrayvalues);
            return Result;
        }

        public double Findvariance(double[] arrayvalues)
        {
            Result = varianceobj.Findvariance(arrayvalues);
            return Result;
        }

        public double ZScore(dynamic score, dynamic values)
        {
            return Result = zscoreobj.ZScore(score, values);
        }

        public double SD(dynamic value)
        {
            return Result = StandardDevobj.SD(value);
        }

    }
    
} 
