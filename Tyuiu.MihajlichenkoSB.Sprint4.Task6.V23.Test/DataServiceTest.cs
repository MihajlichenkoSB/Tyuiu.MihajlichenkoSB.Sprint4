using Tyuiu.MihajlichenkoSB.Sprint4.Task6.V23.Lib;

namespace Tyuiu.MihajlichenkoSB.Sprint4.Task6.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string[] stringArray = new string[] { "Microsoft", "Google", "Apple", "Amazon", "Facebook", "Tesla", "Netflix" };

            int expected = 2;

            int actual = ds.Calculate(stringArray);

            Assert.AreEqual(expected, actual);
        }
    }
}
