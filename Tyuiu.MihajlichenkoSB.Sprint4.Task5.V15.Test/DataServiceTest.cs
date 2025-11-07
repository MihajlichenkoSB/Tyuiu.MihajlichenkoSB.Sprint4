using Tyuiu.MihajlichenkoSB.Sprint4.Task5.V15.Lib;
namespace Tyuiu.MihajlichenkoSB.Sprint4.Task5.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[,] array = new int[,] {
                { 2, 3, 2, 4, 3 },
                { 4, 7, 4, 2, 2 },
                { 5, 2, 3, 4, 6 },
                { 5, 2, 7, 6, 5 },
                { 6, 3, 5, 7, 7 }
            };

            int expected = 49;

            int actual = ds.Calculate(array);

            Assert.AreEqual(expected, actual);
        }
    }
}
