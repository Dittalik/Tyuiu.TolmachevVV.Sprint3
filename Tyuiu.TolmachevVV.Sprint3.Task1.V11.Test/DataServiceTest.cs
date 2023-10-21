using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TolmachevVV.Sprint3.Task1.V11.Lib;

namespace Tyuiu.TolmachevVV.Sprint3.Task1.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService service1 = new DataService();
            Assert.AreEqual(0.0048, service1.GetMultiplySeries(0.75, 1, 14));
        }
    }
}
