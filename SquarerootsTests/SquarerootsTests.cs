using Microsoft.VisualStudio.TestTools.UnitTesting;
using Squareroots;
using System;
using System.Collections.Generic;
using System.Text;

namespace Squareroots.Tests
{
    [TestClass()]
    public class SquarerootsTests
    {
        private readonly double a = 25;
        private readonly Squareroots Squarerootobj = new Squareroots();
        [TestMethod()]
        public void SqrtTest()
        {
            Assert.AreEqual(5, Squarerootobj.Sq(a));
        }
    }
}