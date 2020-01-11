using Microsoft.VisualStudio.TestTools.UnitTesting;
using Adding;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adding.Tests
{
    [TestClass()]
    public class AddTests
    {
        Add Sum = new Add();
        dynamic a = 5;
        dynamic b = 2;
        [TestMethod()]
        public void AddfuncTest()
        {
            Assert.AreEqual(7, Sum.Sum(a,b) );
        }
    }
}