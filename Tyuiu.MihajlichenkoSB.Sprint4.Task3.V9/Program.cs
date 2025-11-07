using Tyuiu.MihajlichenkoSB.Sprint4.Task3.V9.Lib;
namespace Tyuiu.MihajlichenkoSB.Sprint4.Task3.V9
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            DataService ds = new DataService();
            Console.Title = "Спринт #3 |  Выполнил: Михайличенко С.Б. | ИИПб-25-1";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #4                                                                *");
            Console.WriteLine("* Тема: Одномерные массивы. (генератор случайных чисел)                    *");
            Console.WriteLine("* Задание #2                                                               *");
            Console.WriteLine("* Вариант #9                                                               *");
            Console.WriteLine("* Выполнил: Михайличенко Сергей Борисович | ИИПб-25-1                      *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 14 элементов заполненный          *");
            Console.WriteLine("* случайными в диапазоне от 1 до 7 подсчитать произведение четных          *");
            Console.WriteLine("* элементов массива.                                                       *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            int[,] array = new int[5, 5] {
                { 9, 6, 4, 5, 3 },
                { 7, 4, 7, 5, 3 },
                { 8, 5, 9, 9, 3 },
                { 7, 8, 7, 9, 3 },
                { 3, 7, 3, 7, 7 }
            };

            Console.WriteLine("Исходный массив 5x5:");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write($"{array[i, j]}\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            int res = ds.Calculate(array);

            Console.WriteLine($"Сумма элементов во втором столбце: {res}");
            Console.ReadKey();
        }
    }
}
