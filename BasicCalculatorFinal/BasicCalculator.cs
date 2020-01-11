using System;
using Operations;
using Adding;
using Subtract;
using Multiplyby;
using Divide;
using Squareby;
using Squareroots;
using Cubic;
using Helpers;

namespace BasicCalculator
{
    
    public class BasicCalculator : IAdd, ISubtract, IMultiplyby, IDivide, ISquareby, ISquareroots, ICubic
    {
        
        //Object Intialization
        private readonly Add Sumobj = new Add();

        Division divideob = new Division();
        Cube cubob = new Cube();
        Multiplication multiplyob = new Multiplication();
        Square sqrob = new Square();
        Squareroot sqrtob = new Squareroot();
        Subtraction subob = new Subtraction();
        public double result;
        
        public dynamic Result
        {
            get
            {
                string type = result.GetType().ToString();
                
                
               
                    if (type == "System.Int32")

                    {

                        return result;

                    }

                    else

                    {

                        return Helpers.Rounding.RoundTwoDecimalPlaces(result);

                        

                    }
            }
            set

            {

                result = value; 

            }



        }


       

    

        //Addition
        public dynamic Sum(dynamic a, dynamic b)

        {

            
            Result = Sumobj.Sum(a, b);

            return Result;

        }

        //Division

        public double Dividing(double a, double b)


        {

            Result = Division.Divide(a, b);

            return Result;


        }
        //Cube
        public double Cub(double a)
        {
            Result = Cube.Cub(a);
            return Result;
        }

        //Multiplication
        public dynamic Multiply(dynamic a, dynamic b)


        {

            Result = Multiplication.Multiply(a, b);


            return Result;

        }
        //Subtraction
        public dynamic Sub(dynamic a, dynamic b)

        {

            Result = Subtraction.Sub(a, b);


            return Result;

        }

        //Square
        public double Sqr(double a)
        {
            Result = Square.Sqr(a);

            return Result;


        }

        //Squareroot

        public double Sq(double a)
        {
            Result = Squareroot.Sq(a);
            return Result;
        }


    }
}
