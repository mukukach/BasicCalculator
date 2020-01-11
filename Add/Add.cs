using System;
using Operations;

namespace Adding

{
    
    public class Add : IAdd
    {
        public dynamic result;

        public dynamic Sum(dynamic a, dynamic b)

        {

            result = Addition.Sum(a, b);

            return result;

        }

    }
}

