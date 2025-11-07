using Tyuiu.MihajlichenkoSB.Sprint4.Task5.V15.Lib;
namespace Tyuiu.MihajlichenkoSB.Sprint4.Task5.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            // Массив взят из лога Build Output
            int[,] array = new int[,] {
                { 0, -5, 0, 3, -4 },
                { -1, -1, -5, 0, -5 },
                { 2, 4, -6, 4, -2 },
                { 2, 1, -3, 2, 1 },
                { 1, -5, 3, 0, -6 }
            };

            // Ожидаемый результат (сумма положительных: 3+2+4+4+2+1+2+1+1+3 = 23)
            int expected = 23;
            int actual = ds.Calculate(array);

            Assert.AreEqual(expected, actual);
        }
    }
}
