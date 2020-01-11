using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCalculator
{
   public interface IBasicCalculator
    {
        public dynamic Sum(dynamic a, dynamic b);

        public double Divide(double a, double b);
        public double Cub(double a);
        public dynamic Multiply(dynamic a, dynamic b);
        public dynamic Sub(dynamic a, dynamic b);
        public double Sqr(double a);
        public double Sq(double a);
    }
}
