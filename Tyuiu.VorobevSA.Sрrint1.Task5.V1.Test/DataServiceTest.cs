using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.VorobevSA.Sрrint1.Task5.V1.Lib;

namespace Tyuiu.VorobevSA.Sрrint1.Task5.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService service1 = new DataService();
            double x1 = 0;
            double y1 = 0;
            double x2 = 5;
            double y2 = 5;
            var res = service1.DistanceBetweenDots(x1, y1, x2, y2);
            Assert.AreEqual(7, res);
        }
    }
}
