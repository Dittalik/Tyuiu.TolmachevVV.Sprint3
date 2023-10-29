using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TolmachevVV.Sprint3.Task5.V22.Lib;
namespace Tyuiu.TolmachevVV.Sprint3.Task5.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void SumCheck()
        {
            DataService service1 = new DataService();
            Assert.AreEqual(68.991, service1.GetSumSumSeries(2, 1, 1, 3, 12));
        }
    }
}
