using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.VorobevSA.Sрrint1.Task3.V2.Lib;

namespace Tyuiu.VorobevSA.Sрrint1.Task3.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService service1 = new DataService();
            double q = 13;
            int w = 4;
            double e=14;
            int r = 5;
            var res = service1.PurchaseAmount(q,w,e,r);
            Assert.AreEqual(122, res);

        }
    }
}
