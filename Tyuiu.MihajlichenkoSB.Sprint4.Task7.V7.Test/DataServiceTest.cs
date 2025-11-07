using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MihajlichenkoSB.Sprint4.Task7.V7.Lib;

namespace Tyuiu.MihajlichenkoSB.Sprint4.Task7.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int n = 4;
            int m = 2;
            string str = "31415926";

            int expected = 5;

            int actual = ds.Calculate(n, m, str);

            Assert.AreEqual(expected, actual);
        }
    }
}
