using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.VorobevSA.Sрrint1.Task2.V0.Lib;

namespace Tyuiu.VorobevSA.Sрrint1.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculateSquarePerimetr()
        {
            DataService service1 = new DataService();
            int x = 5;
            var res = service1.CalculateSquarePerimetr(x);
            Assert.AreEqual(25, res);
        }
    }
}
