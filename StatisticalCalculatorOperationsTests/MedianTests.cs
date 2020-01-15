using Microsoft.VisualStudio.TestTools.UnitTesting;
using StatisticalCalculatorOperations;
using System;
using System.Collections.Generic;
using System.Text;

namespace StatisticalCalculatorOperations.Tests
{
    [TestClass()]
    public class MedianTests
    {
        private readonly double [] Arraya = { 7, 5, 1, 9, 4, 8, 6, 2 };
        [TestMethod()]
        public void FindMedianTest()
        {
            Assert.AreEqual(5.5, Median.FindMedian(Arraya));
        }
    }
}

namespace StatisticalCalculatorOperationsTests
{
    class MedianTests
    {
    }
}
