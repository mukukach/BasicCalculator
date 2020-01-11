using System;
using Operations;

namespace Divide
{
    public class Divide: IDivide
    {
        public double result;

        public double Dividing(double a, double b)
        {

            result = Division.Divide(a,b);

            return result;

    }   }
}
