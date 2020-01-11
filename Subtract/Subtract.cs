using System;
using Operations;

namespace Subtract
{
    public class Subtract : ISubtract
    {
      
            public dynamic result;
            public dynamic Sub(dynamic a, dynamic b)

            {
                result = Subtraction.Sub(a, b);

                return result;
            }

        
    }
}
