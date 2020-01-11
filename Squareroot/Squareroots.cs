using System;
using Operations;

namespace Squareroots
{
    public class Squareroots :ISquareroots

    {
        public double result;

        public double Sq(double a)
        {
            result = Squareroot.Sq(a);
            return result;
        }
    }
}
