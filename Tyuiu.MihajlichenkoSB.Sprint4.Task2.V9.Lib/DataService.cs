using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.MihajlichenkoSB.Sprint4.Task2.V9.Lib
{
    public class DataService : ISprint4Task2V9
    {
        public int Calculate(int[] array)
        {
            int sumArray = 0;

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > 10)
                {
                    sumArray += array[i];
                }
            }
            return sumArray;
        }
    }
}
