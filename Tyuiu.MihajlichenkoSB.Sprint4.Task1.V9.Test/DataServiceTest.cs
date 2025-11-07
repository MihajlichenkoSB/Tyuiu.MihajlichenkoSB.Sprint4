using Tyuiu.MihajlichenkoSB.Sprint4.Task1.V9.Lib;
namespace Tyuiu.MihajlichenkoSB.Sprint4.Task1.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[] numArray = { 4, 0, 3, 12, 11 };

            int res = ds.Calculate(numArray);
            int wait = 23;

            Assert.AreEqual(wait, res);
        }
    }
}
