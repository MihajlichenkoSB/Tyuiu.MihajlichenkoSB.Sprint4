using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.MihajlichenkoSB.Sprint4.Task1.V9.Lib
{
    public class DataService : ISprint4Task1V9
    {
        public int Calculate(int[] array)
        {
            // Для произведения начальное значение должно быть 1, а не 0 (чтобы избежать умножения на 0)
            int multiplyArray = 1;

            // Цикл должен проходить до конца массива (i < array.Length)
            for (int i = 0; i < array.Length; i++)
            {
                // Проверяем, является ли элемент четным
                if (array[i] % 2 == 0)
                {
                    // Умножаем
                    multiplyArray *= array[i];
                }
            }
            return multiplyArray;
        }
    }
}
