using Microsoft.VisualStudio.TestTools.UnitTesting;
using Operations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Operations.Tests
{
    [TestClass()]
    public class SquarerootTests
    {
        private readonly double a = 25;
        [TestMethod()]
        public void SqTest()
        {
            Assert.AreEqual(5, Squareroot.Sq(a));
        }
    }
}