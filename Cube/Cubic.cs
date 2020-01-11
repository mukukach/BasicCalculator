using System;
using Operations;
namespace Cubic
{
    public class Cubic : ICubic
    {
        public double result;

        public double Cub(double a)
        {
            result = Cube.Cub(a);
            return result;
        }
    }
}
