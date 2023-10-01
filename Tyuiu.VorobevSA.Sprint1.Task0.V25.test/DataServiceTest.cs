using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.VorobevSA.Sprint1.Task0.V25.lib;

namespace Tyuiu.VorobevSA.Sprint1.Task0.V25.test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService service1 = new DataService();
            var res = service1.Calculate();
            Assert.AreEqual(3, res);
        }
    }
}
