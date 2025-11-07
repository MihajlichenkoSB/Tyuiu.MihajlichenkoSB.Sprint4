using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.MihajlichenkoSB.Sprint4.Task4.V17.Lib
{
    public class DataService : ISprint4Task4V17
    {
        public int Calculate(int[,] matrix)
        {
            int columnIndex = 1;
            int sum = 0;

            int rows = matrix.GetLength(0);

            for (int i = 0; i < rows; i++)
            {
                sum += matrix[i, columnIndex];
            }

            return sum;
        }
    }
}
