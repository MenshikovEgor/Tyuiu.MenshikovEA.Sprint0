using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MenshikovEA.Sprint0.Task2.V0.Lib;

namespace Tyuiu.MenshikovEA.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Egor";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Hello..., Egor", res);
        }
    }
}
