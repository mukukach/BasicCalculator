using Microsoft.VisualStudio.TestTools.UnitTesting;
using StatisticalCalculatorOperations;
using System;
using System.Collections.Generic;
using System.Text;

namespace StatisticalCalculatorOperations.Tests
{
    [TestClass()]
    public class VarianceTests
    {

      private readonly  double[] arrayA = { 1, 2, 3, 4,5,6};
        [TestMethod()]
        public void FindvarianceTest()
        {
            var variance = Variance.Findvariance(arrayA);


            Assert.AreEqual(3.17, Helpers.Rounding.RoundTwoDecimalPlaces(variance)) ;
        }
    }
}