using Microsoft.VisualStudio.TestTools.UnitTesting;
using Operations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Operations.Tests
{
    [TestClass()]
    public class SquareTests
    {
        private readonly int a = 5;
        private readonly double b = 5.5;
        [TestMethod()]
        public void SqrTest()
        {
            Assert.AreEqual(25, Square.Sqr(a));
        }

        [TestMethod()]
        public void SqrTest1()
        {
            Assert.AreEqual(30.25, Square.Sqr(b));
        }
    }
}