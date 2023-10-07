using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.VorobevSA.Sрrint1.Task6.V15.Lib;

namespace Tyuiu.VorobevSA.Sрrint1.Task6.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService service1 = new DataService();
            string x = "текст";
            string res = service1.CheckLettersCount(x);
            Assert.AreEqual(res, 5);
        }
    }
}
