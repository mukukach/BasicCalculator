﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Divide;
using System;
using System.Collections.Generic;
using System.Text;

namespace Divide.Tests
{
    [TestClass()]
    public class DivideTests
    {
        private readonly double a = 20;
        private readonly double b = 10;
        private readonly Divide Divideob = new Divide();
        [TestMethod()]
        public void DividebyTest()
        {  
            Assert.AreEqual(2, Divideob.Dividing(a,b));
        }
    }
}