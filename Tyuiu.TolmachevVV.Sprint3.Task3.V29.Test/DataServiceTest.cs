using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TolmachevVV.Sprint3.Task3.V29.Lib;

namespace Tyuiu.TolmachevVV.Sprint3.Task3.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService service1 = new DataService();
            Assert.AreEqual("cgr vtg nt", service1.DeleteCharInString("chgr vhhtg hnht", 'h'));
        }
    }
}
