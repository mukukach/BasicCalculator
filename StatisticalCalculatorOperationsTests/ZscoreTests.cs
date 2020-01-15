using Microsoft.VisualStudio.TestTools.UnitTesting;
using StatisticalCalculatorOperations;
using System;
using System.Collections.Generic;
using System.Text;

namespace StatisticalCalculatorOperations.Tests
{
    [TestClass()]
    public class ZscoreTests
    {
        private readonly double[] values = { 1, 2, 3, 4,5,6};
        private readonly dynamic score = 1100;
        [TestMethod()]
        public void ZScoreTest()
        {
            Assert.AreEqual(616.01, Zscore.ZScore(score,values));
        }
    }
}