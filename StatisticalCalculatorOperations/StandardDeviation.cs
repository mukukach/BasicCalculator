using System;
using System.Collections.Generic;
using System.Text;
using Operations;

namespace StatisticalCalculatorOperations
{
   public class StandardDeviation
    {
        
        public static double SD(dynamic value)
        {
             return Squareroot.Sq(Variance.Findvariance(value));

           
            
        }

    }
}
