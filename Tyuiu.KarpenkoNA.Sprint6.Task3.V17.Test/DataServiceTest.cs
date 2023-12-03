using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KarpenkoNA.Sprint6.Task3.V17.Lib;

namespace Tyuiu.KarpenkoNA.Sprint6.Task3.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            int[,] mas2 = new int[5, 5] { { 22, 32, -16, 24, 27 },
                                          { 3, -20, 24, -20, 25 },
                                          { 21, 17, -8, -19, 17 },
                                          { 8, 22, 28, 27, 19 },
                                          { 11, 20, 12, 27, 29 } };

            int[,] res = ds.Calculate(mas2);
            int[,] wait = { { 22, 32, -16, 24, 17 },
                            { 3, -20, 24, -20, 19 },
                            { 21, 17, -8, -19, 25 },
                            { 8, 22, 28, 27, 27 },
                            { 11, 20, 12, 27, 29 } }; 

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
