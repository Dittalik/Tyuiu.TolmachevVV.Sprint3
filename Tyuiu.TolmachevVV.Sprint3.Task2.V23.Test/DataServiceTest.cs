using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TolmachevVV.Sprint3.Task2.V23.Lib;

namespace Tyuiu.TolmachevVV.Sprint3.Task2.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService service1 = new DataService();
            Assert.AreEqual(-63.727, service1.GetSumSeries(1.5, 1, 13));
        }
    }
}
