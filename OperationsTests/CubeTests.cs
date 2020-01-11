using Microsoft.VisualStudio.TestTools.UnitTesting;
using Operations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Operations.Tests
{
    [TestClass()]
    public class CubeTests
    {
        private readonly int a = 5;
        private readonly double b = 3;
        [TestMethod()]
        public void CubTest()
        {
            Assert.AreEqual(125, Cube.Cub(a));
        }

        [TestMethod()]
        public void CubTest1()
        {
            Assert.AreEqual(27, Cube.Cub(b));
        }
    }
}