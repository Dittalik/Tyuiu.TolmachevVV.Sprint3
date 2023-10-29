using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TolmachevVV.Sprint3.Task4.V24.Lib;

namespace Tyuiu.TolmachevVV.Sprint3.Task4.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CalcCheck()
        {
            DataService service1 = new DataService();
            Assert.AreEqual(46.75, service1.Calculate(-5, 5));
        }
    }
}
