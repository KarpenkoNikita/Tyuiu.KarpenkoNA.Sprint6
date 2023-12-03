﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KarpenkoNA.Sprint6.Task0.V13.Lib;

namespace Tyuiu.KarpenkoNA.Sprint6.Task0.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(3);
            double wait = 3.375;
            Assert.AreEqual(wait, res);
        }
    }
}
