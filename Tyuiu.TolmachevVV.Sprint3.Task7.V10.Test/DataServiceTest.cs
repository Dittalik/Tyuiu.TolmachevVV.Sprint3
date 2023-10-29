using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TolmachevVV.Sprint3.Task7.V10.Lib;

namespace Tyuiu.TolmachevVV.Sprint3.Task7.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void MassCheck()
        {
            DataService service1 = new DataService();
            double[] check = new double[5 - (-5) + 1];
            check[0] = -15.40;
            check[1] = -13.31;
            check[2] = -11.36;
            check[3] = -8.00;
            check[4] = -2.62;
            check[5] = 1.83;
            check[6] = 4.49;
            check[7] = 6.78;
            check[8] = 10.58;
            check[9] = 17.38;
            check[10] = 23.76;
            CollectionAssert.AreEqual(check, service1.GetMassFunction(-5, 5));
        }
    }
}
