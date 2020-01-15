using Microsoft.VisualStudio.TestTools.UnitTesting;
using StatisticalCalculator;
using System;
using System.Collections.Generic;
using System.Text;

namespace StatisticalCalculator.Tests
{
    [TestClass()]
    public class StatisticalCalculatorTests
    {
        StatisticalCalculator compute = new StatisticalCalculator();
        private readonly double[] ArrayValues = { 1, 2,4,3, 4, 5, 4 };
        private readonly dynamic score = 1100;
        public void MeanvalueTest()
        {
            Assert.AreEqual(3.5, compute.Meanvalue(ArrayValues));
        }

        [TestMethod()]
        public void FindmodeTest()
        {
            Assert.AreEqual(4, compute.Findmode(ArrayValues)); 
        }

        [TestMethod()]
        public void SDTest()
        {
            Assert.AreEqual(1.31, compute.SD(ArrayValues));
        }

        [TestMethod()]
        public void FindMedianTest()
        {
            Assert.AreEqual(4, compute.FindMedian(ArrayValues));
        }

        [TestMethod()]
        public void FindvarianceTest()
        {
            Assert.AreEqual(1.71, compute.Findvariance(ArrayValues));
        }

        [TestMethod()]
        public void ZScoreTest()
        {
            Assert.AreEqual(837.19, compute.ZScore(score, ArrayValues));
        }

        
    }
}