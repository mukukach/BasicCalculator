using Microsoft.VisualStudio.TestTools.UnitTesting;
using Subtract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Subtract.Tests
{
    [TestClass()]
    public class SubtractTests
    {
        private readonly dynamic a = 15;
        private readonly dynamic b = 20;
       readonly Subtract Subobj = new Subtract();
        [TestMethod()]
        public void SubTest()
        {
            Assert.AreEqual(-5, Subobj.Sub(a,b));
        }
    }
}