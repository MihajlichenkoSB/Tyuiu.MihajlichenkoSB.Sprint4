using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.MihajlichenkoSB.Sprint4.Task6.V23.Lib
{
    public class DataService : ISprint4Task6V23
    {
        public int Calculate(string[] array)
        {
            int count = 0;
            int targetLength = 6;

            foreach (string word in array)
            {
                if (word.Length == targetLength)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
