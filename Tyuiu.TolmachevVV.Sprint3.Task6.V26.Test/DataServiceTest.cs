using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TolmachevVV.Sprint3.Task6.V26.Lib;

namespace Tyuiu.TolmachevVV.Sprint3.Task6.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void DivSumCheck()
        {
            DataService service1 = new DataService();
            Assert.AreEqual(33, service1.GetSumTheDivisors(15, 22));
        }
    }
}
