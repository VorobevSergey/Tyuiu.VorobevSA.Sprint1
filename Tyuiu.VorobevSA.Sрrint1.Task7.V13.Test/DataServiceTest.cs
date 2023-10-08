using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.VorobevSA.Sрrint1.Task7.V13.Lib;

namespace Tyuiu.VorobevSA.Sрrint1.Task7.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService service1 = new DataService();
            double x = 45;
            double y = 30;
            var res = service1.Calculate(x, y);
            Assert.AreEqual(1,001 , res);
        }
    }
}
