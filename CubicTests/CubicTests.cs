using Microsoft.VisualStudio.TestTools.UnitTesting;
using Cubic;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cubic.Tests
{
    [TestClass()]
    public class CubicTests
    {
        private readonly double a = 10;
        private readonly Cubic Cubeobj = new Cubic();
        [TestMethod()]
        public void CubTest()
        {
            Assert.AreEqual(1000, Cubeobj.Cub(a));
        }
    }
}