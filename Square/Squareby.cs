using System;
using Operations;
namespace Squareby
{
    public class Squareby : ISquareby
    {
        public double result;

        public double Sqr(double a)
        {
            result = Square.Sqr(a);

            return result;
        
        
        }
    }
}
