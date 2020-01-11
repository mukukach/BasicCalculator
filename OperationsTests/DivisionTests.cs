using Microsoft.VisualStudio.TestTools.UnitTesting;
using Operations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Operations.Tests
{
    [TestClass()]
    public class DivisionTests
    {
        private readonly double a = 25;
        private readonly double b = 2;
        [TestMethod()]
        public void DivideTest()
        {
            Assert.AreEqual(12.5, Division.Divide(a,b));
        }
    }
}