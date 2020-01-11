using System;
using Operations;

namespace Multiplyby
{
    public class Multiplyby : IMultiplyby
    {
        public dynamic result;

        public dynamic Multiply(dynamic a, dynamic b)
        {
            result = Multiplication.Multiply(a, b);
            return result;
        }
    }
}
