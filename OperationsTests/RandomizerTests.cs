using Microsoft.VisualStudio.TestTools.UnitTesting;
using Operations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Operations.Tests
{
    [TestClass()]
    public class RandomizerTests
    {
        [TestMethod()]
        public void GetIntTest()
        {
            Randomizer rand = new Randomizer();
            int x = rand.GetInt();
            int y = rand.GetInt();

            Assert.AreEqual(x, y);
        }

        [TestMethod()]
        public void GetdoubleTest()
        {
            double a = (new Randomizer()).Getdouble();
            double b = (new Randomizer()).Getdouble();
            Assert.AreEqual(a, b);
        }
    }
}