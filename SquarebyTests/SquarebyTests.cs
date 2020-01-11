using Microsoft.VisualStudio.TestTools.UnitTesting;
using Squareby;
using System;
using System.Collections.Generic;
using System.Text;

namespace Squareby.Tests
{
    
    [TestClass()]
    public class SquarebyTests
    {
        private readonly double a = 10;
        private readonly Squareby Squareobj = new Squareby();
        [TestMethod()]
        public void SqrTest()
        {
            Assert.AreEqual(100, Squareobj.Sqr(a) );
        }
    }
}