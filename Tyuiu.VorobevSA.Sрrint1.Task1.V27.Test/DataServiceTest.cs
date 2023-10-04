using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.VorobevSA.Sрrint1.Task1.V27.Lib;

namespace Tyuiu.VorobevSA.Sрrint1.Task1.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService service1 = new DataService();
            double x = 2;
            double y = 3;
            var res = service1.Calculate(x,y);
            Assert.AreEqual(2.5, res);
        }
    }
}
