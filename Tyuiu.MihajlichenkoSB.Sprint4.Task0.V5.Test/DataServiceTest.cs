using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MihajlichenkoSB.Sprint4.Task0.V5.Lib;

namespace Tyuiu.MihajlichenkoSB.Sprint4.Task0.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            int[] numsArray = { 4, 0, 3, 0, 10 };
            int expectedSum = 14;
            int res = ds.GetSumEvenArrEl(numsArray);

            Assert.AreEqual(expectedSum, res);
        }
    }
}
