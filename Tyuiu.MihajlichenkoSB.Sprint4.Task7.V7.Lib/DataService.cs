using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.MihajlichenkoSB.Sprint4.Task7.V7.Lib
{
    public class DataService : ISprint4Task7V7
    {
        public int Calculate(int n, int m, string value)
        {
            int rows = 4;
            int columns = 2;

            int[,] matrix = new int[rows, columns];
            int countOdd = 0;
            int index = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = int.Parse(value[index].ToString());
                    index++;
                }
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i, j] % 2 != 0)
                    {
                        countOdd++;
                    }
                }
            }

            return countOdd;
        }
    }
}
