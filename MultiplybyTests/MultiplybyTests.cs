using Microsoft.VisualStudio.TestTools.UnitTesting;
using Multiplyby;
using System;
using System.Collections.Generic;
using System.Text;

namespace Multiplyby.Tests
{
    [TestClass()]
    public class MultiplybyTests
    {
        private readonly dynamic a = 50;
        private readonly dynamic b = 2;
        private readonly Multiplyby Multiplyobj = new Multiplyby();
        [TestMethod()]
        public void MultiplyTest()
        {
            Assert.AreEqual(100, Multiplyobj.Multiply(a,b));
        }
    }
}