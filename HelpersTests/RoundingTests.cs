using Microsoft.VisualStudio.TestTools.UnitTesting;
using Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Helpers.Tests
{
    [TestClass()]
    public class RoundingTests
    {
        private readonly double num = 41.759900000005;
        [TestMethod()]
        public void RoundTwoDecimalPlacesTest()
        {
            Assert.AreEqual(41.76, Helpers.Rounding.RoundTwoDecimalPlaces(num));
        }
    }
}