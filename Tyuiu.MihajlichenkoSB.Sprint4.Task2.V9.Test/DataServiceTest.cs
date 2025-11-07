using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MihajlichenkoSB.Sprint4.Task2.V9.Lib;

namespace Tyuiu.MihajlichenkoSB.Sprint4.Task2.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[] numArray = { 6, 2, 4, 2, 1, 7, 6, 2, 7, 6, 4, 6, 5, 5 };

            int res = ds.Calculate(numArray);
            int wait = 165888;

            Assert.AreEqual(wait, res);
        }
    }
}
