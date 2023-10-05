using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.VorobevSA.Sрrint1.Task4.V15.Lib;

namespace Tyuiu.VorobevSA.Sрrint1.Task4.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService service1 = new DataService();
            double x = 2;
            double y = 2;
            var res = service1.Calculate(x,y);
            Assert.AreEqual(0,125, res);
        }
    }
}
