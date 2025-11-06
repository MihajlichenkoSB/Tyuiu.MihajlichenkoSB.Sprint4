using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.MihajlichenkoSB.Sprint4.Task0.V5.Lib
{
    public class DataService : ISprint4Task0V5
    {
        // Метод изменен для возврата int[], а не int
        public int[] GetSumEvenArrEl(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == 0)
                {
                    array[i] = 1;
                }
            }
            return array; 
        }

        int ISprint4Task0V5.GetSumEvenArrEl(int[] array)
        {
            throw new NotImplementedException();
        }
    }
}
