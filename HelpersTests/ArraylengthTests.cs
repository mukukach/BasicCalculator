using Microsoft.VisualStudio.TestTools.UnitTesting;
using Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Helpers.Tests
{
    [TestClass()]
    public class ArraylengthTests
    {
        private readonly int[] arrayA = { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };
        [TestMethod()]
        public void ArrayLengthTest()
        {
            Assert.AreEqual(10, Helpers.Arraylength.ArrayLength(arrayA));
        }
    }
}