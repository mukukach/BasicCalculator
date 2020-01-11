using Microsoft.VisualStudio.TestTools.UnitTesting;
using BasicCalculator;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCalculator.Tests
{
    [TestClass()]
    public class BasicCalculatorTests
    {
       private readonly BasicCalculator Calculate = new BasicCalculator();
       private readonly dynamic a = 4;
      private readonly  dynamic b = 2;
        [TestMethod()]
        public void SumTest()
        {
            Assert.AreEqual(6, Calculate.Sum (a, b));
        }

        [TestMethod()]
        public void DivideTest()
        {
            Assert.AreEqual(2, Calculate.Dividing(a,b));
        }

        [TestMethod()]
        public void CubTest()
        {
            Assert.AreEqual(64, Calculate.Cub(a));
        }

        [TestMethod()]
        public void MultiplyTest()
        {
            Assert.AreEqual(8, Calculate.Multiply(a,b));
        }

        [TestMethod()]
        public void SubTest()
        {
            Assert.AreEqual(2, Calculate.Sub(a, b));
        }

        [TestMethod()]
        public void SqrTest()
        {
            Assert.AreEqual(16, Calculate.Sqr(a));
        }

        [TestMethod()]
        public void SqTest()
        {
            Assert.AreEqual(2, Calculate.Sq(a));
        }
    }
}