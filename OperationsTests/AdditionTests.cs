using Microsoft.VisualStudio.TestTools.UnitTesting;
using Operations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Operations.Tests
{
    [TestClass()]
    public class AdditionTests
    {
        private readonly int a = 5;
        private readonly int b = 95;
        private readonly double c = 5.5;
        private readonly double d = 2.1;
        private readonly double[] arrayA = { 1.01, 2.04, 3.06, 4.07, 6.4, 7, 8, 9, 10 };
        private readonly int[] arrayB = { 1, 2, 3, 4, 6, 7, 8, 9, 10 };
        [TestMethod()]
        public void SumTest()
        {
            Assert.AreEqual(100, Addition.Sum(a,b));
        }

        [TestMethod()]
        public void SumTest1()
        {
            Assert.AreEqual(7.6, Addition.Sum(c,d));
        }

        [TestMethod()]
        public void SumTest2()
      
        {

         Assert.AreEqual(50.58, Addition.Sum(arrayA));

        }
       

        [TestMethod()]
        public void SumTest3()
        {
            Assert.AreEqual(50, Addition.Sum(arrayB));
        }
    }
}