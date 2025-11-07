using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.MihajlichenkoSB.Sprint4.Task3.V9.Lib
{
    public class DataService : ISprint4Task3V9
    {
        public int Calculate(int[,] array)
        {
            int columnIndex = 1;
            int sum = 0;

            int rows = array.GetLength(0);

            for (int i = 0; i < rows; i++)
            {
                sum += array[i, columnIndex];
            }

            return sum;
        }
    }
}
