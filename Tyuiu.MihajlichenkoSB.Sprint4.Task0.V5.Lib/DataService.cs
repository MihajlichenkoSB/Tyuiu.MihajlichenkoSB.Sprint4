using tyuiu.cources.programming.interfaces.Sprint4;
// using System; // Возможно, этот using вам не нужен, если вы его не используете явно

namespace Tyuiu.MihajlichenkoSB.Sprint4.Task0.V5.Lib
{
    public class DataService : ISprint4Task0V5
    {
        // Метод должен возвращать int (сумму), а не int[]
        public int GetSumEvenArrEl(int[] array)
        {
            int sum = 0; // 1. Инициализируем переменную для хранения суммы нулем

            // 2. Используем цикл для прохода по всем элементам массива
            for (int i = 0; i < array.Length; i++)
            {
                // 3. Проверяем, является ли текущий элемент четным
                if (array[i] % 2 == 0)
                {
                    // 4. Если четный, добавляем его к нашей сумме
                    sum += array[i];
                }
            }

            return sum; // 5. Возвращаем итоговую сумму (24 для вашего массива)
        }
    }
}
