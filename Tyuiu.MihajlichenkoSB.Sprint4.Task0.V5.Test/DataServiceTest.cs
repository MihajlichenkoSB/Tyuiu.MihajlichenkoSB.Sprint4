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
            int[] numsArray = { 8, 9, 4, 1, 2, 3, 4, 5, 6, 7 };
            int expectedSum = 24;

            int res = ds.GetSumEvenArrEl(numsArray);
            Assert.AreEqual(expectedSum, res);
        }
    }
}
