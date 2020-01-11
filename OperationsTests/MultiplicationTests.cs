using Microsoft.VisualStudio.TestTools.UnitTesting;
using Operations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Operations.Tests
{
    [TestClass()]
    public class MultiplicationTests
    {
        private readonly int a = 50;
        private readonly int b = 2;
        private readonly double c = 5;
        private readonly double d = 2;
        [TestMethod()]
        public void MultiplyTest()
        {
            Assert.AreEqual(100, Multiplication.Multiply(a,b));
        }

        [TestMethod()]
        public void MultiplyTest1()
        {
            Assert.AreEqual(10, Multiplication.Multiply(c,d));
        }
    }
}