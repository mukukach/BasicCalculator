using System;
using Operations;
using Adding;
using Subtract;
using Multiplyby;
using Divide;
using Squareby;
using Squareroots;
using Cubic;

namespace BasicCalculator
{
    
    public class BasicCalculator : IAdd, ISubtract, IMultiplyby, IDivide, ISquareby, ISquareroots, ICubic
    {
        public dynamic result;
        //Object Intialization
        private readonly Add Sumobj = new Add();

        Division divideob = new Division();
        Cube cubob = new Cube();
        Multiplication multiplyob = new Multiplication();
        Square sqrob = new Square();
        Squareroot sqrtob = new Squareroot();
        Subtraction subob = new Subtraction();

        //Addition
        public dynamic Sum(dynamic a, dynamic b)

        {

            
            result = Sumobj.Sum(a, b);

            return result;

        }

        //Division

        public double Dividing(double a, double b)


        {

            result = Division.Divide(a, b);

            return result;


        }
        //Cube
        public double Cub(double a)
        {
            result = Cube.Cub(a);
            return result;
        }

        //Multiplication
        public dynamic Multiply(dynamic a, dynamic b)


        {

            result = Multiplication.Multiply(a, b);


            return result;

        }
        //Subtraction
        public dynamic Sub(dynamic a, dynamic b)

        {

            result = Subtraction.Sub(a, b);


            return result;

        }

        //Square
        public double Sqr(double a)
        {
            result = Square.Sqr(a);

            return result;


        }

        //Squareroot

        public double Sq(double a)
        {
            result = Squareroot.Sq(a);
            return result;
        }


    }
}
