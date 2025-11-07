using Tyuiu.MihajlichenkoSB.Sprint4.Task4.V17.Lib;
namespace Tyuiu.MihajlichenkoSB.Sprint4.Task4.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[,] matrix = new int[5, 5] {
                { 9, 6, 4, 5, 3 },
                { 7, 4, 7, 5, 3 },
                { 8, 5, 9, 9, 3 },
                { 7, 8, 7, 9, 3 },
                { 3, 7, 3, 7, 7 }
            };

            int wait = 30;
            int res = ds.Calculate(matrix);

            Assert.AreEqual(wait, res);
        }
    }
}
